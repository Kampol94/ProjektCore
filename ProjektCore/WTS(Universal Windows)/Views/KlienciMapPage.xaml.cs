using System;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

using WTS_Universal_Windows_.ViewModels;

namespace WTS_Universal_Windows_.Views
{
    public sealed partial class KlienciMapPage : Page
    {
        private KlienciMapViewModel ViewModel
        {
            get { return ViewModelLocator.Current.KlienciMapViewModel; }
        }

        public KlienciMapPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            await ViewModel.InitializeAsync(mapControl);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            ViewModel.Cleanup();
        }
    }
}
