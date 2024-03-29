﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.CustomerPortal.PluginInterfaces.StateStore
{
    public interface IShoppingCartStateStore : IStateStore
    {
        Task<int> GetItemsCount();
        void UpdateLineItemsCount();
        void UpdateProductsQuantity();
    }
}
