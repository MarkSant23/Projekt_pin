#pragma checksum "C:\Users\Korisnik\source\repos\MarkSant23\Projekt_pin\Views\Tablica_igracas\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c57ed088a7f9f587c45abc9fe4465e7433555859"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tablica_igracas_Delete), @"mvc.1.0.view", @"/Views/Tablica_igracas/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tablica_igracas/Delete.cshtml", typeof(AspNetCore.Views_Tablica_igracas_Delete))]
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
#line 1 "C:\Users\Korisnik\source\repos\MarkSant23\Projekt_pin\Views\_ViewImports.cshtml"
using pin_projekt;

#line default
#line hidden
#line 2 "C:\Users\Korisnik\source\repos\MarkSant23\Projekt_pin\Views\_ViewImports.cshtml"
using pin_projekt.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c57ed088a7f9f587c45abc9fe4465e7433555859", @"/Views/Tablica_igracas/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18c614bfcf54a98895f0ccca4c9fb0bee4689231", @"/Views/_ViewImports.cshtml")]
    public class Views_Tablica_igracas_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<pin_projekt.Models.Tablica_igraca>
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Korisnik\source\repos\MarkSant23\Projekt_pin\Views\Tablica_igracas\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(86, 59, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Da li ste sigurni obrisati igrača ");
            EndContext();
            BeginContext(146, 35, false);
#line 9 "C:\Users\Korisnik\source\repos\MarkSant23\Projekt_pin\Views\Tablica_igracas\Delete.cshtml"
                                 Write(Html.DisplayFor(model => model.ime));

#line default
#line hidden
            EndContext();
            BeginContext(181, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(183, 43, false);
#line 9 "C:\Users\Korisnik\source\repos\MarkSant23\Projekt_pin\Views\Tablica_igracas\Delete.cshtml"
                                                                      Write(Html.DisplayNameFor(model => model.prezime));

#line default
#line hidden
            EndContext();
            BeginContext(226, 114, true);
            WriteLiteral("?</h3>\r\n<div>\r\n    <h4>Tablica_igraca</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(341, 39, false);
#line 15 "C:\Users\Korisnik\source\repos\MarkSant23\Projekt_pin\Views\Tablica_igracas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ime));

#line default
#line hidden
            EndContext();
            BeginContext(380, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(424, 35, false);
#line 18 "C:\Users\Korisnik\source\repos\MarkSant23\Projekt_pin\Views\Tablica_igracas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ime));

#line default
#line hidden
            EndContext();
            BeginContext(459, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(503, 43, false);
#line 21 "C:\Users\Korisnik\source\repos\MarkSant23\Projekt_pin\Views\Tablica_igracas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.prezime));

#line default
#line hidden
            EndContext();
            BeginContext(546, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(590, 39, false);
#line 24 "C:\Users\Korisnik\source\repos\MarkSant23\Projekt_pin\Views\Tablica_igracas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.prezime));

#line default
#line hidden
            EndContext();
            BeginContext(629, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(673, 44, false);
#line 27 "C:\Users\Korisnik\source\repos\MarkSant23\Projekt_pin\Views\Tablica_igracas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.pozicija));

#line default
#line hidden
            EndContext();
            BeginContext(717, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(761, 40, false);
#line 30 "C:\Users\Korisnik\source\repos\MarkSant23\Projekt_pin\Views\Tablica_igracas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.pozicija));

#line default
#line hidden
            EndContext();
            BeginContext(801, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(845, 40, false);
#line 33 "C:\Users\Korisnik\source\repos\MarkSant23\Projekt_pin\Views\Tablica_igracas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.klub));

#line default
#line hidden
            EndContext();
            BeginContext(885, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(929, 36, false);
#line 36 "C:\Users\Korisnik\source\repos\MarkSant23\Projekt_pin\Views\Tablica_igracas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.klub));

#line default
#line hidden
            EndContext();
            BeginContext(965, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1003, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d88fe7670ad412b93b4f8a1258094ac", async() => {
                BeginContext(1029, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1039, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "98bc3649241649f9840aeba4ca7d72fa", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 41 "C:\Users\Korisnik\source\repos\MarkSant23\Projekt_pin\Views\Tablica_igracas\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

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
                BeginContext(1075, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1159, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a27d7809dba48d8a414f2cec5c32dac", async() => {
                    BeginContext(1181, 17, true);
                    WriteLiteral("Povratak na listu");
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
                BeginContext(1202, 6, true);
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
            BeginContext(1215, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<pin_projekt.Models.Tablica_igraca> Html { get; private set; }
    }
}
#pragma warning restore 1591