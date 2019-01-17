using System;
 using System.Collections.Generic;
 using System.Linq;
 using Newtonsoft.Json;
 
 namespace DataApp.Models
 {
     public class EFDataRepository : IDataRepository
     {
         private EFDatabaseContext context;
 
         public EFDataRepository(EFDatabaseContext ctx)
         {
             context = ctx;
         }
 
         public Product GetProduct(long id)
         {
             return context.Products.Find(id);
         }
 
         public IEnumerable<Product> GetAllProducts()
         {
             Console.WriteLine("GetAllProducts");
             return context.Products;
         }
 
         public void CreateProduct(Product newProduct)
         {
             Console.WriteLine("CreateProduct: "+ JsonConvert.SerializeObject(newProduct));
         }
 
         public void UpdateProduct(Product changedProduct)
         {
             Console.WriteLine("UpdateProduct : " + JsonConvert.SerializeObject(changedProduct));
         }
 
         public void DeleteProduct(long id)
         {
             Console.WriteLine("DeleteProduct: " + id);
         }
     }
 }