﻿using eShop.CoreBusiness.Models;
using eShop.UseCases.CustomerPortal.PluginInterfaces.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.CustomerPortal.ShoppingCartScreen
{
    public class ViewShoppingCartUseCase : IViewShoppingCartUseCase
    {
        private readonly IShoppingCart shoppingCart;

        public ViewShoppingCartUseCase(IShoppingCart shoppingCart)
        {
            this.shoppingCart = shoppingCart;
        }
        public Task<Order> Execute()
        {
            return shoppingCart.GetOrderAsync();
        }
    }
}
