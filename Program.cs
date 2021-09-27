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

            DependencyInjectionConfig(builder);

            await builder.Build().RunAsync();
        }

        public static void DependencyInjectionConfig(WebAssemblyHostBuilder builder)
        {
            if (builder.HostEnvironment.IsDevelopment())
            {
                builder.Services.AddScoped(sp =>
                    new HttpClient { BaseAddress = new Uri(@"http://localhost:2001") });
            }
            else
            {
                builder.Services.AddScoped(sp =>
                    new HttpClient { BaseAddress = new Uri(@"https://614f74d1a706cd00179b726f.mockapi.io") });
            }

            // others dependency injection 
            // builder.Services.AddSingleton<IMyDependency, MyDependency>();     
        }
    }
}
