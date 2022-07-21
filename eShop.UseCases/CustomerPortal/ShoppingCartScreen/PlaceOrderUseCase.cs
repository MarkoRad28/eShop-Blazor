using eShop.CoreBusiness.Models;
using eShop.CoreBusiness.Services;
using eShop.UseCases.CustomerPortal.PluginInterfaces.DataStore;
using eShop.UseCases.CustomerPortal.PluginInterfaces.StateStore;
using eShop.UseCases.CustomerPortal.PluginInterfaces.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
//TODO Promeniti lokaciju klase i interfejsa
namespace eShop.UseCases.CustomerPortal.ShoppingCartScreen
{
    public class PlaceOrderUseCase : IPlaceOrderUseCase
    {
        private readonly IOrderService orderService;
        private readonly IOrderRepository orderRepository;
        private readonly IShoppingCart shoppingCart;
        private readonly IShoppingCartStateStore shoppingCartStateStore;

        public PlaceOrderUseCase(IOrderService orderService, IOrderRepository orderRepository, IShoppingCart shoppingCart
                                 , IShoppingCartStateStore shoppingCartStateStore)
        {
            this.orderService = orderService;
            this.orderRepository = orderRepository;
            this.shoppingCart = shoppingCart;
            this.shoppingCartStateStore = shoppingCartStateStore;
        }

        public async Task<string> Execute(Order order)
        {
            if (orderService.ValidateCreateOrder(order))
            {
                order.DatePlaced = DateTime.Now;
                order.Uid = Guid.NewGuid().ToString();
                orderRepository.CreateOrder(order);

                await this.shoppingCart.EmptyAsync();
                this.shoppingCartStateStore.UpdateLineItemsCount();

                return order.Uid;
            }

            return null;
        }
    }
}
