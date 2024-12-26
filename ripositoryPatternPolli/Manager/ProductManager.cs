using EF.Core.Repository.Manager;
using Microsoft.Identity.Client;
using ripositoryPatternPolli.Data;
using ripositoryPatternPolli.Interfaces.Manager;
using ripositoryPatternPolli.Models;
using ripositoryPatternPolli.Repository;

namespace ripositoryPatternPolli.Manager
{
    public class ProductManager : CommonManager<Product>,IProductManager
    {

        public ProductManager(ApplicationDbContext dbContext) : base(new ProductRepository(dbContext))
        {
            
        }

        public Product GetById(int id)
        {
            return GetFirstOrDefault( c => c.Id == id );

        }
    }
}
