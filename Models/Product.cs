using CsharpProject.Canstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject.Models
{
    internal class Product : BaseEntity

    {
        public Product() 
        {
        
        
        
        }


        public Product(string name, string brandName, int count, decimal price, string Name) : base(false, 1,1000) 
        {
            Name = name;
            BrandName = brandName;
            Count = count;
            Price = price;
        
        }
        public int id { get; set; }

        public string Name { get; set; }

        public string BrandName { get; set; }

        public decimal Price { get; set; }

        public bool IsValidetion { get; set; }

        public int Count { get; set; }
    }
}
