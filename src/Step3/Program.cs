using System;
using System.IO;
using FizzBuzz.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Binder;
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // You could either use this 
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Or this approach to get your configuration
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            // Then get your values using this approach
            var appConfig = builder.GetSection("application").Get<Application>();;

            Console.WriteLine($"Application Name : {appConfig.Name}");
        }
    }
}