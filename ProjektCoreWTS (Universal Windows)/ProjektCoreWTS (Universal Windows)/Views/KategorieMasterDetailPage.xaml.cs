using System;

using ProjektCoreWTS__Universal_Windows_.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace ProjektCoreWTS__Universal_Windows_.Views
{
    public sealed partial class KategorieMasterDetailPage : Page
    {
        private KategorieMasterDetailViewModel ViewModel
        {
            get { return ViewModelLocator.Current.KategorieMasterDetailViewModel; }
        }

        public KategorieMasterDetailPage()
        {
            InitializeComponent();
            Loaded += KategorieMasterDetailPage_Loaded;
        }

        private async void KategorieMasterDetailPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync(MasterDetailsViewControl.ViewState);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            // Workaround for issue on MasterDetail Control. Find More info at https://github.com/Microsoft/WindowsTemplateStudio/issues/2738
            ViewModel.Selected = null;
        }
    }
}
