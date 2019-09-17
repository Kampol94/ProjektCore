using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ProjektCoreMobile.Models
{
    public class Customer : INotifyPropertyChanged
    {

        public static IList<Customer> Customers;

        static Customer()
        {
            Customers = new ObservableCollection<Customer>();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private string customerID;
        private string companyName;
        private string contactName;
        private string city;
        private string country;
        private string phone;


        public string CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerID"));
            }
        }
        public string CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                companyName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CompanyName"));
            }
        }
        public string ContactName
        {
            get
            {
                return contactName;
            }
            set
            {
                contactName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ContactName"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("City"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Country"));
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Phone"));
            }
        }
        public string Location
        {
            get
            {
                return string.Format("{0}, {1}", City, Country);
            }
            
        }

        //pod testy

        public static void SampleData()
        {
            Customers.Clear();
            Customers.Add(new Customer
            {
                CustomerID = "Alfki",
                CompanyName = "Alfred company",
                ContactName = "Maria Anders",
                City = "Berlin",
                Country = "Germany",
                Phone = "030-0074321"
            });
            Customers.Add(new Customer
            {
                CustomerID = "Alfki2",
                CompanyName = "Alfred company2",
                ContactName = "Maria Anders2",
                City = "Berlin2",
                Country = "Germany2",
                Phone = "030-0074323"
            });
            Customers.Add(new Customer
            {
                CustomerID = "Alfki3",
                CompanyName = "Alfred company3",
                ContactName = "Maria Anders3",
                City = "Berlin3",
                Country = "Germany3",
                Phone = "030-0074324"
            });


        }




    }
}
