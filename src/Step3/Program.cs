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
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            var appConfig = config.GetSection("application").Get<Application>();;

            Console.WriteLine($"Application Name : {appConfig.Name}");
        }
    }
}