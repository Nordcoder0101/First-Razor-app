#pragma checksum "/Users/greg/codingdojo/cSharp/razor-fun/razor-fun/Views/Index/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4188e43241e5dddfddb98dfe57c4ecfcc04b4c10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Index_index), @"mvc.1.0.view", @"/Views/Index/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Index/index.cshtml", typeof(AspNetCore.Views_Index_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4188e43241e5dddfddb98dfe57c4ecfcc04b4c10", @"/Views/Index/index.cshtml")]
    public class Views_Index_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n    ");
            EndContext();
            BeginContext(27, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f0e7e288c3941138f06e1c64a17bbf6", async() => {
                BeginContext(33, 131, true);
                WriteLiteral("\n        <meta charset=\'utf-8\'>\n        <title>Hello!</title>\n        <!-- <link rel=\"stylesheet\" href=\"~/css/style.css\"/> -->\n    ");
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
            BeginContext(171, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(176, 513, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a916a9f92a7942f394e0d64296025b4d", async() => {
                BeginContext(182, 23, true);
                WriteLiteral("\n      <h1>Hello!</h1>\n");
                EndContext();
#line 10 "/Users/greg/codingdojo/cSharp/razor-fun/razor-fun/Views/Index/index.cshtml"
        
        var StringList = new List<string>{
          "Apple Pie",
          "Burritos", 
          "Clams Casino",
          "Donuts"
          };
          
          foreach(var w in StringList)          
          {

#line default
#line hidden
                BeginContext(433, 18, true);
                WriteLiteral("            <div>\n");
                EndContext();
#line 21 "/Users/greg/codingdojo/cSharp/razor-fun/razor-fun/Views/Index/index.cshtml"
             if(w.Substring(0,1) == "c")
            {

#line default
#line hidden
                BeginContext(506, 17, true);
                WriteLiteral("              <p>");
                EndContext();
                BeginContext(524, 1, false);
#line 23 "/Users/greg/codingdojo/cSharp/razor-fun/razor-fun/Views/Index/index.cshtml"
            Write(w);

#line default
#line hidden
                EndContext();
                BeginContext(525, 5, true);
                WriteLiteral("</p>\n");
                EndContext();
#line 24 "/Users/greg/codingdojo/cSharp/razor-fun/razor-fun/Views/Index/index.cshtml"
              
            }
            else
            {

#line default
#line hidden
                BeginContext(590, 17, true);
                WriteLiteral("              <p>");
                EndContext();
                BeginContext(608, 1, false);
#line 28 "/Users/greg/codingdojo/cSharp/razor-fun/razor-fun/Views/Index/index.cshtml"
            Write(w);

#line default
#line hidden
                EndContext();
                BeginContext(609, 9, true);
                WriteLiteral("</p>    \n");
                EndContext();
#line 29 "/Users/greg/codingdojo/cSharp/razor-fun/razor-fun/Views/Index/index.cshtml"
            }

#line default
#line hidden
                BeginContext(632, 19, true);
                WriteLiteral("            </div>\n");
                EndContext();
#line 31 "/Users/greg/codingdojo/cSharp/razor-fun/razor-fun/Views/Index/index.cshtml"
          }
      

#line default
#line hidden
                BeginContext(671, 11, true);
                WriteLiteral("      \n    ");
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
            BeginContext(689, 2, true);
            WriteLiteral("\n\n");
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
