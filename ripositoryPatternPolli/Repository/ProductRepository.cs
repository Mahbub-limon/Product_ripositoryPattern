using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ripositoryPatternPolli.Interfaces.Repository;
using ripositoryPatternPolli.Models;

namespace ripositoryPatternPolli.Repository
{
    public class ProductRepository : CommonRepository<Product>,IProductRepository
    {
        public ProductRepository(DbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
