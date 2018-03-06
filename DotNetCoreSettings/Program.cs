﻿using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace DotNetCoreSettings
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) => {
                    config.AddJsonFile("appsettings.json");
                    config.AddJsonFile("creds.json");
                })
                .UseStartup<Startup>()
                .Build();
    }
}
