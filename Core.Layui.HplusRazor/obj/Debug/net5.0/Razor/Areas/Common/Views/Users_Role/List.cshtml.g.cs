#pragma checksum "D:\.net\.netCore\Core.Layui.Razor\Core.Layui.HplusRazor\Areas\Common\Views\Users_Role\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1182094b8e9e215f0b65b75abc039164fa1b84ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Common_Views_Users_Role_List), @"mvc.1.0.view", @"/Areas/Common/Views/Users_Role/List.cshtml")]
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
#line 1 "D:\.net\.netCore\Core.Layui.Razor\Core.Layui.HplusRazor\Areas\Common\_ViewImports.cshtml"
using Core.Layui.HplusRazor.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.net\.netCore\Core.Layui.Razor\Core.Layui.HplusRazor\Areas\Common\_ViewImports.cshtml"
using Core.Layui.Razor.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.net\.netCore\Core.Layui.Razor\Core.Layui.HplusRazor\Areas\Common\_ViewImports.cshtml"
using Core.Layui.HplusRazor.Areas.User.Enum;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1182094b8e9e215f0b65b75abc039164fa1b84ff", @"/Areas/Common/Views/Users_Role/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e4f90a68781b901d7cc6fe5764dc9f8c563b541", @"/Areas/Common/_ViewImports.cshtml")]
    public class Areas_Common_Views_Users_Role_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("lay-filter", new global::Microsoft.AspNetCore.Html.HtmlString("SearchForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\.net\.netCore\Core.Layui.Razor\Core.Layui.HplusRazor\Areas\Common\Views\Users_Role\List.cshtml"
  
    Layout = "_LayuiLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1182094b8e9e215f0b65b75abc039164fa1b84ff5134", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>Layui</title>
    <meta name=""renderer"" content=""webkit"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1"">
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1182094b8e9e215f0b65b75abc039164fa1b84ff6371", async() => {
                WriteLiteral("\r\n    <div style=\"padding: 15px\">\r\n");
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1182094b8e9e215f0b65b75abc039164fa1b84ff6709", async() => {
                    WriteLiteral("\r\n            <input type=\"hidden\" name=\"role_UniqueId\"");
                    BeginWriteAttribute("value", " value=\"", 517, "\"", 549, 1);
#nullable restore
#line 17 "D:\.net\.netCore\Core.Layui.Razor\Core.Layui.HplusRazor\Areas\Common\Views\Users_Role\List.cshtml"
WriteAttributeValue("", 525, ViewBag.Role_UniqueId, 525, 24, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n");
                    WriteLiteral("            <div class=\"layui-collapse\"");
                    BeginWriteAttribute("lay-accordion", " lay-accordion=\"", 624, "\"", 640, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n");
                    WriteLiteral(@"                <div class=""layui-colla-item"">
                    <h2 class=""layui-colla-title"">
                        Search Info
                    </h2>
                    <div class=""layui-colla-content layui-show"">
                        <table class=""layui-form"" style=""width:100%"">
                            <tbody>
                                <tr>
                                    <td>用户名称：</td>
                                    <td>
                                        <input type=""text"" id=""UserName"" name=""UserName"" class=""layui-input"">
                                    </td>
                                    <td align=""center"">
                                        <button type=""button"" class=""layui-btn layui-btn-normal"" id=""btnSearch"">
                                            <i class=""layui-icon"">&#xe615;</i> Search
                                        </button>
                                        <button type=""reset"" class=""layui-btn layui-btn-war");
                    WriteLiteral(@"m"">
                                            <i class=""layui-icon"">&#xe666;</i> Reset
                                        </button>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
                WriteLiteral("        <table class=\"layui-hide\" id=\"users_RoleList\" lay-filter=\"users_RoleList\"></table>\r\n\r\n");
                WriteLiteral(@"        <script type=""text/html"" id=""toolbarDemo"">
            <div class=""layui-btn-container"">
                <button class=""layui-btn layui-btn-sm"" lay-event=""getCheckData"">获取选中行数据</button>
                <button class=""layui-btn layui-btn-sm"" lay-event=""getCheckLength"">获取选中数目</button>
                <button class=""layui-btn layui-btn-sm"" lay-event=""isAll"">验证是否全选</button>
            </div>
        </script>

");
                WriteLiteral(@"        <script type=""text/html"" id=""barDemo"">
            <button type=""button"" class=""layui-btn layui-btn-sm"" lay-event=""del"">
                <i class=""layui-icon"">&#xe640;</i>
            </button>
        </script>

        <script type=""text/javascript"">
            var form;
            var table;
            layui.use(['form', 'element', 'layer', 'table', 'laydate'], function () {
                form = layui.form;
                table = layui.table;

                tableRender();

                //头工具栏事件
                table.on('toolbar(users_RoleList)', function (obj) {
                    var checkStatus = table.checkStatus(obj.config.id);
                    switch (obj.event) {
                        case 'getCheckData':
                            var data = checkStatus.data;
                            layer.alert(JSON.stringify(data));
                            break;
                        case 'getCheckLength':
                            var data = checkStatu");
                WriteLiteral(@"s.data;
                            layer.msg('选中了：' + data.length + ' 个');
                            break;
                        case 'isAll':
                            layer.msg(checkStatus.isAll ? '全选' : '未全选');
                            break;

                        //自定义头工具栏右侧图标 - 提示
                        case 'LAYTABLE_TIPS':
                            layer.alert('这是工具栏右侧自定义的一个图标按钮');
                            break;
                    };
                });

                //监听行工具事件
                table.on('tool(users_RoleList)', function (obj) {
                    var data = obj.data;
                    //console.log(obj)
                    if (obj.event === 'del') {
                        layer.confirm('真的删除行么', function (index) {
                            obj.del();
                            layer.close(index);
                        });
                    }
                });
            });

            function tableRender() {
           ");
                WriteLiteral(@"     table.render({
                    elem: '#users_RoleList'
                    , url: '/Common/Users_Role/GetList'
                    , toolbar: '#toolbarDemo' //开启头部工具栏，并为其绑定左侧模板
                    , defaultToolbar: ['filter', 'exports', 'print', { //自定义头部工具栏右侧图标。如无需自定义，去除该参数即可
                        title: '提示'
                        , layEvent: 'LAYTABLE_TIPS'
                        , icon: 'layui-icon-tips'
                    }]
                    , title: 'User'
                    , cellMinWidth: 80
                    , where: form.val('SearchForm')
                    , cols: [[
                        { type: 'checkbox', fixed: 'left' }
                        , { field: 'RoleName', title: 'RoleName' }
                        , { field: 'UserName_Cn', title: 'UserName_Cn' }
                        , { field: 'UserName_En', title: 'UserName_En' }
                        , { field: 'UserStatusStr', title: 'UserStatus' }
                        , { fixed: 'right', title: 'O");
                WriteLiteral(@"peration', toolbar: '#barDemo', width: 180 }
                    ]]
                    , request: {
                        pageName: 'PageIndex',//页码的参数名称，默认：page
                        limitName: 'PageSize'//每页数据量的参数名，默认：limit
                    }
                    , page: true
                    , even: false //开启隔行背景
                    , id: 'users_RoleList'
                });
            }

            //表单查询
            layui.$('#btnSearch').on('click', function () {
                tableRender();
            });
        </script>

    </div>
");
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
            WriteLiteral("\r\n</html>\r\n");
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
