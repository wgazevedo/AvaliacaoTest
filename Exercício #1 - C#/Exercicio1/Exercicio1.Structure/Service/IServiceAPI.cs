using Exercicio1.Library.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Exercicio1.Structure.Service
{
    public interface IServiceAPI
    {
        /// <summary>
        /// Post average model to API
        /// </summary>
        /// <param name="url">Endpoint aplication</param>
        /// <param name="model">Model Average list</param>
        /// <returns>Result response message</returns>
        Task<HttpResponseMessage> SendAVG(string url, AverageModelDTO model);
    }
}
