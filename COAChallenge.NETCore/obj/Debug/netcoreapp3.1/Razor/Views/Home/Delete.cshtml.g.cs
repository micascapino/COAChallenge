#pragma checksum "C:\Users\micas\source\repos\COAChallenge.NETCore\COAChallenge.NETCore\Views\Home\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a627534ff5e96c0996dc9ff7f6d060366f7bfa02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Delete), @"mvc.1.0.view", @"/Views/Home/Delete.cshtml")]
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
#line 1 "C:\Users\micas\source\repos\COAChallenge.NETCore\COAChallenge.NETCore\Views\_ViewImports.cshtml"
using COAChallenge.NETCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\micas\source\repos\COAChallenge.NETCore\COAChallenge.NETCore\Views\_ViewImports.cshtml"
using COAChallenge.NETCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a627534ff5e96c0996dc9ff7f6d060366f7bfa02", @"/Views/Home/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c6825bd2d606eb0df7205aa04fb0d1ec8f427a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<COAChallenge.NETCore.Models.Usuario>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\micas\source\repos\COAChallenge.NETCore\COAChallenge.NETCore\Views\Home\Delete.cshtml"
  
    ViewData["Eliminar"] = "Delete";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Eliminar</h2>\r\n\r\n<h3>Estas seguro que deseas eliminar a este usuario?</h3>\r\n<div>\r\n\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 16 "C:\Users\micas\source\repos\COAChallenge.NETCore\COAChallenge.NETCore\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 20 "C:\Users\micas\source\repos\COAChallenge.NETCore\COAChallenge.NETCore\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 24 "C:\Users\micas\source\repos\COAChallenge.NETCore\COAChallenge.NETCore\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 28 "C:\Users\micas\source\repos\COAChallenge.NETCore\COAChallenge.NETCore\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 32 "C:\Users\micas\source\repos\COAChallenge.NETCore\COAChallenge.NETCore\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 36 "C:\Users\micas\source\repos\COAChallenge.NETCore\COAChallenge.NETCore\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 40 "C:\Users\micas\source\repos\COAChallenge.NETCore\COAChallenge.NETCore\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 44 "C:\Users\micas\source\repos\COAChallenge.NETCore\COAChallenge.NETCore\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n");
#nullable restore
#line 49 "C:\Users\micas\source\repos\COAChallenge.NETCore\COAChallenge.NETCore\Views\Home\Delete.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\micas\source\repos\COAChallenge.NETCore\COAChallenge.NETCore\Views\Home\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Borrar.\" class=\"btn btn-danger\" /> |\r\n            ");
#nullable restore
#line 55 "C:\Users\micas\source\repos\COAChallenge.NETCore\COAChallenge.NETCore\Views\Home\Delete.cshtml"
       Write(Html.ActionLink("No, volver a la lista", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 57 "C:\Users\micas\source\repos\COAChallenge.NETCore\COAChallenge.NETCore\Views\Home\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<COAChallenge.NETCore.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
