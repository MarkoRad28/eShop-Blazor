﻿using eShop.CoreBusiness.Models;
using eShop.UseCases.CustomerPortal.PluginInterfaces.StateStore;
using eShop.UseCases.CustomerPortal.PluginInterfaces.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.CustomerPortal.ShoppingCartScreen
{
    public class DeleteProductUseCase : IDeleteProductUseCase
    {
        private readonly IShoppingCart shoppingCart;
        private readonly IShoppingCartStateStore shoppingCartStateStore;

        public DeleteProductUseCase(IShoppingCart shoppingCart, IShoppingCartStateStore shoppingCartStateStore)
        {
            this.shoppingCart = shoppingCart;
            this.shoppingCartStateStore = shoppingCartStateStore;
        }

        public async Task<Order> Execute(int productId)
        {
            var order = await this.shoppingCart.DeleteProductAsync(productId);
            this.shoppingCartStateStore.UpdateLineItemsCount();

            return order;
        }
    }
}
