#pragma checksum "C:\Users\thiagomarciano\Rcky\Rcky_crud\Rcky_crud\Views\Funcionarios\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b00ad2b84dce633c9d38909b3df65c0e8d1cd60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionarios_Create), @"mvc.1.0.view", @"/Views/Funcionarios/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Funcionarios/Create.cshtml", typeof(AspNetCore.Views_Funcionarios_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b00ad2b84dce633c9d38909b3df65c0e8d1cd60", @"/Views/Funcionarios/Create.cshtml")]
    public class Views_Funcionarios_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rcky_crud.Models.Funcionario>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\thiagomarciano\Rcky\Rcky_crud\Rcky_crud\Views\Funcionarios\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(81, 1857, true);
            WriteLiteral(@"
<h2>Create</h2>

<h4>Funcionario</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Nome"" class=""control-label""></label>
                <input asp-for=""Nome"" class=""form-control"" />
                <span asp-validation-for=""Nome"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Endereco"" class=""control-label""></label>
                <input asp-for=""Endereco"" class=""form-control"" />
                <span asp-validation-for=""Endereco"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DataNascimento"" class=""control-label""></label>
                <input asp-for=""DataNascimento"" class=""form-control"" />
                <span asp-validation-for=""DataNascimento"" class=""text-d");
            WriteLiteral(@"anger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Salario"" class=""control-label""></label>
                <input asp-for=""Salario"" class=""form-control"" />
                <span asp-validation-for=""Salario"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Genero"" class=""control-label""></label>
                <select asp-for=""Genero"" class=""form-control""></select>
                <span asp-validation-for=""Genero"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1956, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 52 "C:\Users\thiagomarciano\Rcky\Rcky_crud\Rcky_crud\Views\Funcionarios\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rcky_crud.Models.Funcionario> Html { get; private set; }
    }
}
#pragma warning restore 1591
