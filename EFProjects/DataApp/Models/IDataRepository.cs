using System.Collections.Generic;
using System.Linq;


namespace DataApp.Models
{
    public interface IDataRepository
    {
        //At first get all Products from DB and only after that do same filters.
        //IEnumerable<Product> Products { get; }
        
        //Get only those rows from DB that requires a condition.
        //IQueryable<Product> Products { get; }
        
        Product GetProduct(long id);
        
        IEnumerable<Product> GetAllProducts();
        
        void CreateProduct(Product newProduct);
        
        void UpdateProduct(Product changedProduct);
        
        void DeleteProduct(long id);
    }
}