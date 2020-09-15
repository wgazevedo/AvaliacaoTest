using Exercicio1.Library.Models;
using Exercicio1.Structure.Service;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.ServiceAPI
{
    public class ServiceAPI : IServiceAPI
    {
        public async Task<HttpResponseMessage> SendAVG(string url, AverageModelDTO model)
        {
            using HttpClient client = new HttpClient();
            var jsonContent = JsonConvert.SerializeObject(model);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            contentString.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return await client.PostAsync(url, contentString);
        }
    }
}
