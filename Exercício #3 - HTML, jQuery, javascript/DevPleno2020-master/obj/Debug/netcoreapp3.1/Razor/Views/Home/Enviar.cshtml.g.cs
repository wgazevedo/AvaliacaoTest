#pragma checksum "C:\Users\UserLocal\Desktop\SysPlan\Exercício #3 - HTML, jQuery, javascript\DevPleno2020-master\Views\Home\Enviar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0855bbcbfe579437b73fc8c0636417abeb46d70d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Enviar), @"mvc.1.0.view", @"/Views/Home/Enviar.cshtml")]
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
#line 1 "C:\Users\UserLocal\Desktop\SysPlan\Exercício #3 - HTML, jQuery, javascript\DevPleno2020-master\Views\_ViewImports.cshtml"
using Exercicio3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\UserLocal\Desktop\SysPlan\Exercício #3 - HTML, jQuery, javascript\DevPleno2020-master\Views\_ViewImports.cshtml"
using Exercicio3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0855bbcbfe579437b73fc8c0636417abeb46d70d", @"/Views/Home/Enviar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5578ca6b35263f2d10925cb3808607b8e98f02e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Enviar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\UserLocal\Desktop\SysPlan\Exercício #3 - HTML, jQuery, javascript\DevPleno2020-master\Views\Home\Enviar.cshtml"
  
    ViewData["Title"] = "Obrigado!";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">");
#nullable restore
#line 6 "C:\Users\UserLocal\Desktop\SysPlan\Exercício #3 - HTML, jQuery, javascript\DevPleno2020-master\Views\Home\Enviar.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    <br />\n    \n");
#nullable restore
#line 9 "C:\Users\UserLocal\Desktop\SysPlan\Exercício #3 - HTML, jQuery, javascript\DevPleno2020-master\Views\Home\Enviar.cshtml"
        for (int i = 0; i < ViewBag.Filmes.Count; i++)
        {
            var filme = ViewBag.Filmes[i];


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\"");
            BeginWriteAttribute("id", " id=\"", 268, "\"", 281, 2);
            WriteAttributeValue("", 273, "filme_", 273, 6, true);
#nullable restore
#line 13 "C:\Users\UserLocal\Desktop\SysPlan\Exercício #3 - HTML, jQuery, javascript\DevPleno2020-master\Views\Home\Enviar.cshtml"
WriteAttributeValue("", 279, i, 279, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-bottom: 10px;\">\n            <div class=\"col-md-12\">\n                <p>");
#nullable restore
#line 15 "C:\Users\UserLocal\Desktop\SysPlan\Exercício #3 - HTML, jQuery, javascript\DevPleno2020-master\Views\Home\Enviar.cshtml"
               Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 15 "C:\Users\UserLocal\Desktop\SysPlan\Exercício #3 - HTML, jQuery, javascript\DevPleno2020-master\Views\Home\Enviar.cshtml"
                       Write(filme);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n        </div>\n");
#nullable restore
#line 18 "C:\Users\UserLocal\Desktop\SysPlan\Exercício #3 - HTML, jQuery, javascript\DevPleno2020-master\Views\Home\Enviar.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
