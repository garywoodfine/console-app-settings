using System;
using System.IO;
using Microsoft.Extensions.Configuration;

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
           
                       
                       Console.WriteLine($" Hello { config["name"] } !");
        }
    }
}
