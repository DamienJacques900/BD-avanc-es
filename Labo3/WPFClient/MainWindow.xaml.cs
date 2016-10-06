using Labo3;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CompanyContext _context = new CompanyContext();
        private Customer _customer;
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _context.Database.Initialize(true);
            _customer = _context.Customers.ToList().ElementAt(0);//met les valeurs de la BD dans une liste et on prend le première élément. 
            Formulaire.DataContext = _customer;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double nouveau_montant = _customer.AccountBalance + (double)MontantAAjouterAuCompte.Value;
            _customer.AccountBalance = nouveau_montant;
            try
            {
                _context.SaveChanges();
            }
            catch(DbUpdateConcurrencyException expection)
            {
                System.Console.Write(expection);
            }
        }
    }
}
