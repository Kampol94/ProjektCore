using System;

using GalaSoft.MvvmLight.Ioc;

using WTS_Universal_Windows_.Services;
using WTS_Universal_Windows_.Views;

namespace WTS_Universal_Windows_.ViewModels
{
    [Windows.UI.Xaml.Data.Bindable]
    public class ViewModelLocator
    {
        private static ViewModelLocator _current;

        public static ViewModelLocator Current => _current ?? (_current = new ViewModelLocator());

        private ViewModelLocator()
        {
            SimpleIoc.Default.Register(() => new NavigationServiceEx());
            SimpleIoc.Default.Register<ShellViewModel>();
            Register<MainViewModel, MainPage>();
            Register<OAplikacjiViewModel, OAplikacjiPage>();
            Register<AngularWebViewViewModel, AngularWebViewPage>();
            Register<KategorieMasterDetailViewModel, KategorieMasterDetailPage>();
            Register<KlienciGridViewModel, KlienciGridPage>();
            Register<KlienciMapViewModel, KlienciMapPage>();
            Register<SettingsViewModel, SettingsPage>();
        }

        public SettingsViewModel SettingsViewModel => SimpleIoc.Default.GetInstance<SettingsViewModel>();

        public KlienciMapViewModel KlienciMapViewModel => SimpleIoc.Default.GetInstance<KlienciMapViewModel>();

        public KlienciGridViewModel KlienciGridViewModel => SimpleIoc.Default.GetInstance<KlienciGridViewModel>();

        public KategorieMasterDetailViewModel KategorieMasterDetailViewModel => SimpleIoc.Default.GetInstance<KategorieMasterDetailViewModel>();

        public AngularWebViewViewModel AngularWebViewViewModel => SimpleIoc.Default.GetInstance<AngularWebViewViewModel>();

        public OAplikacjiViewModel OAplikacjiViewModel => SimpleIoc.Default.GetInstance<OAplikacjiViewModel>();

        public MainViewModel MainViewModel => SimpleIoc.Default.GetInstance<MainViewModel>();

        public ShellViewModel ShellViewModel => SimpleIoc.Default.GetInstance<ShellViewModel>();

        public NavigationServiceEx NavigationService => SimpleIoc.Default.GetInstance<NavigationServiceEx>();

        public void Register<VM, V>()
            where VM : class
        {
            SimpleIoc.Default.Register<VM>();

            NavigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}
