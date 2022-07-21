using eShop.CoreBusiness.Models;
using System.Threading.Tasks;

namespace eShop.UseCases.CustomerPortal.ShoppingCartScreen
{
    public interface IPlaceOrderUseCase
    {
        Task<string> Execute(Order order);
    }
}