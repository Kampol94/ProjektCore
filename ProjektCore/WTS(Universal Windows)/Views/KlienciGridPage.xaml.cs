using System;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

using WTS_Universal_Windows_.ViewModels;

namespace WTS_Universal_Windows_.Views
{
    // For more info about the TreeView Control see
    // https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/tree-view
    // For other samples, get the XAML Controls Gallery app http://aka.ms/XamlControlsGallery
    public sealed partial class KlienciGridPage : Page
    {
        private KlienciGridViewModel ViewModel
        {
            get { return ViewModelLocator.Current.KlienciGridViewModel; }
        }

        public KlienciGridPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            await ViewModel.LoadDataAsync();
        }
    }
}
