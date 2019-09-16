using System;

using ProjektCoreWTS__Universal_Windows_.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace ProjektCoreWTS__Universal_Windows_.Views
{
    public sealed partial class KlienciGridPage : Page
    {
        private KlienciGridViewModel ViewModel
        {
            get { return ViewModelLocator.Current.KlienciGridViewModel; }
        }

        // TODO WTS: Change the grid as appropriate to your app, adjust the column definitions on KlienciGridPage.xaml.
        // For help see http://docs.telerik.com/windows-universal/controls/raddatagrid/gettingstarted
        // You may also want to extend the grid to work with the RadDataForm http://docs.telerik.com/windows-universal/controls/raddataform/dataform-gettingstarted
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
