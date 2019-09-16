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
    public class KategorieController : ControllerBase
    {
        private readonly Northwind bd;

        public KategorieController (Northwind bd)
        {
            this.bd = bd;
        }

        //Get: api/kategorie
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            var kategorie = bd.Categories.ToArray();
            return kategorie;
        }

        //GET: api/kategorie/5
        [HttpGet("{id}")]//("{id}")
        public Category Get(int id)
        {
            var katetoria = bd.Categories.Find(id);
            return katetoria;
        }
    }
}