using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
    public static class IjsRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
        {
            try
            {
                await js.InvokeVoidAsync("console.log", "Hello from IjsRuntimeExtensionMethods");
                if (message == null) throw new ArgumentNullException(nameof(message));
                return await js.InvokeAsync<bool>("confirm", "message");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
    }
}
