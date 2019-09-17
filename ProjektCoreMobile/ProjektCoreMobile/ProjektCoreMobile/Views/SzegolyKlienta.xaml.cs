﻿using ProjektCoreMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjektCoreMobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CustomerDetails : ContentPage
	{
        private bool newCustomer = false;
		public CustomerDetails ()
		{
			InitializeComponent ();
            BindingContext = new Customer();
            newCustomer = true;
            Title = "Dodaj klienta";
		}

        public CustomerDetails(Customer customer)
        {
            InitializeComponent();
            BindingContext = customer;
            InsertButton.IsVisible = false;

        }
        async void InsertButton_Clicked(object sender, EventArgs e)
        {
            if(newCustomer)
            {
                Customer.Customers.Add((Customer)BindingContext);
            }
            await Navigation.PopAsync(animated: true);
        }

    }
}