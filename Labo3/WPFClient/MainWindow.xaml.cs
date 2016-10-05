using Labo3;
using System;
using System.Collections.Generic;
using System.Data;
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
            _customer = new Customer()
            {
                AccountBalance = 20,
                AddressLine1 = "Rue Machin",
                AddressLine2 = "Village Truc",
                City = "Namur",
                Email = "machin@gmail.com",
                Id = 1,
                Name = "Damien",
                PostCode = "5000",
                Remark = "Génie",
            };

            Formulaire.DataContext = _customer;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double nouveau_montant = _customer.AccountBalance + (double)MontantAAjouterAuCompte.Value;
            _customer.AccountBalance = nouveau_montant;
            SqlConnection connexion = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ConcurrencyDemo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            using (connexion)
            {
                connexion.Open();

                SqlCommand command = new SqlCommand("update Customers set [AccountBalance] = @nouveau_montant where [Id] = 1", connexion);
                command.Parameters.Add("@nouveau_montant", SqlDbType.Float);
                command.Parameters["@nouveau_montant"].Value = nouveau_montant;

                command.ExecuteNonQuery();
                connexion.Close();
            }
        }
    }
}
