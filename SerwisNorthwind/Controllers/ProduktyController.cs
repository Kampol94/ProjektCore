using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Packt.CS7;

namespace SerwisNorthwind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduktyController : ControllerBase
    {
        private readonly Northwind bd;

        public ProduktyController (Northwind bd)
        {
            this.bd = bd;
        }

        //Get: api/produkty
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var produkty = bd.Products.ToArray();
            return produkty;
        }

        //GET: api/produkty/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            var produkt = bd.Products.Find(id);
            return produkt;
        }
    }
}