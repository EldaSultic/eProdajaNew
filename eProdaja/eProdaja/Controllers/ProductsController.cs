using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private static List<Products> _list;
        static ProductsController()
        {
            _list = new List<Products> {
                new Products()
                {
                    Id=1,
                    Name="Laptop"
                },
                new Products()
                {
                    Id=2,
                    Name="Mouse"
                }
            };
        }



        [HttpGet]
        public IEnumerable<Products> Get()
        {

            return _list;
        }

        [HttpGet("{id}")]
        public Products GetById(int id)
        {
            return _list.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public Products Insert(Products p)
        {
            _list.Add(p);
            return p;
        }

        [HttpPut("{id}")]
        public Products Update(int id, Products p)
        {
            var current = _list.FirstOrDefault(x => x.Id == id);
            current.Name = p.Name;
            return current;
        }

        public class Products
    {
            public int Id { get; set; }
            public string Name { get; set; }

    }
            

    }
}
