using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetCustomersCPC.Models
{
    public class CustomersList
    {
        [JsonProperty("data")]
        public List<Customer> Customers { get; set; }
    }
}
