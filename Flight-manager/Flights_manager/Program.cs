using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Flights_manager
{
    /// <summary>
    /// This is class Program. It runs the whole application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// This function is used to run the C# application.
        /// </summary>
        /// <param name="args"> String of arguments.</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        /// <summary>
        /// This function is used to dedicate a port for the web site.
        /// </summary>
        /// <param name="args"> String of arguments.</param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
