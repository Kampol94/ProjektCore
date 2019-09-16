using System;

using Windows.UI.Xaml.Controls;

using WTS_Universal_Windows_.ViewModels;

namespace WTS_Universal_Windows_.Views
{
    public sealed partial class OAplikacjiPage : Page
    {
        private OAplikacjiViewModel ViewModel
        {
            get { return ViewModelLocator.Current.OAplikacjiViewModel; }
        }

        public OAplikacjiPage()
        {
            InitializeComponent();
        }
    }
}
