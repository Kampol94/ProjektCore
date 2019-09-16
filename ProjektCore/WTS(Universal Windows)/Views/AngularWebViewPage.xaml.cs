using System;

using Windows.UI.Xaml.Controls;

using WTS_Universal_Windows_.ViewModels;

namespace WTS_Universal_Windows_.Views
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
