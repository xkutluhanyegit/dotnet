using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Products products)
        {
            ValidationTool.Validate( new ProductValidator(),products);
            _productDal.Add(products);
        }

        public IEnumerable<Products> GetAll()
        {
            var result = _productDal.GetAll();
            return result.ToList();
            
        }
    }
}