using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace docker1.Models
{
    public class MockProductRepository : IProductRepository
    {
        private static readonly Product[] DummyData = new Product[]
        {
            new Product { ProductID ="A00001", Name = "产品1", Category = "分类1", Price = 101 },
            new Product {  ProductID ="B00001",Name = "产品2", Category = "分类1", Price = 102 },
            new Product {  ProductID ="C00001",Name = "产品3", Category = "分类2", Price = 103 },
            new Product {  ProductID ="D00001",Name = "产品4", Category = "分类2", Price = 104 },
        };
        //public IQueryable<Product> Products => DummyData.AsQueryable();
        public IQueryable<Product> Products { get { return DummyData.AsQueryable<Product>(); } }

    }
}
