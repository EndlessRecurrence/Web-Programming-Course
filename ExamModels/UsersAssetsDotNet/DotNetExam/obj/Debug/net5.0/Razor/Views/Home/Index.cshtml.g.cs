#pragma checksum "/home/calandrinon/Documents/an2sem2/Web-Programming/ExamModels/UsersAssetsDotNet/DotNetExam/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98eef95d227573de4d52ce7d600cc8b4d5b7786f"
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
#line 1 "/home/calandrinon/Documents/an2sem2/Web-Programming/ExamModels/UsersAssetsDotNet/DotNetExam/Views/_ViewImports.cshtml"
using DotNetExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/calandrinon/Documents/an2sem2/Web-Programming/ExamModels/UsersAssetsDotNet/DotNetExam/Views/_ViewImports.cshtml"
using DotNetExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98eef95d227573de4d52ce7d600cc8b4d5b7786f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"233b062cffae5ba0313325c41c917a52735fa376", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/calandrinon/Documents/an2sem2/Web-Programming/ExamModels/UsersAssetsDotNet/DotNetExam/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
/**
    $(document).ready(function(){
		$(""#registerButton"").click(function() {
			$.post(""/Auth/Register"", {username: $(""#username"").val(), password: $(""#password"").val()},
				function(data,status) {
					$(""#maindiv"").html(data);
				});
		});
	});
	**/
</script>

<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
	
</div>");
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
