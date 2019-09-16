using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Packt.CS7;

namespace ProjektCoreUWP
{
    public class KategorieViewModel
    {
        public class KategorieJson
        {
            public int categoryID;
            public string categoryName;
            public string description;
        }
        public ObservableCollection<Category> Kategorie { get; set; }

        public KategorieViewModel()
        {
            using (var http = new HttpClient())
            {
                http.BaseAddress = new Uri("http://localhost:5001/");
                var serializer = new DataContractJsonSerializer(typeof(List<KategorieJson>));
                var strumien = http.GetStreamAsync("api/kategorie").Result;
                
                var listaKategori = serializer.ReadObject(strumien) as List<KategorieJson>;
                var katetorie = listaKategori.Select(c => new Category
                {
                    CategoryID = c.categoryID,
                    CategoryName = c.categoryName,
                    Description = c.description
                });
                Kategorie = new ObservableCollection<Category>(katetorie);

            }
        }

    }
}
