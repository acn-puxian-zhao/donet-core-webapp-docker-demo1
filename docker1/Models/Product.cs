using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace docker1.Models
{
    public class Product
    {
        public Product() { }
        public Product(string name = null, string category = null, decimal price = 0)
        {
            Name = name;
            Category = category;
            Price = price;
        }
        public string ProductID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

        public string FullName { get { return this.Category + this.Name; } }
        public string FullName1 => this.Category + this.Name;
    }
}
