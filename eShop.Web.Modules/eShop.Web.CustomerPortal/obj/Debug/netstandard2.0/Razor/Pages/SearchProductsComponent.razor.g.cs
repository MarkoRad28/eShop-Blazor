#pragma checksum "C:\Users\mradojevic\source\repos\Blazor\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\SearchProductsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c83c30e76a36358d0fae737f95f22cfdd068b72"
// <auto-generated/>
#pragma warning disable 1591
namespace eShop.Web.CustomerPortal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\mradojevic\source\repos\Blazor\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "C:\Users\mradojevic\source\repos\Blazor\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\mradojevic\source\repos\Blazor\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.CoreBusiness.Models;

#line default
#line hidden
#line 5 "C:\Users\mradojevic\source\repos\Blazor\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.UseCases.SearchProductScreen;

#line default
#line hidden
#line 6 "C:\Users\mradojevic\source\repos\Blazor\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.UseCases.ViewProductScreen;

#line default
#line hidden
#line 8 "C:\Users\mradojevic\source\repos\Blazor\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.Web.Common.Controls;

#line default
#line hidden
#line 9 "C:\Users\mradojevic\source\repos\Blazor\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.Web.CustomerPortal.Controls;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class SearchProductsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Search Products</h3>\n<br>\n\n");
            __builder.OpenComponent<eShop.Web.Common.Controls.SearchBarComponent>(1);
            __builder.AddAttribute(2, "OnSearch", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#line 8 "C:\Users\mradojevic\source\repos\Blazor\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\SearchProductsComponent.razor"
                              HandleSearch

#line default
#line hidden
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n\n<br>\n");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\n    ");
            __builder.AddMarkupContent(7, "<thead>\n        <tr>\n            <th>\n                Name\n            </th>\n            <th>\n                Brand\n            </th>\n            <th>\n                Price\n            </th>\n        </tr>\n    </thead>\n    ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\n");
#line 26 "C:\Users\mradojevic\source\repos\Blazor\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\SearchProductsComponent.razor"
         if (products != null && products.Count() > 0)
        {
            

#line default
#line hidden
#line 28 "C:\Users\mradojevic\source\repos\Blazor\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\SearchProductsComponent.razor"
             foreach (var product in products)
            {

#line default
#line hidden
            __builder.AddContent(10, "                ");
            __builder.OpenComponent<eShop.Web.CustomerPortal.Controls.ProductItemComponent>(11);
            __builder.AddAttribute(12, "Product", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<eShop.CoreBusiness.Models.Product>(
#line 30 "C:\Users\mradojevic\source\repos\Blazor\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\SearchProductsComponent.razor"
                                               product

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\n");
#line 31 "C:\Users\mradojevic\source\repos\Blazor\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\SearchProductsComponent.razor"
            }

#line default
#line hidden
#line 31 "C:\Users\mradojevic\source\repos\Blazor\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\SearchProductsComponent.razor"
             
        }
        else
        {

#line default
#line hidden
            __builder.AddContent(14, "            ");
            __builder.AddMarkupContent(15, "<tr>\n                <td colspan=\"3\">\n                    Cannot find products\n                </td>\n            </tr>\n");
#line 40 "C:\Users\mradojevic\source\repos\Blazor\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\SearchProductsComponent.razor"
        }

#line default
#line hidden
            __builder.AddContent(16, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 44 "C:\Users\mradojevic\source\repos\Blazor\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\SearchProductsComponent.razor"
       

    private IEnumerable<Product> products;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        products = searchProductUseCase.Execute();
    }

    private void HandleSearch(string filter)
    {
        products = searchProductUseCase.Execute(filter);
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISearchProductUseCase searchProductUseCase { get; set; }
    }
}
#pragma warning restore 1591
