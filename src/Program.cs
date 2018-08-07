using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;


namespace FizzBuzz
{
    class Program
    {

        public static IConfiguration Configuration { get; set; }
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
           
           
            Console.WriteLine(Configuration.GetSection("application")["name"]);




        }
    }
}
