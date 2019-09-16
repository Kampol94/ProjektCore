using System;

using ProjektCoreWTS__Universal_Windows_.ViewModels;

using Windows.UI.Xaml.Controls;

namespace ProjektCoreWTS__Universal_Windows_.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return ViewModelLocator.Current.MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
