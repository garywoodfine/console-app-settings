using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Binder;
using System.Collections.Generic;
using FizzBuzz.Models;


namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json");

            var config = builder.Build();

            var appConfig = config.GetSection("application").Get<Application>();

            Console.WriteLine("Application Name : {appConfig.Name}");
        }


    }
}
