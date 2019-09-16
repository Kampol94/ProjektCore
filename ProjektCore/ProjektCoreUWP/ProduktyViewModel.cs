using Packt.CS7;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ProjektCoreUWP
{
    public class ProduktyViewModel
    {

        public class ProduktyJson
        {
            public int productID;
            public string productName;
            public int supplierID;
            public int categoryID;
            public string quantityPerUnit;
            public decimal unitPrice;
            public short unitsInStock;
            public short unitsOnOrder;
            public short reorderLevel;
            public bool discontinued;


        }
        public ObservableCollection<Product> Produkty { get; set; }

        public ProduktyViewModel()
        {
            using (var http = new HttpClient())
            {
                http.BaseAddress = new Uri("http://localhost:5001/");
                var serializer = new DataContractJsonSerializer(typeof(List<ProduktyJson>));
                var strumien = http.GetStreamAsync("api/produkty").Result;

                var listaProduktow = serializer.ReadObject(strumien) as List<ProduktyJson>;
                var produkty = listaProduktow.Select(p => new Product
                {
                    ProductID = p.productID,
                    ProductName = p.productName,
                    UnitPrice = p.unitPrice,
                    CategoryID = p.categoryID
                });
                Produkty = new ObservableCollection<Product>(produkty);

            }
        }

        public ProduktyViewModel(int id)
        {
            using (var http = new HttpClient())
            {
                http.BaseAddress = new Uri("http://localhost:5001/");
                var serializer = new DataContractJsonSerializer(typeof(List<ProduktyJson>));
                var strumien = http.GetStreamAsync($"api/produkty").Result;

                var listaProduktow = serializer.ReadObject(strumien) as List<ProduktyJson>;
                var produkty = listaProduktow.Select(p => new Product
                {
                    ProductID = p.productID,
                    ProductName = p.productName,
                    UnitPrice = p.unitPrice,
                    CategoryID = p.categoryID
                }).Where(p => p.CategoryID ==id);
                Produkty = new ObservableCollection<Product>(produkty);

            }
        }
    }
}
