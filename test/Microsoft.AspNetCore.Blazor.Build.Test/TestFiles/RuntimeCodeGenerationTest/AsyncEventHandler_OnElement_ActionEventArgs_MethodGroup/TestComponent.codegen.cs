// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    public class TestComponent : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "input");
            builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(OnClick));
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 4 "x:\dir\subdir\Test\TestComponent.cshtml"
            
    Task OnClick(UIMouseEventArgs e) 
    {
        return Task.CompletedTask;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
