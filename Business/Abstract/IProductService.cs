using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        void Add(Products products);
        IEnumerable<Products> GetAll();
    }
}