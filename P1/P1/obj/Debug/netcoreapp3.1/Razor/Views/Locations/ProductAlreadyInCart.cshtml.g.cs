#pragma checksum "C:\Users\kevinmora\Documents\REVATURE\Repositories\MoraKevin\P1\P1\Views\Locations\ProductAlreadyInCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ca48907a5e00f636026f86a1f7c1c1b2b5f08fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Locations_ProductAlreadyInCart), @"mvc.1.0.view", @"/Views/Locations/ProductAlreadyInCart.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\kevinmora\Documents\REVATURE\Repositories\MoraKevin\P1\P1\Views\_ViewImports.cshtml"
using P1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kevinmora\Documents\REVATURE\Repositories\MoraKevin\P1\P1\Views\_ViewImports.cshtml"
using P1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca48907a5e00f636026f86a1f7c1c1b2b5f08fc", @"/Views/Locations/ProductAlreadyInCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf0a83b8b5988f3038230479476a297be027ee35", @"/Views/_ViewImports.cshtml")]
    public class Views_Locations_ProductAlreadyInCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<P1.Models.ProductInStock>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kevinmora\Documents\REVATURE\Repositories\MoraKevin\P1\P1\Views\Locations\ProductAlreadyInCart.cshtml"
  
    ViewData["Title"] = "ProductAlreadyInCart";
    Layout = "~/Views/Shared/_StoreHomeLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h4>");
#nullable restore
#line 9 "C:\Users\kevinmora\Documents\REVATURE\Repositories\MoraKevin\P1\P1\Views\Locations\ProductAlreadyInCart.cshtml"
   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" is already in your Shopping Cart!</h4>\r\n    <hr />\r\n    <p> Head to your shopping cart if you wish to change the number of items.</p>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<P1.Models.ProductInStock> Html { get; private set; }
    }
}
#pragma warning restore 1591
