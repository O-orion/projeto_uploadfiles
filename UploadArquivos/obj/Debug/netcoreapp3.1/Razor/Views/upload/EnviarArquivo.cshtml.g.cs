#pragma checksum "C:\Users\Lucas\Desktop\Lucas\Projetos\mvc\UploadArquivos\Views\upload\EnviarArquivo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5519a479b1585ebaad8d65d2f4c5ffb547320df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_upload_EnviarArquivo), @"mvc.1.0.view", @"/Views/upload/EnviarArquivo.cshtml")]
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
#line 1 "C:\Users\Lucas\Desktop\Lucas\Projetos\mvc\UploadArquivos\Views\_ViewImports.cshtml"
using UploadArquivos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lucas\Desktop\Lucas\Projetos\mvc\UploadArquivos\Views\_ViewImports.cshtml"
using UploadArquivos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5519a479b1585ebaad8d65d2f4c5ffb547320df", @"/Views/upload/EnviarArquivo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1a7665a223f7aff22da668b3c84880ac5d607a5", @"/Views/_ViewImports.cshtml")]
    public class Views_upload_EnviarArquivo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Lucas\Desktop\Lucas\Projetos\mvc\UploadArquivos\Views\upload\EnviarArquivo.cshtml"
  
    ViewData["Title"] = "Upload Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Upload filezinho</h1>\r\n<hr />\r\n<div class=\"jumbotron jumbotron-fluid\">\r\n  <div class=\"container\">\r\n");
#nullable restore
#line 8 "C:\Users\Lucas\Desktop\Lucas\Projetos\mvc\UploadArquivos\Views\upload\EnviarArquivo.cshtml"
     if(ViewData["Error"] != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("      <h2 class=\"display-4\">");
#nullable restore
#line 9 "C:\Users\Lucas\Desktop\Lucas\Projetos\mvc\UploadArquivos\Views\upload\EnviarArquivo.cshtml"
                       Write(ViewData);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 10 "C:\Users\Lucas\Desktop\Lucas\Projetos\mvc\UploadArquivos\Views\upload\EnviarArquivo.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\r\n  <div class=\"container\">\r\n");
#nullable restore
#line 13 "C:\Users\Lucas\Desktop\Lucas\Projetos\mvc\UploadArquivos\Views\upload\EnviarArquivo.cshtml"
     if(ViewData["Resultado"] != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("      <h2 class=\"display-4\">");
#nullable restore
#line 14 "C:\Users\Lucas\Desktop\Lucas\Projetos\mvc\UploadArquivos\Views\upload\EnviarArquivo.cshtml"
                       Write(ViewData);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 15 "C:\Users\Lucas\Desktop\Lucas\Projetos\mvc\UploadArquivos\Views\upload\EnviarArquivo.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\r\n</div>\r\n");
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
