using System;

using Windows.UI.Xaml.Controls;

using WTS_Universal_Windows_.ViewModels;

namespace WTS_Universal_Windows_.Views
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
