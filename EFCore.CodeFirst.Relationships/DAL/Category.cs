using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.Relationships.DAL
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>(); // Initialize the Products list in the constructor
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set;}
        
        //public ICollection<Product> Products { get; set; }
    }
}
