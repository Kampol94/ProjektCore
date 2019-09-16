using System;

using ProjektCoreWTS__Universal_Windows_.ViewModels;

using Windows.UI.Xaml.Controls;

namespace ProjektCoreWTS__Universal_Windows_.Views
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
