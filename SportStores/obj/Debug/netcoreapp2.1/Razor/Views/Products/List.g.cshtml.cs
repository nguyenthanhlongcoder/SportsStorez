#pragma checksum "D:\SportStores\SportStores\SportStores\Views\Products\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cbcc6546bd628b13e4265e100beca6df1f3c421"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_List), @"mvc.1.0.view", @"/Views/Products/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/List.cshtml", typeof(AspNetCore.Views_Products_List))]
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
#line 1 "D:\SportStores\SportStores\SportStores\Views\_ViewImports.cshtml"
using SportStores.Models;

#line default
#line hidden
#line 3 "D:\SportStores\SportStores\SportStores\Views\_ViewImports.cshtml"
using SportStores.Models.ViewModels;

#line default
#line hidden
#line 5 "D:\SportStores\SportStores\SportStores\Views\_ViewImports.cshtml"
using SportStores.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cbcc6546bd628b13e4265e100beca6df1f3c421", @"/Views/Products/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"312acae3cc868f7d7c57dbf9726db404ae04cf39", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn-secondary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn-primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", new global::Microsoft.AspNetCore.Html.HtmlString("btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group pull-right m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::SportStores.Infrastructure.PageLinkTagHelper __SportStores_Infrastructure_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\SportStores\SportStores\SportStores\Views\Products\List.cshtml"
 foreach (var p in Model.Products)
{
    

#line default
#line hidden
            BeginContext(76, 33, false);
#line 5 "D:\SportStores\SportStores\SportStores\Views\Products\List.cshtml"
Write(Html.Partial("ProductSummary", p));

#line default
#line hidden
            EndContext();
#line 5 "D:\SportStores\SportStores\SportStores\Views\Products\List.cshtml"
                                      

}

#line default
#line hidden
            BeginContext(116, 304, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a2caee0b6d546a08a0c8c2d59518178", async() => {
                BeginContext(412, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __SportStores_Infrastructure_PageLinkTagHelper = CreateTagHelper<global::SportStores.Infrastructure.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__SportStores_Infrastructure_PageLinkTagHelper);
#line 8 "D:\SportStores\SportStores\SportStores\Views\Products\List.cshtml"
__SportStores_Infrastructure_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __SportStores_Infrastructure_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __SportStores_Infrastructure_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 8 "D:\SportStores\SportStores\SportStores\Views\Products\List.cshtml"
__SportStores_Infrastructure_PageLinkTagHelper.PageClassesEnabled = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __SportStores_Infrastructure_PageLinkTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __SportStores_Infrastructure_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __SportStores_Infrastructure_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __SportStores_Infrastructure_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__SportStores_Infrastructure_PageLinkTagHelper.PageUrlValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("page-url-category", "SportStores.Infrastructure.PageLinkTagHelper", "PageUrlValues"));
            }
#line 10 "D:\SportStores\SportStores\SportStores\Views\Products\List.cshtml"
__SportStores_Infrastructure_PageLinkTagHelper.PageUrlValues["category"] = Model.CurrentCategory;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-category", __SportStores_Infrastructure_PageLinkTagHelper.PageUrlValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
