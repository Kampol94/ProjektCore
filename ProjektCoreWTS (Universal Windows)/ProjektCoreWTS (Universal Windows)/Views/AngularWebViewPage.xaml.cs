using System;

using ProjektCoreWTS__Universal_Windows_.ViewModels;

using Windows.UI.Xaml.Controls;

namespace ProjektCoreWTS__Universal_Windows_.Views
{
    public sealed partial class AngularWebViewPage : Page
    {
        private AngularWebViewViewModel ViewModel
        {
            get { return ViewModelLocator.Current.AngularWebViewViewModel; }
        }

        public AngularWebViewPage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
