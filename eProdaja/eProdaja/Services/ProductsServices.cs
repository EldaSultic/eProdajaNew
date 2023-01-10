using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static eProdaja.Controllers.ProductsController;

namespace eProdaja.Services
{
    public class ProductsServices : IProductsService
    {
        private static List<Products> _list;
        static ProductsServices()
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
        public IEnumerable<Products> Get()
        {

            return _list;
        }

        public Products GetById(int id)
        {
            return _list.FirstOrDefault(x => x.Id == id);
        }
        public Products Insert(Products p)
        {
            _list.Add(p);
            return p;
        }
        public Products Update(int id, Products p)
        {
            var current = _list.FirstOrDefault(x => x.Id == id);
            current.Name = p.Name;
            return current;
        }

    }
}
