#pragma checksum "/home/calandrinon/Documents/an2sem2/Web-Programming/Lab-10/EnterpriseUserManagementSystem-ActualProject/EnterpriseUserManagementSystem-ActualProject/Views/Remove/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ba19ea43b92076fe369e74e53bcad1b76655072"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Remove_Index), @"mvc.1.0.view", @"/Views/Remove/Index.cshtml")]
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
#line 1 "/home/calandrinon/Documents/an2sem2/Web-Programming/Lab-10/EnterpriseUserManagementSystem-ActualProject/EnterpriseUserManagementSystem-ActualProject/Views/_ViewImports.cshtml"
using EnterpriseUserManagementSystem_ActualProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/calandrinon/Documents/an2sem2/Web-Programming/Lab-10/EnterpriseUserManagementSystem-ActualProject/EnterpriseUserManagementSystem-ActualProject/Views/_ViewImports.cshtml"
using EnterpriseUserManagementSystem_ActualProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ba19ea43b92076fe369e74e53bcad1b76655072", @"/Views/Remove/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fa57042926b4032ef8291f98a199cdbb50d64e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Remove_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/calandrinon/Documents/an2sem2/Web-Programming/Lab-10/EnterpriseUserManagementSystem-ActualProject/EnterpriseUserManagementSystem-ActualProject/Views/Remove/Index.cshtml"
  
    ViewData["Title"] = "Remove users";

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

<h1>Remove users</h1>

");
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
