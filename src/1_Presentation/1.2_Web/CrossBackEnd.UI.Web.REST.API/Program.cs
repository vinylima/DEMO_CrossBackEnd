﻿
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace CrossBackEnd.UI.Web.REST.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://*:59496")
                .UseStartup<Startup>()
                .Build();
    }
}