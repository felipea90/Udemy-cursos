#pragma checksum "C:\Users\felip\Documents\Udemy-cursos\Curso de ASP .Net Core MVC\Lanches\Lanches\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9e48420550556f971c0f562dea2ce24733313b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\felip\Documents\Udemy-cursos\Curso de ASP .Net Core MVC\Lanches\Lanches\Views\_ViewImports.cshtml"
using Lanches;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\felip\Documents\Udemy-cursos\Curso de ASP .Net Core MVC\Lanches\Lanches\Views\_ViewImports.cshtml"
using Lanches.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\felip\Documents\Udemy-cursos\Curso de ASP .Net Core MVC\Lanches\Lanches\Views\_ViewImports.cshtml"
using Lanches.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9e48420550556f971c0f562dea2ce24733313b4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"954ce923433bc5ec1b679f16128afdfd86b19cae", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\felip\Documents\Udemy-cursos\Curso de ASP .Net Core MVC\Lanches\Lanches\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_Carousel"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    <h1>Preferidos da Semana!</h1>\r\n    <p> </p>\r\n    <h4>Escolha o seu!</h4>\r\n</div>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 12 "C:\Users\felip\Documents\Udemy-cursos\Curso de ASP .Net Core MVC\Lanches\Lanches\Views\Home\Index.cshtml"
     foreach (var lanche in Model.LanchesPreferidos)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\felip\Documents\Udemy-cursos\Curso de ASP .Net Core MVC\Lanches\Lanches\Views\Home\Index.cshtml"
   Write(Html.Partial("_LanchesResumo", lanche));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\felip\Documents\Udemy-cursos\Curso de ASP .Net Core MVC\Lanches\Lanches\Views\Home\Index.cshtml"
                                               
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
