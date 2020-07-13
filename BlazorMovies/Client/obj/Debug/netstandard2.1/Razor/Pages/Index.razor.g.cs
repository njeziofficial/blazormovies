#pragma checksum "C:\Projects\BlazorMovies\BlazorMovies\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fdba09a0f1f73bdccd8faafab29cd756787c9e3"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.AddMarkupContent(2, "<h3>Movie</h3>\r\n    ");
            __builder.OpenComponent<BlazorMovies.Client.Shared.MoviesList>(3);
            __builder.AddAttribute(4, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorMovies.Shared.Entities.Movie>>(
#nullable restore
#line 4 "C:\Projects\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
                        movies

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Projects\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
      
    private List<Movie> movies;
    protected override void OnInitialized()
    {
        movies = new List<Movie>
        {
            new Movie{Title = "Spider-Man Far From Home", ReleaseDate = new DateTime(2019, 7, 2)},
            new Movie{Title = "Moana", ReleaseDate = new DateTime(2011, 11, 23)},
            new Movie{Title = "Hulk", ReleaseDate = new DateTime(2010, 7, 16)},
            new Movie{Title = "Spawn", ReleaseDate = new DateTime(2010, 7, 16)},
            new Movie{Title = "Terminator", ReleaseDate = new DateTime(2010, 7, 16)},
            new Movie{Title = "Ghost Rider", ReleaseDate = new DateTime(2010, 7, 16)},
            new Movie{Title = "Gladiator", ReleaseDate = new DateTime(2010, 7, 16)},
            new Movie{Title = "Frosh", ReleaseDate = new DateTime(2010, 7, 16)},
            new Movie{Title = "Omen", ReleaseDate = new DateTime(2010, 7, 16)},
            new Movie{Title = "Damien", ReleaseDate = new DateTime(2010, 7, 16)},
            new Movie{Title = "Vampires", ReleaseDate = new DateTime(2010, 7, 16)},
            new Movie{Title = "Dracula", ReleaseDate = new DateTime(2010, 7, 16)},
            new Movie{Title = "Jason", ReleaseDate = new DateTime(2010, 7, 16)},
            new Movie{Title = "Dusk Till Dawn", ReleaseDate = new DateTime(2010, 7, 16)},
            new Movie{Title = "Evil Dead", ReleaseDate = new DateTime(2010, 7, 16)},
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
