﻿using eShop.UseCases.CustomerPortal.PluginInterfaces.DataStore;
using eShop.UseCases.CustomerPortal.PluginInterfaces.StateStore;
using eShop.UseCases.CustomerPortal.PluginInterfaces.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.UseCases.CustomerPortal.ViewProductScreen
{
    public class AddProductToCartUseCase : IAddProductToCartUseCase
    {
        private readonly IProductRepository productRepository;
        private readonly IShoppingCart shoppingCart;
        private readonly IShoppingCartStateStore shoppingCartStateStore;

        public AddProductToCartUseCase(IProductRepository productRepository, IShoppingCart shoppingCart, IShoppingCartStateStore shoppingCartStateStore)
        {
            this.productRepository = productRepository;
            this.shoppingCart = shoppingCart;
            this.shoppingCartStateStore = shoppingCartStateStore;
        }

        public async void Execute(int productId)
        {
            var product = this.productRepository.GetProduct(productId);
            await shoppingCart.AddProductAsync(product);

            this.shoppingCartStateStore.UpdateLineItemsCount();
        }
    }
}
