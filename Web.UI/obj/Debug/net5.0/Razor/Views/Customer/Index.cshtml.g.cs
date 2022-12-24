#pragma checksum "C:\Users\Lenovo\source\repos\Product_Demo\Web.UI\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eadcdd15d3ed0e1414055bc0bac4268c6c988d69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\Product_Demo\Web.UI\Views\_ViewImports.cshtml"
using Web.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\Product_Demo\Web.UI\Views\_ViewImports.cshtml"
using Web.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Lenovo\source\repos\Product_Demo\Web.UI\Views\Customer\Index.cshtml"
using Entitiy.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eadcdd15d3ed0e1414055bc0bac4268c6c988d69", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df0e2cf8e78cd83a6bfb064a4477c91f71396fa5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Customer>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\Product_Demo\Web.UI\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Müşteri Listesi</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Müşteri Id</th>\r\n        <th>Müşteri Adı</th>\r\n        <th>Müşteri Şehri</th>\r\n        <th>Müşteri Meslek</th>\r\n        <th>İşlemler</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\Lenovo\source\repos\Product_Demo\Web.UI\Views\Customer\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n         <td>");
#nullable restore
#line 19 "C:\Users\Lenovo\source\repos\Product_Demo\Web.UI\Views\Customer\Index.cshtml"
        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 20 "C:\Users\Lenovo\source\repos\Product_Demo\Web.UI\Views\Customer\Index.cshtml"
        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 21 "C:\Users\Lenovo\source\repos\Product_Demo\Web.UI\Views\Customer\Index.cshtml"
        Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 22 "C:\Users\Lenovo\source\repos\Product_Demo\Web.UI\Views\Customer\Index.cshtml"
        Write(item.Job.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td><a");
            BeginWriteAttribute("href", " href=\"", 558, "\"", 598, 2);
            WriteAttributeValue("", 565, "/Customer/DeleteCustomer/", 565, 25, true);
#nullable restore
#line 23 "C:\Users\Lenovo\source\repos\Product_Demo\Web.UI\Views\Customer\Index.cshtml"
WriteAttributeValue("", 590, item.Id, 590, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a> - \r\n             <a");
            BeginWriteAttribute("href", " href=\"", 658, "\"", 698, 2);
            WriteAttributeValue("", 665, "/Customer/UpdateCustomer/", 665, 25, true);
#nullable restore
#line 24 "C:\Users\Lenovo\source\repos\Product_Demo\Web.UI\Views\Customer\Index.cshtml"
WriteAttributeValue("", 690, item.Id, 690, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n     </tr>\r\n");
#nullable restore
#line 26 "C:\Users\Lenovo\source\repos\Product_Demo\Web.UI\Views\Customer\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Customer/AddCustomer/\" class=\"btn btn-outline-primary\">Yeni Müşteri Kaydet</a>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Customer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
