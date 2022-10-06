#pragma checksum "C:\Users\dougl\OneDrive\Área de Trabalho\projeto-sistema-cadastro\Views\Home\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05991cab929c1db1d7716640e320c569f821b28e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Listar), @"mvc.1.0.view", @"/Views/Home/Listar.cshtml")]
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
#line 1 "C:\Users\dougl\OneDrive\Área de Trabalho\projeto-sistema-cadastro\Views\_ViewImports.cshtml"
using projeto_sistema_cadastro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dougl\OneDrive\Área de Trabalho\projeto-sistema-cadastro\Views\_ViewImports.cshtml"
using projeto_sistema_cadastro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05991cab929c1db1d7716640e320c569f821b28e", @"/Views/Home/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd46d267be3850a4d39828b30fd4343a737ad86b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ItemPedido>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dougl\OneDrive\Área de Trabalho\projeto-sistema-cadastro\Views\Home\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5>Itens Registrados no pedido:</h5>\r\n<br>\r\n<table class=\"table\">\r\n<thead>\r\n    <tr>\r\n        <th>Descrição</th>\r\n        <th>Valor unitário</th>\r\n        <th>Quantidade</th>\r\n    </tr>\r\n</thead>\r\n\r\n<tbody>\r\n");
#nullable restore
#line 19 "C:\Users\dougl\OneDrive\Área de Trabalho\projeto-sistema-cadastro\Views\Home\Listar.cshtml"
     foreach (ItemPedido p in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\dougl\OneDrive\Área de Trabalho\projeto-sistema-cadastro\Views\Home\Listar.cshtml"
           Write(p.descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>R$ ");
#nullable restore
#line 22 "C:\Users\dougl\OneDrive\Área de Trabalho\projeto-sistema-cadastro\Views\Home\Listar.cshtml"
              Write(p.valor_unitario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\dougl\OneDrive\Área de Trabalho\projeto-sistema-cadastro\Views\Home\Listar.cshtml"
           Write(p.quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "C:\Users\dougl\OneDrive\Área de Trabalho\projeto-sistema-cadastro\Views\Home\Listar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<p><strong>O valor total do pedido é: R$ ");
#nullable restore
#line 28 "C:\Users\dougl\OneDrive\Área de Trabalho\projeto-sistema-cadastro\Views\Home\Listar.cshtml"
                                    Write(Dados.PedidoAtual.Totalizar());

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n</tbody>\r\n<br>\r\n<p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05991cab929c1db1d7716640e320c569f821b28e5618", async() => {
                WriteLiteral("Registrar um novo item");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ItemPedido>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591