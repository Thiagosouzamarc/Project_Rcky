#pragma checksum "C:\Users\thiagomarciano\Rcky\Rcky_crud\Rcky_crud\Views\Funcionarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e9cf003f1b0671827224e5b026107aa64f49a15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionarios_Index), @"mvc.1.0.view", @"/Views/Funcionarios/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Funcionarios/Index.cshtml", typeof(AspNetCore.Views_Funcionarios_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e9cf003f1b0671827224e5b026107aa64f49a15", @"/Views/Funcionarios/Index.cshtml")]
    public class Views_Funcionarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Rcky_crud.Models.Funcionario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\thiagomarciano\Rcky\Rcky_crud\Rcky_crud\Views\Funcionarios\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(93, 158, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(252, 40, false);
#line 16 "C:\Users\thiagomarciano\Rcky\Rcky_crud\Rcky_crud\Views\Funcionarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(292, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(348, 44, false);
#line 19 "C:\Users\thiagomarciano\Rcky\Rcky_crud\Rcky_crud\Views\Funcionarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(392, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(448, 50, false);
#line 22 "C:\Users\thiagomarciano\Rcky\Rcky_crud\Rcky_crud\Views\Funcionarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(498, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(554, 43, false);
#line 25 "C:\Users\thiagomarciano\Rcky\Rcky_crud\Rcky_crud\Views\Funcionarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Salario));

#line default
#line hidden
            EndContext();
            BeginContext(597, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(653, 42, false);
#line 28 "C:\Users\thiagomarciano\Rcky\Rcky_crud\Rcky_crud\Views\Funcionarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Genero));

#line default
#line hidden
            EndContext();
            BeginContext(695, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\thiagomarciano\Rcky\Rcky_crud\Rcky_crud\Views\Funcionarios\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(813, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(862, 39, false);
#line 37 "C:\Users\thiagomarciano\Rcky\Rcky_crud\Rcky_crud\Views\Funcionarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(901, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(957, 43, false);
#line 40 "C:\Users\thiagomarciano\Rcky\Rcky_crud\Rcky_crud\Views\Funcionarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(1000, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1056, 49, false);
#line 43 "C:\Users\thiagomarciano\Rcky\Rcky_crud\Rcky_crud\Views\Funcionarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1161, 42, false);
#line 46 "C:\Users\thiagomarciano\Rcky\Rcky_crud\Rcky_crud\Views\Funcionarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Salario));

#line default
#line hidden
            EndContext();
            BeginContext(1203, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1259, 41, false);
#line 49 "C:\Users\thiagomarciano\Rcky\Rcky_crud\Rcky_crud\Views\Funcionarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Genero));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1375, "\"", 1398, 1);
#line 52 "C:\Users\thiagomarciano\Rcky\Rcky_crud\Rcky_crud\Views\Funcionarios\Index.cshtml"
WriteAttributeValue("", 1390, item.Id, 1390, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1399, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1451, "\"", 1474, 1);
#line 53 "C:\Users\thiagomarciano\Rcky\Rcky_crud\Rcky_crud\Views\Funcionarios\Index.cshtml"
WriteAttributeValue("", 1466, item.Id, 1466, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1475, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1529, "\"", 1552, 1);
#line 54 "C:\Users\thiagomarciano\Rcky\Rcky_crud\Rcky_crud\Views\Funcionarios\Index.cshtml"
WriteAttributeValue("", 1544, item.Id, 1544, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1553, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "C:\Users\thiagomarciano\Rcky\Rcky_crud\Rcky_crud\Views\Funcionarios\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1603, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Rcky_crud.Models.Funcionario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
