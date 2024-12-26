using EF.Core.Repository.Interface.Manager;
using ripositoryPatternPolli.Models;

namespace ripositoryPatternPolli.Interfaces.Manager
{
    public interface IProductManager:ICommonManager<Product>
    {

        Product GetById(int id);


    }
}
