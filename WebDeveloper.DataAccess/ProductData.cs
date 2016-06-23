using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ProductData : BaseDataAccess<Product>
    {
        //Inicio clase
        public List<Product> GetFakeProducts()
        {
            return new List<Product>
            {
                new Product { ID=1, Description = "Cristal", Price = 3.5, CreateDate = null},
                new Product { ID=1, Description = "Pilsen", Price = 0.0, CreateDate = DateTime.Now},
                new Product { ID=1, Description = "Cusqueña", Price = 2.6, CreateDate = null},
                new Product { ID=1, Description = "Sublime", Price = 0.0, CreateDate = DateTime.Now},
                new Product { ID=1, Description = "Cocacola", Price = 4.2, CreateDate = null},
                new Product { ID=1, Description = "Inka Cola", Price = 0.5, CreateDate = DateTime.Now},
                new Product { ID=1, Description = "7Up", Price = 4.2, CreateDate = null},
                new Product { ID=1, Description = "Pepsi", Price = 0.5, CreateDate = DateTime.Now}
            };
        }
        //Final clase
    }
}
