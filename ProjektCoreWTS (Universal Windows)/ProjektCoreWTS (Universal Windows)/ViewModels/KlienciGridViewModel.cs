using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using GalaSoft.MvvmLight;

using ProjektCoreWTS__Universal_Windows_.Core.Models;
using ProjektCoreWTS__Universal_Windows_.Core.Services;

namespace ProjektCoreWTS__Universal_Windows_.ViewModels
{
    public class KlienciGridViewModel : ViewModelBase
    {
        public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

        public KlienciGridViewModel()
        {
        }

        public async Task LoadDataAsync()
        {
            Source.Clear();

            // TODO WTS: Replace this with your actual data
            var data = await SampleDataService.GetGridDataAsync();

            foreach (var item in data)
            {
                Source.Add(item);
            }
        }
    }
}
