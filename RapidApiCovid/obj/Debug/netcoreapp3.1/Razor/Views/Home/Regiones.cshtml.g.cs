#pragma checksum "C:\Users\ditzep\OneDrive - San Diego, S. A\Documents\rapidapicovid\RapidApiCovid\Views\Home\Regiones.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "213aa35799f6496b5838aea03dafa61d6e6cbecf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Regiones), @"mvc.1.0.view", @"/Views/Home/Regiones.cshtml")]
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
#line 1 "C:\Users\ditzep\OneDrive - San Diego, S. A\Documents\rapidapicovid\RapidApiCovid\Views\_ViewImports.cshtml"
using RapidApiCovid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ditzep\OneDrive - San Diego, S. A\Documents\rapidapicovid\RapidApiCovid\Views\_ViewImports.cshtml"
using RapidApiCovid.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"213aa35799f6496b5838aea03dafa61d6e6cbecf", @"/Views/Home/Regiones.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3c060c71985154ebfb33059dccc2062ea803c25", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Regiones : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RapidApiCovid.Models.RegionCasesDeaths>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ditzep\OneDrive - San Diego, S. A\Documents\rapidapicovid\RapidApiCovid\Views\Home\Regiones.cshtml"
  
    ViewData["Title"] = "Reporte/Region";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"regiones\">\r\n    <h1>Regiones</h1>\r\n\r\n    <div class=\"d-flex flex-row justify-content-between\">\r\n        <div>\r\n            <select name=\"number\" id=\"myregions\" v-model=\"region\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "213aa35799f6496b5838aea03dafa61d6e6cbecf3993", async() => {
                WriteLiteral("Select a Region");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\ditzep\OneDrive - San Diego, S. A\Documents\rapidapicovid\RapidApiCovid\Views\Home\Regiones.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "213aa35799f6496b5838aea03dafa61d6e6cbecf5466", async() => {
#nullable restore
#line 16 "C:\Users\ditzep\OneDrive - San Diego, S. A\Documents\rapidapicovid\RapidApiCovid\Views\Home\Regiones.cshtml"
                                            Write(item.Region);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\ditzep\OneDrive - San Diego, S. A\Documents\rapidapicovid\RapidApiCovid\Views\Home\Regiones.cshtml"
                       WriteLiteral(item.Region);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\ditzep\OneDrive - San Diego, S. A\Documents\rapidapicovid\RapidApiCovid\Views\Home\Regiones.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
            <button onclick=""onclicreporte()"">Reporte</button>
        </div>
        <div>
            <button v-on:click=""exportXml"">XML</button>
            <button v-on:click=""exportJson"">JSON</button>
            <button v-on:click=""exportCsv"">CSV</button>
        </div>
    </div>
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    ");
#nullable restore
#line 31 "C:\Users\ditzep\OneDrive - San Diego, S. A\Documents\rapidapicovid\RapidApiCovid\Views\Home\Regiones.cshtml"
               Write(Html.DisplayNameFor(model => model.Region));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 34 "C:\Users\ditzep\OneDrive - San Diego, S. A\Documents\rapidapicovid\RapidApiCovid\Views\Home\Regiones.cshtml"
               Write(Html.DisplayNameFor(model => model.Cases));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 37 "C:\Users\ditzep\OneDrive - San Diego, S. A\Documents\rapidapicovid\RapidApiCovid\Views\Home\Regiones.cshtml"
               Write(Html.DisplayNameFor(model => model.Deaths));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\ditzep\OneDrive - San Diego, S. A\Documents\rapidapicovid\RapidApiCovid\Views\Home\Regiones.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 46 "C:\Users\ditzep\OneDrive - San Diego, S. A\Documents\rapidapicovid\RapidApiCovid\Views\Home\Regiones.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Region));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 49 "C:\Users\ditzep\OneDrive - San Diego, S. A\Documents\rapidapicovid\RapidApiCovid\Views\Home\Regiones.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Cases));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 52 "C:\Users\ditzep\OneDrive - San Diego, S. A\Documents\rapidapicovid\RapidApiCovid\Views\Home\Regiones.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Deaths));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 55 "C:\Users\ditzep\OneDrive - San Diego, S. A\Documents\rapidapicovid\RapidApiCovid\Views\Home\Regiones.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<script src=\"https://cdn.jsdelivr.net/npm/axios/dist/axios.min.js\"></script>\r\n<script src=\"https://cdn.jsdelivr.net/npm/vue@2.6.12\"></script>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        function onclicreporte() {
            var selected = document.getElementById(""myregions"").value;
            location.href = `/Home/Regiones/${selected}/Reporte`;
        }

        var app = new Vue({
            el: '#regiones',
            data: {
                region: """",
                selected:""""
            },
            methods: {
                async exportJson() {
                    await axios.get(
                        `/Regiones/Reporte/Json2`,
                        {
                            responseType: 'blob'
                        }
                    ).then((response) => {
                        var name_header = response.headers[""content-disposition""].split("";"")[1];
                        var name = name_header.split(""="")[1].replace(""\"""", """").replace(""\"""", """");

                        const url = window.URL.createObjectURL(new Blob([response.data]));
                        const link = document.createElement('a');
        ");
                WriteLiteral(@"                link.href = url;
                        link.setAttribute('download', name);
                        document.body.appendChild(link);
                        link.click();
                    }).catch((error) => {
                        console.log(error);
                    });
                },
                async exportXml() {
                    await axios.get(
                        `/Regiones/Reporte/Xml2`,
                        {
                            responseType: 'blob'
                        }
                    ).then((response) => {
                        var name_header = response.headers[""content-disposition""].split("";"")[1];
                        var name = name_header.split(""="")[1].replace(""\"""", """").replace(""\"""", """");

                        const url = window.URL.createObjectURL(new Blob([response.data]));
                        const link = document.createElement('a');
                        link.href = url;
                        ");
                WriteLiteral(@"link.setAttribute('download', name);
                        document.body.appendChild(link);
                        link.click();
                    }).catch((error) => {
                        console.log(error);
                    });
                },
                async exportCsv() {
                    await axios.get(
                        `/Regiones/Reporte/Csv2`,
                        {
                            responseType: 'blob'
                        }
                    ).then((response) => {
                        var name_header = response.headers[""content-disposition""].split("";"")[1];
                        var name = name_header.split(""="")[1].replace(""\"""", """").replace(""\"""", """");

                        const url = window.URL.createObjectURL(new Blob([response.data]));
                        const link = document.createElement('a');
                        link.href = url;
                        link.setAttribute('download', name);
                    ");
                WriteLiteral(@"    document.body.appendChild(link);
                        link.click();
                    }).catch((error) => {
                        console.log(error);
                    });
                }
            },
            created() {
                this.selected =""");
#nullable restore
#line 137 "C:\Users\ditzep\OneDrive - San Diego, S. A\Documents\rapidapicovid\RapidApiCovid\Views\Home\Regiones.cshtml"
                           Write(ViewBag.region);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n            }\r\n        })\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RapidApiCovid.Models.RegionCasesDeaths>> Html { get; private set; }
    }
}
#pragma warning restore 1591
