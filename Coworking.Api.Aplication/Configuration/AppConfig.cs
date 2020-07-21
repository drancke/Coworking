using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.Aplication.Configuration
{
   public class AppConfig : IAppConfig
    {
        private readonly IConfiguration _configuration;

        public AppConfig(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public int MaxTrys => int.Parse(_configuration.GetSection("Polly:MaxTry").Value);
        public int Time => int.Parse(_configuration.GetSection("Polly:Time").Value);
        public string ServiceUrl => (_configuration.GetSection("ServiceUrl:Url").Value);
    }
}
