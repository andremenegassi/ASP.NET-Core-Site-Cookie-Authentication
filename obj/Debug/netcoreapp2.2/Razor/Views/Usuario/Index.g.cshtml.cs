#pragma checksum "C:\Users\andre\Source\Repos\ASP.NET-Core-Site-Cookie-Authentication\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dda712617762548ef89eb8a737e4bb875c2f783"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Index.cshtml", typeof(AspNetCore.Views_Usuario_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dda712617762548ef89eb8a737e4bb875c2f783", @"/Views/Usuario/Index.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Views/Usuario/Index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\andre\Source\Repos\ASP.NET-Core-Site-Cookie-Authentication\Views\Usuario\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutCliente.cshtml";

#line default
#line hidden
            BeginContext(97, 420, true);
            WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
            <!--This is a comment. Comments are not displayed in the browser-->
            <form class=""offset-md-3 col-md-6 text-center mt-3"">
                <h1>Login</h1>
                <div class=""form-group"">
                    <label for=""iEmail"">E-mail</label>
                    <input type=""email"" name=""email"" class=""form-control"" id=""iEmail""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 517, "\"", 539, 1);
#line 14 "C:\Users\andre\Source\Repos\ASP.NET-Core-Site-Cookie-Authentication\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 525, ViewBag.Email, 525, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(540, 390, true);
            WriteLiteral(@" placeholder=""Digite seu e-mail"">
                </div>
                <div class=""form-group"">
                    <label for=""iSenha"">Senha</label>
                    <input type=""password"" name=""senha"" class=""form-control"" id=""iSenha"" placeholder=""Password"">
                </div>
                <button type=""button"" id=""btnEntrar"" class=""btn btn-primary"">Entrar</button>

");
            EndContext();
#line 22 "C:\Users\andre\Source\Repos\ASP.NET-Core-Site-Cookie-Authentication\Views\Usuario\Index.cshtml"
                 if(ViewBag.Msg != null)
                {

#line default
#line hidden
            BeginContext(991, 151, true);
            WriteLiteral("                    <div class=\"alert alert-warning alert-dismissible fade show mt-2\" role=\"alert\">\r\n                        <strong>Atenção!</strong> ");
            EndContext();
            BeginContext(1143, 11, false);
#line 25 "C:\Users\andre\Source\Repos\ASP.NET-Core-Site-Cookie-Authentication\Views\Usuario\Index.cshtml"
                                             Write(ViewBag.Msg);

#line default
#line hidden
            EndContext();
            BeginContext(1154, 236, true);
            WriteLiteral("\r\n                        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                            <span aria-hidden=\"true\">&times;</span>\r\n                        </button>\r\n                    </div>\r\n");
            EndContext();
#line 30 "C:\Users\andre\Source\Repos\ASP.NET-Core-Site-Cookie-Authentication\Views\Usuario\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1409, 118, true);
            WriteLiteral("\r\n                <div id=\"divMsg\">\r\n\r\n                </div>\r\n\r\n            </form>\r\n        </div>\r\n\r\n    </div>\r\n\r\n");
            EndContext();
            DefineSection("script", async() => {
                BeginContext(1544, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1550, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dda712617762548ef89eb8a737e4bb875c2f7836398", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1601, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(1606, 2, true);
            WriteLiteral("\r\n");
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
