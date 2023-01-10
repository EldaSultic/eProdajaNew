using eProdaja.Services;
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

        public IProductsService _productsService { get; set; }

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }


        [HttpGet]
        public IEnumerable<Products> Get()
        {

            return _productsService.Get();
        }

        [HttpGet("{id}")]
        public Products GetById(int id)
        {
            return _productsService.GetById(id);
        }

        [HttpPost]
        public Products Insert(Products p)
        {
            return _productsService.Insert(p);
        }

        [HttpPut("{id}")]
        public Products Update(int id, Products p)
        {
            return _productsService.Update(id,p);
        }

        public class Products
        {
            public int Id { get; set; }
            public string Name { get; set; }

        }


    }
}
