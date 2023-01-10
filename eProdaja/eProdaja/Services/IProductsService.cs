using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static eProdaja.Controllers.ProductsController;

namespace eProdaja.Services
{
    public interface IProductsService
    {
        IEnumerable<Products> Get();
        Products GetById(int id);
        Products Insert(Products p);
        Products Update(int id, Products p);


    }
}
