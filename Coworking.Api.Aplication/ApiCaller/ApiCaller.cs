using Coworking.Api.Aplication.Configuration;
using Coworking.Api.Application.Contracts.ApiCaller;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.Aplication.ApiCaller
{
   public class ApiCaller : IApiCaller
    {
        private readonly HttpClient httpClient;
        private readonly IAppConfig _appConfig;

        //public ApiCaller(IAppConfig appConfig)
        //{
        //    httpClient = new HttpClient {
        //        BaseAddress =  new Uri(appConfig.ServiceUrl),

        //    };

        //    httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers
        //        .MediaTypeWithQualityHeaderValue(  "application/json"));
        //}


        //public async Task<T>  GetServiceResponse<T>(int id)
        //{
        //    var response = await httpClient.GetAsync(id.ToString());

        //    if (!response.IsSuccessStatusCode)
        //    {
        //        return default(T);
        //    }
        //    var result = await response.Content.ReadAsStringAsync();

        //    return JsonConvert.DeserializeObject<T>(result);

        //}



    }
}
