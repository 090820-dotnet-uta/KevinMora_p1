#pragma checksum "C:\Users\kevinmora\Documents\REVATURE\Repositories\MoraKevin\P1\P1\Views\CustomerHome\CustomersWithName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3837430ca010d0bf1b8f41927ceae0ba284c8b53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerHome_CustomersWithName), @"mvc.1.0.view", @"/Views/CustomerHome/CustomersWithName.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3837430ca010d0bf1b8f41927ceae0ba284c8b53", @"/Views/CustomerHome/CustomersWithName.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf0a83b8b5988f3038230479476a297be027ee35", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerHome_CustomersWithName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<P1.Models.UserAccount>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kevinmora\Documents\REVATURE\Repositories\MoraKevin\P1\P1\Views\CustomerHome\CustomersWithName.cshtml"
  
    ViewData["Title"] = "CustomersWithName";
    Layout = "~/Views/Shared/_AccountLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Customers</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>
                First Name
            </th>
            <th>
                Last Name
            </th>
            <th>
                Username
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 25 "C:\Users\kevinmora\Documents\REVATURE\Repositories\MoraKevin\P1\P1\Views\CustomerHome\CustomersWithName.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\kevinmora\Documents\REVATURE\Repositories\MoraKevin\P1\P1\Views\CustomerHome\CustomersWithName.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customer.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\kevinmora\Documents\REVATURE\Repositories\MoraKevin\P1\P1\Views\CustomerHome\CustomersWithName.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customer.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\kevinmora\Documents\REVATURE\Repositories\MoraKevin\P1\P1\Views\CustomerHome\CustomersWithName.cshtml"
           Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\kevinmora\Documents\REVATURE\Repositories\MoraKevin\P1\P1\Views\CustomerHome\CustomersWithName.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<P1.Models.UserAccount>> Html { get; private set; }
    }
}
#pragma warning restore 1591
