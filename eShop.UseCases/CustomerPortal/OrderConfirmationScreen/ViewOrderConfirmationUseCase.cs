using eShop.CoreBusiness.Models;
using eShop.UseCases.CustomerPortal.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.UseCases.CustomerPortal.OrderConfirmationScreen
{
    public class ViewOrderConfirmationUseCase : IViewOrderConfirmationUseCase
    {
        private readonly IOrderRepository orderRepository;

        public ViewOrderConfirmationUseCase(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        public Order Execute(string uniqueId)
        {
            return orderRepository.GetOrderByUniqueId(uniqueId);
        }
    }
}
