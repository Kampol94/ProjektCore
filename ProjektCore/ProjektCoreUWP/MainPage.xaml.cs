using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace ProjektCoreUWP
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void NawigacjaView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            switch (args.InvokedItem.ToString())
            {
                case "Kategorie":
                    TrescFrame.Navigate(typeof(KategoriePage));
                    break;
                case "Produkty":
                    TrescFrame.Navigate(typeof(ProduktyPage));
                    break;
                default:
                    TrescFrame.Navigate(typeof(BezImplementacji));
                    break;
            }

        }

        private void NawigacjaView_Loaded(object sender, RoutedEventArgs e)
        {
            NawigacjaView.MenuItems.Add(new NavigationViewItem
            {
                Content = "Kategorie",
                Icon = new SymbolIcon(Symbol.BrowsePhotos),
                Tag = "kategorie"
            });
            NawigacjaView.MenuItems.Add(new NavigationViewItem
            {
                Content = "Produkty",
                Icon = new SymbolIcon(Symbol.AllApps),
                Tag = "produkty"
            });
            NawigacjaView.MenuItems.Add(new NavigationViewItem
            {
                Content = "Dostawcy",
                Icon = new SymbolIcon(Symbol.Contact2),
                Tag = "dostawcy"
            });
            NawigacjaView.MenuItems.Add(new NavigationViewItemSeparator());
            NawigacjaView.MenuItems.Add(new NavigationViewItem
            {
                Content = "Klienci",
                Icon = new SymbolIcon(Symbol.People),
                Tag = "klienci"
            });
            NawigacjaView.MenuItems.Add(new NavigationViewItem
            {
                Content = "Zamówienia",
                Icon = new SymbolIcon(Symbol.PhoneBook),
                Tag = "zamowienia"
            });
            NawigacjaView.MenuItems.Add(new NavigationViewItem
            {
                Content = "Spedytorzy",
                Icon = new SymbolIcon(Symbol.PostUpdate),
                Tag = "spedytorzy"
            });

        }

        private async void OdswiezButton_Click(object sender, RoutedEventArgs e)
        {
            var notImplementedDialog = new ContentDialog
            {
                Title = "Nie zaimplementowano",
                Content = "Funkcja nie została jeszcze zaimplementowana",
                CloseButtonText = "Ok"
            };
            ContentDialogResult result = await notImplementedDialog.ShowAsync();
        }
    }
}
