#pragma checksum "C:\Users\andre\Source\Repos\ASP.NET-Core-Site-Cookie-Authentication\Views\Usuario\ObterTodos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1ae80d653ee76dfbd2fcf3287abf5a5a58808ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ObterTodos), @"mvc.1.0.view", @"/Views/Usuario/ObterTodos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/ObterTodos.cshtml", typeof(AspNetCore.Views_Usuario_ObterTodos))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1ae80d653ee76dfbd2fcf3287abf5a5a58808ba", @"/Views/Usuario/ObterTodos.cshtml")]
    public class Views_Usuario_ObterTodos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\andre\Source\Repos\ASP.NET-Core-Site-Cookie-Authentication\Views\Usuario\ObterTodos.cshtml"
  
    ViewData["Title"] = "Listar usuários";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(100, 37, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <ul>\r\n");
            EndContext();
#line 9 "C:\Users\andre\Source\Repos\ASP.NET-Core-Site-Cookie-Authentication\Views\Usuario\ObterTodos.cshtml"
          

            var lista =
                (List<HelloWorld.Models.Usuario>)ViewBag.Usuarios;


            foreach (var usuario in lista)
            {

#line default
#line hidden
            BeginContext(307, 77, true);
            WriteLiteral("                <li>\r\n                    <div>\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 384, "\"", 420, 2);
            WriteAttributeValue("", 390, "/usuario/obterfoto/", 390, 19, true);
#line 19 "C:\Users\andre\Source\Repos\ASP.NET-Core-Site-Cookie-Authentication\Views\Usuario\ObterTodos.cshtml"
WriteAttributeValue("", 409, usuario.Id, 409, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(421, 119, true);
            WriteLiteral(" />\r\n                    </div>\r\n                    <div>\r\n                        <div>\r\n                            ");
            EndContext();
            BeginContext(541, 12, false);
#line 23 "C:\Users\andre\Source\Repos\ASP.NET-Core-Site-Cookie-Authentication\Views\Usuario\ObterTodos.cshtml"
                       Write(usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(553, 93, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div>\r\n                            ");
            EndContext();
            BeginContext(647, 13, false);
#line 26 "C:\Users\andre\Source\Repos\ASP.NET-Core-Site-Cookie-Authentication\Views\Usuario\ObterTodos.cshtml"
                       Write(usuario.Email);

#line default
#line hidden
            EndContext();
            BeginContext(660, 85, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </li>\r\n");
            EndContext();
#line 30 "C:\Users\andre\Source\Repos\ASP.NET-Core-Site-Cookie-Authentication\Views\Usuario\ObterTodos.cshtml"
                
            }

        

#line default
#line hidden
            BeginContext(791, 27, true);
            WriteLiteral("    </ul>\r\n    \r\n\r\n</div>\r\n");
            EndContext();
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
