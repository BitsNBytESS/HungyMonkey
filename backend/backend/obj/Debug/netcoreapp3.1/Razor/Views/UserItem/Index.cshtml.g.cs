#pragma checksum "C:\Users\Emrit\Documents\GitProjects\HungyMonkey\backend\backend\Views\UserItem\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4b3298ff66a51e06e3eae470fecfb6511c50cc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserItem_Index), @"mvc.1.0.view", @"/Views/UserItem/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4b3298ff66a51e06e3eae470fecfb6511c50cc0", @"/Views/UserItem/Index.cshtml")]
    public class Views_UserItem_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<backend.Models.UserItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Emrit\Documents\GitProjects\HungyMonkey\backend\backend\Views\UserItem\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n<li class=\"nav-item\">\r\n  <a class=\"nav-link text-dark\"");
            BeginWriteAttribute("asp-area", " asp-area=\"", 160, "\"", 171, 0);
            EndWriteAttribute();
            WriteLiteral(" asp-controller=\"FavoriteBands\" asp-action=\"Index\">Favorite Bands</a>\r\n</li>\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\Emrit\Documents\GitProjects\HungyMonkey\backend\backend\Views\UserItem\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 24 "C:\Users\Emrit\Documents\GitProjects\HungyMonkey\backend\backend\Views\UserItem\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "C:\Users\Emrit\Documents\GitProjects\HungyMonkey\backend\backend\Views\UserItem\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 710, "\"", 733, 1);
#nullable restore
#line 30 "C:\Users\Emrit\Documents\GitProjects\HungyMonkey\backend\backend\Views\UserItem\Index.cshtml"
WriteAttributeValue("", 725, item.Id, 725, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 786, "\"", 809, 1);
#nullable restore
#line 31 "C:\Users\Emrit\Documents\GitProjects\HungyMonkey\backend\backend\Views\UserItem\Index.cshtml"
WriteAttributeValue("", 801, item.Id, 801, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 864, "\"", 887, 1);
#nullable restore
#line 32 "C:\Users\Emrit\Documents\GitProjects\HungyMonkey\backend\backend\Views\UserItem\Index.cshtml"
WriteAttributeValue("", 879, item.Id, 879, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Emrit\Documents\GitProjects\HungyMonkey\backend\backend\Views\UserItem\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<backend.Models.UserItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591