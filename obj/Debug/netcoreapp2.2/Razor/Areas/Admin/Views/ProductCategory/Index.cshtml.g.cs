#pragma checksum "C:\.NetCoreLive\qhnam.myclass\shunshine\shunshine\Areas\Admin\Views\ProductCategory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "246d8a3990d63f9fa0e09f654877c0a90915f535"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductCategory_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductCategory/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ProductCategory/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_ProductCategory_Index))]
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
#line 1 "C:\.NetCoreLive\qhnam.myclass\shunshine\shunshine\Areas\Admin\Views\_ViewImports.cshtml"
using shunshine;

#line default
#line hidden
#line 2 "C:\.NetCoreLive\qhnam.myclass\shunshine\shunshine\Areas\Admin\Views\_ViewImports.cshtml"
using shunshine.Models;

#line default
#line hidden
#line 3 "C:\.NetCoreLive\qhnam.myclass\shunshine\shunshine\Areas\Admin\Views\_ViewImports.cshtml"
using shunshine.App.Models.ViewModels;

#line default
#line hidden
#line 4 "C:\.NetCoreLive\qhnam.myclass\shunshine\shunshine\Areas\Admin\Views\_ViewImports.cshtml"
using shunshine.App.EntityCodeFirst.Constant;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"246d8a3990d63f9fa0e09f654877c0a90915f535", @"/Areas/Admin/Views/ProductCategory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a280b538e9840c87dcf9d493e49476466691f57d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ProductCategory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/css/style-custom.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "20", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app/shrared/shunshine.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app/controllers/product_category/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\.NetCoreLive\qhnam.myclass\shunshine\shunshine\Areas\Admin\Views\ProductCategory\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(143, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(161, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(167, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "246d8a3990d63f9fa0e09f654877c0a90915f5356707", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(228, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(233, 3592, true);
            WriteLiteral(@"
<div class=""panel-content shunshine-page-content"">
    <div class=""panel-body container-fluid"">
        <div class=""row row-lg"">
            <div class=""col-xl-12"">
                <!-- Example Tabs Solid -->
                <div class=""example-wrap"">
                    <div class=""nav-tabs-horizontal"" data-plugin=""tabs"">
                        <ul class=""nav nav-tabs nav-tabs-solid"" role=""tablist"">
                            <li class=""nav-item"" role=""presentation""><a class=""nav-link active"" data-toggle=""tab"" href=""#categoryList"" aria-controls=""exampleTabsSolidOne"" role=""tab"">Category List</a></li>
                            <li class=""nav-item"" role=""presentation""><a class=""nav-link"" data-toggle=""tab"" href=""#position"" aria-controls=""exampleTabsSolidTwo"" role=""tab"">Position</a></li>
                            <li class=""dropdown nav-item"" role=""presentation"" style=""display: none;"">
                                <a class=""dropdown-toggle nav-link"" data-toggle=""dropdown"" href=""#"" aria-expan");
            WriteLiteral(@"ded=""false"">Dropdown </a>
                                <div class=""dropdown-menu"" role=""menu"">
                                    <a class=""dropdown-item"" data-toggle=""tab"" href=""#exampleTabsSolidOne"" aria-controls=""categoryList"" role=""tab"">Category List</a>
                                    <a class=""dropdown-item"" data-toggle=""tab"" href=""#exampleTabsSolidTwo"" aria-controls=""position"" role=""tab"">Position</a>
                                </div>
                            </li>
                        </ul>
                        <div class=""tab-content"">
                            <div class=""tab-pane active"" id=""categoryList"" role=""tabpanel"">
                                <div class=""row container-fluid"">
                                    <div class=""col-md-6"">
                                        <button type=""button"" class=""btn btn-outline btn-primary"" id=""btnCreate"">
                                            <i class=""icon wb-add-file"" aria-hidden=""true""></i>
            ");
            WriteLiteral(@"                                Create
                                        </button>
                                        <button type=""button"" class=""btn btn-outline btn-danger"" id=""btnDelete"">
                                            <i class=""icon wb-trash"" aria-hidden=""true""></i>
                                            Delete
                                        </button>
                                    </div>
                                    <div class=""col-md-4"">
                                        <div class=""form-group"">
                                            <div class=""input-group"">
                                                <input type=""text"" class=""form-control"" id=""txtSearchCategory"" placeholder=""Search..."">
                                                <span class=""input-group-append"">
                                                    <button type=""submit"" id=""btnSearchCategory"" class=""btn btn-primary""><i class=""icon wb-search"" aria-hidden=""t");
            WriteLiteral(@"rue""></i></button>
                                                </span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-md-2"">
                                        <div class=""form-group"">
                                            <select data-plugin=""selectpicker"" id=""paginateShowLimit"" class=""form-control"">
                                                ");
            EndContext();
            BeginContext(3825, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "246d8a3990d63f9fa0e09f654877c0a90915f53512002", async() => {
                BeginContext(3844, 2, true);
                WriteLiteral("10");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3855, 50, true);
            WriteLiteral("\r\n                                                ");
            EndContext();
            BeginContext(3905, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "246d8a3990d63f9fa0e09f654877c0a90915f53513424", async() => {
                BeginContext(3924, 2, true);
                WriteLiteral("20");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3935, 50, true);
            WriteLiteral("\r\n                                                ");
            EndContext();
            BeginContext(3985, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "246d8a3990d63f9fa0e09f654877c0a90915f53514846", async() => {
                BeginContext(4004, 2, true);
                WriteLiteral("50");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4015, 5504, true);
            WriteLiteral(@"
                                            </select>
                                        </div>
                                    </div>
                                </div>
                                <table class=""table table-hover"" data-plugin=""selectable"" data-row-selectable=""true"">
                                    <thead>
                                        <tr>
                                            <th class=""w-50"">
                                                <span class=""checkbox-custom checkbox-primary"">
                                                    <input class=""selectable-all"" type=""checkbox"">
                                                    <label></label>
                                                </span>
                                            </th>
                                            <th>
                                                Id
                                            </th>
                                   ");
            WriteLiteral(@"         <th>
                                                Name
                                            </th>
                                            <th class=""hidden-sm-down"">
                                                Slug
                                            </th>

                                            <th class=""hidden-sm-down"">
                                                Date Created
                                            </th>
                                            <th class=""hidden-sm-down"">
                                                Status
                                            </th>
                                            <th>
                                                Action
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody id=""tbodyContent"">
                                        <tr>");
            WriteLiteral(@"
                                            <td>
                                                <span class=""checkbox-custom checkbox-primary"">
                                                    <input class=""selectable-item"" type=""checkbox"" id=""row-619"" value=""619"">
                                                    <label for=""row-619""></label>
                                                </span>
                                            </td>
                                            <td>619</td>
                                            <td>The sun climbing plan</td>
                                            <td>
                                            </td>
                                            <td>
                                            </td>
                                            <td></td>
                                            <td class=""text-nowrap"">
                                                <button type=""button"" class=""btn btn-sm btn-icon b");
            WriteLiteral(@"tn-flat btn-default"" data-toggle=""tooltip"" data-original-title=""View"" aria-describedby=""tooltip662061"">
                                                    <i class=""icon wb-eye"" aria-hidden=""true""></i>
                                                </button><button type=""button"" class=""btn btn-sm btn-icon btn-flat btn-default"" data-toggle=""tooltip"" data-original-title=""Edit"" aria-describedby=""tooltip662061"">
                                                    <i class=""icon wb-wrench"" aria-hidden=""true""></i>
                                                </button>
                                                <button type=""button"" class=""btn btn-sm btn-icon btn-flat btn-default"" data-toggle=""tooltip"" data-original-title=""Delete"">
                                                    <i class=""icon wb-close"" aria-hidden=""true""></i>
                                                </button>
                                            </td>
                                        </tr>

            ");
            WriteLiteral(@"                        </tbody>
                                </table>
                                <div class=""row "">
                                    <div class=""col-md-6"">
                                        <em>show 10 -20 / 200</em>
                                    </div>
                                    <div class=""col-md-6"">
                                        <ul id=""paginateCategory"" class=""float-right""> </ul>
                                    </div>
                                </div>
                            </div>
                            <div class=""tab-pane"" id=""position"" role=""tabpanel"">
                                Ambigua huc ipsarum similique malis physicis splendide, miser philosophi tria finitum
                                errata hominum emolumento officii explicabo appellantur,
                                suscipiet inciderit spatio, quantumcumque disciplinae maluisti
                                putarent cogitemus. Voluerint a");
            WriteLiteral(@"dipiscendarum aristotele
                                invidi fructuosam.
                            </div>

                        </div>
                    </div>
                </div>
                <!-- End Example Tabs Solid -->
            </div>
        </div>
    </div>
</div>
<div id=""fileManagerContent""></div>
<div id=""modalShowCategoryDetail""></div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(9536, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(9542, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "246d8a3990d63f9fa0e09f654877c0a90915f53522158", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9592, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(9598, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "246d8a3990d63f9fa0e09f654877c0a90915f53523414", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9665, 2030, true);
                WriteLiteral(@"
    <script>
        var prodcutCategoryController = new ProductCategoryController();
        prodcutCategoryController.Initial();


        $(document).on(""click"", ""#btnCreate"", function () {
            $(""#modalCreateCategory"").modal(""show"");
            $(""#frmCategoryShowMessage"").html("""");

            $.ajax({
                type: ""GET"",
                url: ""/admin/productcategory/GetListParent"",
                success: function (response) {
                    var render = """";
                    render += ""<option value=''>--- Choose Parent ---</option>"";
                    $.each(response, function(key, value){
                        render += ""<option value='""+value.Id+""'>""+value.Name+""</option>"";
                    })

                    $(""#txtParentId"").html(render);
                },
                error: function (response) {
                    console.log(response);
                    shunshine.showMessageError(""Error when loading parent cateogory"")
      ");
                WriteLiteral(@"          }
            })
        })

        $(document).on(""click"", "".btnChooseFileName"", function (event) {
            event.preventDefault();

            $.ajax({
                type: ""GET"",
                url: ""/admin/FileManager/GetFileManagerPartial"",
                beforeSend: function (data) {
                    shunshine.startLoading();
                },
                success: function (data) {
                    $(""#fileManagerContent"").html(data);
                    shunshine.stopLoading();
                }
            })

            setTimeout(function () {
                $(""#shunshineFileManager"").modal(""show"");
            }, 1000);

        })

        $(document).on(""click"", ""#btnChooseImage"",function () {
            var srcImage = $(""#shunshineFileManagerListImageContent"").find("".isChecked"").first().val();
            $(""#shunshineFileManager"").modal(""hide"");
            $(""#txtImage"").val(srcImage);
        })
    </script>

");
                EndContext();
            }
            );
            BeginContext(11699, 39, false);
#line 208 "C:\.NetCoreLive\qhnam.myclass\shunshine\shunshine\Areas\Admin\Views\ProductCategory\Index.cshtml"
Write(await Html.PartialAsync("_Form.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(11738, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(11825, 4, true);
            WriteLiteral("\r\n\r\n");
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
