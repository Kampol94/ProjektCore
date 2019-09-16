using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;

namespace ProjektCoreUWP
{
    public class IdKategoriiDoObrazka : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            int n = (int)value;
            string path = $"{Environment.CurrentDirectory}/Assets/kategorie{n}-male.jpeg";
            var image = new BitmapImage(new Uri(path));
            return image;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
