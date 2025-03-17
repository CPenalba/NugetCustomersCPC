using Newtonsoft.Json;
using NugetCustomersCPC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NugetCustomersCPC.Services
{
    public class ServiceCustomers
    {

        public async Task<CustomersList> GetCustomerListAsync()
        {
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            //COPIAMOS LA URL COMPLETA PARA LOS CUSTOMERS
            string url = "https://northwind-api.miloudi.dev/v1/customers";
            string dataJson = await client.DownloadStringTaskAsync(url);
            CustomersList clients = JsonConvert.DeserializeObject<CustomersList>(dataJson);
            return clients;        }
    }
}
