#pragma checksum "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae50d15331d5ab3f5b03ca360c2565811d4816ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Eventos_Delete), @"mvc.1.0.view", @"/Views/Eventos/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Eventos/Delete.cshtml", typeof(AspNetCore.Views_Eventos_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae50d15331d5ab3f5b03ca360c2565811d4816ce", @"/Views/Eventos/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"744544acfb7a4b7ca4e5ad87938b47467150cdb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Eventos_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Eventos.IO.Application.ViewModels.EventoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(102, 176, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>EventoViewModel</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(279, 40, false);
#line 15 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(319, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(363, 36, false);
#line 18 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(399, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(443, 50, false);
#line 21 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DescricaoCurta));

#line default
#line hidden
            EndContext();
            BeginContext(493, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(537, 46, false);
#line 24 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DescricaoCurta));

#line default
#line hidden
            EndContext();
            BeginContext(583, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(627, 50, false);
#line 27 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DescricaoLonga));

#line default
#line hidden
            EndContext();
            BeginContext(677, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(721, 46, false);
#line 30 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DescricaoLonga));

#line default
#line hidden
            EndContext();
            BeginContext(767, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(811, 46, false);
#line 33 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DataInicio));

#line default
#line hidden
            EndContext();
            BeginContext(857, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(901, 42, false);
#line 36 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DataInicio));

#line default
#line hidden
            EndContext();
            BeginContext(943, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(987, 43, false);
#line 39 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DataFim));

#line default
#line hidden
            EndContext();
            BeginContext(1030, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1074, 39, false);
#line 42 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DataFim));

#line default
#line hidden
            EndContext();
            BeginContext(1113, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1157, 44, false);
#line 45 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Gratuito));

#line default
#line hidden
            EndContext();
            BeginContext(1201, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1245, 40, false);
#line 48 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Gratuito));

#line default
#line hidden
            EndContext();
            BeginContext(1285, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1329, 41, false);
#line 51 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1370, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1414, 37, false);
#line 54 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1451, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1495, 42, false);
#line 57 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Online));

#line default
#line hidden
            EndContext();
            BeginContext(1537, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1581, 38, false);
#line 60 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Online));

#line default
#line hidden
            EndContext();
            BeginContext(1619, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1663, 47, false);
#line 63 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NomeEmpresa));

#line default
#line hidden
            EndContext();
            BeginContext(1710, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1754, 43, false);
#line 66 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NomeEmpresa));

#line default
#line hidden
            EndContext();
            BeginContext(1797, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1841, 45, false);
#line 69 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Categoria));

#line default
#line hidden
            EndContext();
            BeginContext(1886, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1930, 44, false);
#line 72 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Categoria.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1974, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2018, 49, false);
#line 75 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OrganizadorId));

#line default
#line hidden
            EndContext();
            BeginContext(2067, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2111, 45, false);
#line 78 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OrganizadorId));

#line default
#line hidden
            EndContext();
            BeginContext(2156, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2194, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae50d15331d5ab3f5b03ca360c2565811d4816ce15785", async() => {
                BeginContext(2220, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2230, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ae50d15331d5ab3f5b03ca360c2565811d4816ce16178", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 83 "C:\Users\mazza\Documents\Estudos\AspNetCore\projetos\Eventos.IO\server\src\Eventos.IO.Site\Views\Eventos\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2266, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2350, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae50d15331d5ab3f5b03ca360c2565811d4816ce18124", async() => {
                    BeginContext(2372, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2388, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2401, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Eventos.IO.Application.ViewModels.EventoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
