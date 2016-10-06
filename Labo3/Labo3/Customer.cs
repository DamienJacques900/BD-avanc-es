using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3
{
    public class Customer
    {
        private double accountBalance;
        private String addressLine1;
        private String addressLine2;
        private String city;
        private String country;
        private String email;
        private long id;
        private String name;
        private String postCode;
        private String remark;

        public double AccountBalance
        {
            get
            {
                return accountBalance;
            }

            set
            {
                accountBalance = value;
            }
        }


        public string AddressLine1
        {
            get
            {
                return addressLine1;
            }

            set
            {
                addressLine1 = value;
            }
        }

        public string AddressLine2
        {
            get
            {
                return addressLine2;
            }

            set
            {
                addressLine2 = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string PostCode
        {
            get
            {
                return postCode;
            }

            set
            {
                postCode = value;
            }
        }

        public string Remark
        {
            get
            {
                return remark;
            }

            set
            {
                remark = value;
            }
        }

        [Timestamp] // sera obligé de mettre pour des BD avec accès concurrentiel. C'est le système qui gère. 
        public byte[] RowVersion { get; set; }
        /*
        public Customer(double accountBalance, String addressLine1, String addressLine2, String city, String email, long id, String name, String postCode, String remark)
        {
            AccountBalance = accountBalance;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            Email = email;
            Id = id;
            Name = name;
            PostCode = postCode;
            Remark = remark;
        }
        */

    }
}
