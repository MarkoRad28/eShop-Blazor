﻿using eShop.CoreBusiness.Models;
using eShop.UseCases.CustomerPortal.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.UseCases.AdminPortal.ProcessedOrdersScreen
{
    public class ViewProcessedOrdersUseCase : IViewProcessedOrdersUseCase
    {
        private readonly IOrderRepository orderRepository;

        public ViewProcessedOrdersUseCase(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public IEnumerable<Order> Execute()
        {
            return orderRepository.GetProcessedOrders();
        }
    }
}
