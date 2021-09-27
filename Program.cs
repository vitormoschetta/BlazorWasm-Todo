using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorTodo
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            // dependency injection 
            // builder.Services.AddSingleton<IMyDependency, MyDependency>();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(@"http://localhost:2001") });            

            await builder.Build().RunAsync();
        }
    }
}
