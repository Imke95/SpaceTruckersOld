#pragma checksum "C:\Users\User\Programming\CSharp\Space_Truckers\Space_Truckers\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76bc535e834d6e4c91f2a3aa1952ec2b49de91cf"
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
#line 1 "C:\Users\User\Programming\CSharp\Space_Truckers\Space_Truckers\Views\_ViewImports.cshtml"
using Space_Truckers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Programming\CSharp\Space_Truckers\Space_Truckers\Views\_ViewImports.cshtml"
using Space_Truckers.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76bc535e834d6e4c91f2a3aa1952ec2b49de91cf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e00a104c14b3c07808501dbde6ce3cdd728d44", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Galaxy Map</h1>
<img src=""./assets/galaxymap.jpg"" Alt=""Dit zou een sterrenkaart moeten zijn"" height=400>

<h1>Bereken kortste route</h1>
<p>Vul de planeet in waar je wilt starten en de planeet waar je naar toe wilt.</p>
    Start:
<input type=""text"" id=""start"" value=""A""/> Eind:
<input type=""text"" id=""eind"" value=""F""/>
<button onClick=""shortestPath()"">Plan Route</button>

<div id=""resultaat"">
    <p>Hier komt het resultaat</p>
</div>


<script>
    function shortestPath() {
        var start = document.getElementById(""start"").value;
        var eind = document.getElementById(""eind"").value;
        //var url = ""/GetPath"";
        var url = ""https://localhost:44379/GetPath?from="" + start + ""&to="" + eind;
        console.log(url);
        var xhr = new XMLHttpRequest();
        xhr.onreadystatechange = function() {
            if (this.readyState == 4 && this.status == 200) {
                var div = document.getElementById(""resultaat"");
                div.innerHTML = ""<p>"" + xhr");
            WriteLiteral(".responseText + \"</p>\";\r\n            }\r\n        }\r\n        xhr.open(\"GET\", url, true);\r\n        xhr.send();\r\n    }\r\n</script>");
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
