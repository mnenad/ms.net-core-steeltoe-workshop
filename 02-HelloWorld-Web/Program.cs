﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace WebApplication.hw
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
 	            .UseKestrel()
 		        .UseStartup<Startup>()
 	            .Build();
            host.Run();
        }
    }
}
