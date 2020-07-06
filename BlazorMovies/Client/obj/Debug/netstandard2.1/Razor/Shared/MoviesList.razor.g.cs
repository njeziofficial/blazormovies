#pragma checksum "C:\Projects\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f365aaba2e312ffafc1c9355d4016409a729995"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
    public partial class MoviesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n");
#nullable restore
#line 2 "C:\Projects\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
     if (Movies == null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
         if (NullTemplate != null)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, 
#nullable restore
#line 7 "C:\Projects\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
             NullTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 7 "C:\Projects\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                         
        }
        else
        {
            //if ChildContent is null
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "Loading...");
#nullable restore
#line 12 "C:\Projects\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                                   
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Projects\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
         
    }
    else if (Movies.Count == 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Projects\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
         if (EmptyTemplate != null)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, 
#nullable restore
#line 19 "C:\Projects\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
             EmptyTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 19 "C:\Projects\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                          
        }
        else
        {
            //Default
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "There are currently no movies to display.");
#nullable restore
#line 24 "C:\Projects\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                                                                  
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Projects\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "checkbox");
            __builder.AddAttribute(9, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Projects\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                                      _displayButtons

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _displayButtons = __value, _displayButtons));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 30 "C:\Projects\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
         foreach (var movie in Movies)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "            ");
            __builder.OpenComponent<BlazorMovies.Client.Shared.IndividualMovie>(13);
            __builder.AddAttribute(14, "Movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorMovies.Shared.Entities.Movie>(
#nullable restore
#line 32 "C:\Projects\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                                    movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "DisplayButtons", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\Projects\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                                                            _displayButtons

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "DeleteMovie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorMovies.Shared.Entities.Movie>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorMovies.Shared.Entities.Movie>(this, 
#nullable restore
#line 32 "C:\Projects\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                                                                                           DeleteMovie

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 33 "C:\Projects\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Projects\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Projects\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
       
    [Parameter]
    public List<Movie> Movies { get; set; }

    [Parameter]
    public RenderFragment NullTemplate { get; set; }
    [Parameter]
    public RenderFragment EmptyTemplate { get; set; }

    bool _displayButtons = true;

    void DeleteMovie(Movie movie)
    {
        Movies.Remove(movie);
    }

    protected override void OnInitialized()
    {
        Console.WriteLine("OnInitialized.Movies.Count = "+ Movies.Count.ToString());
    }

    protected override void OnParametersSet()
    {
        Console.WriteLine("OnParametersSet.Movies.Count = " + Movies.Count.ToString());
    }

    protected override void OnAfterRender(bool firstRender)
    {
        Console.WriteLine("OnAfterRender.FirstRender= "+ firstRender.ToString());
    }

    protected override bool ShouldRender()
    {
       return true;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591