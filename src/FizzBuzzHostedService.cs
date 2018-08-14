using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using FizzBuzz.Models;

namespace FizzBuzz
{
    public class FizzBuzzHostedService : IHostedService
    {
        private readonly IOptions<Application> _config;
        public FizzBuzzHostedService(IOptions<Application> config)
        {
            _config = config;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            var name = _config.Value.Name;
            var poo = _config.Value.Modulos;

            throw new System.NotImplementedException();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}