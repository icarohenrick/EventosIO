#pragma checksum "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "051d7b91b0ae4881627708908521644087788f73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Eventos_Index), @"mvc.1.0.view", @"/Views/Eventos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Eventos/Index.cshtml", typeof(AspNetCore.Views_Eventos_Index))]
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
#line 1 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\_ViewImports.cshtml"
using Eventos.IO.Site;

#line default
#line hidden
#line 3 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\_ViewImports.cshtml"
using Eventos.IO.Infra.CrossCutting.Identity.Models;

#line default
#line hidden
#line 4 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\_ViewImports.cshtml"
using Eventos.IO.Infra.CrossCutting.Identity.Models.ManageViewModels;

#line default
#line hidden
#line 5 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\_ViewImports.cshtml"
using Eventos.IO.Infra.CrossCutting.Identity.Models.AccountViewModels;

#line default
#line hidden
#line 6 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\_ViewImports.cshtml"
using Eventos.IO.Infra.CrossCutting.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"051d7b91b0ae4881627708908521644087788f73", @"/Views/Eventos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"744544acfb7a4b7ca4e5ad87938b47467150cdb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Eventos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Eventos.IO.Application.ViewModels.EventoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
  
    ViewData["Title"] = "Lista dos Próximos Eventos";

#line default
#line hidden
            BeginContext(136, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(143, 17, false);
#line 7 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(160, 101, true);
            WriteLiteral("</h2>\r\n<br />\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(262, 40, false);
#line 14 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(302, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(358, 46, false);
#line 17 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataInicio));

#line default
#line hidden
            EndContext();
            BeginContext(404, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(460, 43, false);
#line 20 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataFim));

#line default
#line hidden
            EndContext();
            BeginContext(503, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(559, 41, false);
#line 23 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(600, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(656, 42, false);
#line 26 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Online));

#line default
#line hidden
            EndContext();
            BeginContext(698, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(816, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(865, 39, false);
#line 35 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(904, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(960, 29, false);
#line 38 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
           Write(item.DataInicio.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(989, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1045, 26, false);
#line 41 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
           Write(item.DataFim.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 44 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
                  
                    if (item.Gratuito)
                    {
                        

#line default
#line hidden
            BeginContext(1218, 28, false);
#line 47 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
                   Write(Html.DisplayName("Gratuíto"));

#line default
#line hidden
            EndContext();
#line 47 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
                                                     
                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(1345, 40, false);
#line 51 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
#line 51 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
                                                                 
                    }
                

#line default
#line hidden
            BeginContext(1429, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1483, 41, false);
#line 56 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Online));

#line default
#line hidden
            EndContext();
            BeginContext(1524, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1579, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "051d7b91b0ae4881627708908521644087788f7311844", async() => {
                BeginContext(1651, 101, true);
                WriteLiteral("\r\n                    <span class=\"glyphicon glyphicon-search\"></span> Ver Detalhes\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1756, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 64 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1795, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Eventos.IO.Application.ViewModels.EventoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
