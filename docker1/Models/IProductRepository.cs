using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace docker1.Models
{
    public interface IProductRepository
    {
        public IQueryable<Product> Products { get; }

    }
}
