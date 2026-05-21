using Apps.Core.Models;
using Apps.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Core.Contracts
{
   public interface IProductService
    {
        public Product Add(Product product);
        public bool Update(Product product);
        public bool Delete(string id );
        public Product GetById(string id);
        public List<Product> GetAll();
        public  List<Product> Search(string text, ProductCategoryEnum? category, ProductCategoryStatus? status);

    }
}
