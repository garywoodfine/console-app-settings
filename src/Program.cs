using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using FizzBuzz.Models;


namespace FizzBuzz
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var host = new HostBuilder()
                .Build();

            await host.RunAsync();
        }


    }
}
