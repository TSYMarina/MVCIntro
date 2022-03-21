﻿using System.Collections.Generic;
using System.Data;
using Dapper;
using MVCIntro.Models;

namespace MVCIntro
{
    public class ProductRepository : IProductRepository
    {

        private readonly IDbConnection _conn;
        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public Product GetProduct(int id)
        {
            return _conn.QuerySingle<Product>("SELECT * FROM PRODUCTS WHERE PRODUCTID = @id",
     new { id = id });
        }

        IEnumerable<Product> IProductRepository.GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM PRODUCTS;");
        }
    }
}