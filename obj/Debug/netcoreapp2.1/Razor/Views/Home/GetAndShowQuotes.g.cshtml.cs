#pragma checksum "/Users/greg/codingdojo/cSharp/QuotingDojo/Views/Home/GetAndShowQuotes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fed5d3bb9b3c233693e09d774b8e39c608cead9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetAndShowQuotes), @"mvc.1.0.view", @"/Views/Home/GetAndShowQuotes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GetAndShowQuotes.cshtml", typeof(AspNetCore.Views_Home_GetAndShowQuotes))]
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
#line 1 "/Users/greg/codingdojo/cSharp/QuotingDojo/Views/_ViewImports.cshtml"
using QuotingDojo;

#line default
#line hidden
#line 1 "/Users/greg/codingdojo/cSharp/QuotingDojo/Views/Home/GetAndShowQuotes.cshtml"
using QuotingDojo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fed5d3bb9b3c233693e09d774b8e39c608cead9", @"/Views/Home/GetAndShowQuotes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1590bf4c09dff90063a94a6cfc81488d471e1d42", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetAndShowQuotes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dictionary<string, object>>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(99, 408, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "011061517b2e42ab8fae2ad08bb80f0c", async() => {
                BeginContext(105, 395, true);
                WriteLiteral(@"
  <meta charset=""UTF-8"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
  <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
  <link href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
  <title>Document</title>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(507, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(508, 331, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83383ec571174c4296d5575c5e23e0f4", async() => {
                BeginContext(514, 68, true);
                WriteLiteral("\n  <header>  \n    <h1>Here are the awesome quotes!</h1>\n  </header>\n");
                EndContext();
#line 16 "/Users/greg/codingdojo/cSharp/QuotingDojo/Views/Home/GetAndShowQuotes.cshtml"
    
    foreach (var q in @Model)
    {

#line default
#line hidden
                BeginContext(623, 58, true);
                WriteLiteral("      <div style=\"outline: 1px solid black;\">\n        <h3>");
                EndContext();
                BeginContext(682, 11, false);
#line 20 "/Users/greg/codingdojo/cSharp/QuotingDojo/Views/Home/GetAndShowQuotes.cshtml"
       Write(q["author"]);

#line default
#line hidden
                EndContext();
                BeginContext(693, 23, true);
                WriteLiteral(" said</h3>\n        <h5>");
                EndContext();
                BeginContext(717, 10, false);
#line 21 "/Users/greg/codingdojo/cSharp/QuotingDojo/Views/Home/GetAndShowQuotes.cshtml"
       Write(q["quote"]);

#line default
#line hidden
                EndContext();
                BeginContext(727, 16, true);
                WriteLiteral("</h5>\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=", 743, "", 771, 1);
#line 22 "/Users/greg/codingdojo/cSharp/QuotingDojo/Views/Home/GetAndShowQuotes.cshtml"
WriteAttributeValue("", 749, $"delete/{q["id"]}", 749, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(771, 48, true);
                WriteLiteral(" class=\"btn btn-danger\">Delete</a>\n      </div>\n");
                EndContext();
#line 24 "/Users/greg/codingdojo/cSharp/QuotingDojo/Views/Home/GetAndShowQuotes.cshtml"
    }
  

#line default
#line hidden
                BeginContext(829, 3, true);
                WriteLiteral("  \n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(839, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dictionary<string, object>>> Html { get; private set; }
    }
}
#pragma warning restore 1591