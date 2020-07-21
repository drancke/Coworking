using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.Aplication.Configuration
{
    public interface IAppConfig
    {

        int MaxTrys { get; }
        int Time { get; }
        string ServiceUrl { get; }
    }
}
