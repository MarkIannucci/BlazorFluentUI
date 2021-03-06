﻿using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorFabric.Demo.ClientSide
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<GlobalRules>("#staticcs");
            builder.RootComponents.Add<BlazorFabric.Demo.ClientSide.App>("app");

            builder.Services.AddBlazorFabric();
            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


            await builder.Build().RunAsync();
        }

        //public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
        //    BlazorWebAssemblyHost.CreateDefaultBuilder()
        //        .UseBlazorStartup<Startup>();
    }
}
