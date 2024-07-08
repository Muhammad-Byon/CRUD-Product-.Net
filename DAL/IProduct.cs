using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UASWebApp2001092011.Models;

namespace UASWebApp2001092011.DAL
{
    public interface IProduct
    {
        IEnumerable<Product> GetAll();
        Product Get(int id);
        void Add(Product product);
        void Update (int id, Product product);
        void Delete(int id);
    }
}