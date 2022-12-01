﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Business.Abstract;
using Northwind.DataAccess.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Abstract;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal= productDal;
        }
        public List<Product> GetAll()
        {
            //Business Code
            return _productDal.GetAll();
        }
    }
}