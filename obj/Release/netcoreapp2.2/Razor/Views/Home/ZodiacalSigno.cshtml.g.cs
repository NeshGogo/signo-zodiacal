#pragma checksum "D:\All Data\Universidad\C# Intermedio\Practica 1\SignoZodiacal\SignoZodiacal\Views\Home\ZodiacalSigno.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "590d0682bfde93adfdce04cbb077783a468e7b58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ZodiacalSigno), @"mvc.1.0.view", @"/Views/Home/ZodiacalSigno.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ZodiacalSigno.cshtml", typeof(AspNetCore.Views_Home_ZodiacalSigno))]
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
#line 1 "D:\All Data\Universidad\C# Intermedio\Practica 1\SignoZodiacal\SignoZodiacal\Views\_ViewImports.cshtml"
using SignoZodiacal;

#line default
#line hidden
#line 2 "D:\All Data\Universidad\C# Intermedio\Practica 1\SignoZodiacal\SignoZodiacal\Views\_ViewImports.cshtml"
using SignoZodiacal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"590d0682bfde93adfdce04cbb077783a468e7b58", @"/Views/Home/ZodiacalSigno.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2286b516a660bf73851b15fd610bbb56b8ecb2bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ZodiacalSigno : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SignoZodiacal.Models.ZodiacalSigno>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\All Data\Universidad\C# Intermedio\Practica 1\SignoZodiacal\SignoZodiacal\Views\Home\ZodiacalSigno.cshtml"
  
    ViewData["Title"] = "ZodiacalSigno";

#line default
#line hidden
            BeginContext(92, 153, true);
            WriteLiteral("\r\n<h1 class=\"display-4 text-center mb-lg-5\">Determina tu Signo Zodiacal.</h1>\r\n\r\n<section class=\"row justify-content-md-center align-items-center\">\r\n    ");
            EndContext();
            BeginContext(245, 536, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "590d0682bfde93adfdce04cbb077783a468e7b584476", async() => {
                BeginContext(317, 457, true);
                WriteLiteral(@"
        <div class=""mt-2"">
            <label class=""col-form-label font-weight-bold"">Selecciona tu fecha de nacimiento:</label>
        </div>
        <div class=""form-inline"">
            <div class="""">
                <input type=""date"" name=""yourdate"" class=""form-control-sm"" />
            </div>
            <div>
                <input type=""submit"" class=""btn btn-success btn-sm"" value=""Enviar"" />
            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 9 "D:\All Data\Universidad\C# Intermedio\Practica 1\SignoZodiacal\SignoZodiacal\Views\Home\ZodiacalSigno.cshtml"
AddHtmlAttributeValue("", 259, Url.Action("ZodiacalSigno"), 259, 28, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(781, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 22 "D:\All Data\Universidad\C# Intermedio\Practica 1\SignoZodiacal\SignoZodiacal\Views\Home\ZodiacalSigno.cshtml"
     if (Model != null)
    {

#line default
#line hidden
            BeginContext(815, 108, true);
            WriteLiteral("        <section class=\"col-2\">\r\n            <figure class=\" mt-4 figure figure-img \">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 923, "\"", 942, 1);
#line 26 "D:\All Data\Universidad\C# Intermedio\Practica 1\SignoZodiacal\SignoZodiacal\Views\Home\ZodiacalSigno.cshtml"
WriteAttributeValue("", 929, Model.ImgUrl, 929, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(943, 134, true);
            WriteLiteral(" width=\"250\" height=\"250\" alt=\"imagen del signo zodiacal\" class=\"rounded-circle\" />\r\n                <p class=\"ml-5 mt-1\">Tu signo es ");
            EndContext();
            BeginContext(1078, 10, false);
#line 27 "D:\All Data\Universidad\C# Intermedio\Practica 1\SignoZodiacal\SignoZodiacal\Views\Home\ZodiacalSigno.cshtml"
                                            Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1088, 51, true);
            WriteLiteral(". </p>\r\n            </figure>\r\n        </section>\r\n");
            EndContext();
#line 30 "D:\All Data\Universidad\C# Intermedio\Practica 1\SignoZodiacal\SignoZodiacal\Views\Home\ZodiacalSigno.cshtml"
    }

#line default
#line hidden
            BeginContext(1146, 16, true);
            WriteLiteral("</section>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignoZodiacal.Models.ZodiacalSigno> Html { get; private set; }
    }
}
#pragma warning restore 1591
