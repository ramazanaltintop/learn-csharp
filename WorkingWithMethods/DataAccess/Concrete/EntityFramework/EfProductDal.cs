﻿using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product{FirstName = "Laptop"}
            };
        }
    }
}
