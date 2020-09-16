using Exercicio1.Business.Components;
using Exercicio1.Library.Models;
using Exercicio1.Structure.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exercicio1.ConsoleApp
{
    public class Service
    {
        IServiceAPI _service;

        public Service(IServiceAPI _service)
        {
            this._service = _service;
        }

        public async Task Run()
        {
            Console.WriteLine(" -- Ler Arquivo --");
            Console.WriteLine("");

            string path = @"..\..\..\input.csv";

            List<AverageCSV> list = FileComponent.ReadCSVFile(path);
            foreach (var item in list)
                Console.WriteLine($"{item.Name} - {item.City} - {item.Age}");

            Console.WriteLine("");
            Console.WriteLine(" -- Media dos dados --");
            Console.WriteLine("");
            AverageModelDTO model = AverageComponent.Average(list);

            foreach (var item in model.Averages)
                Console.WriteLine($"{item.City}, {item.Age}");

            Console.WriteLine("");
            Console.WriteLine(" -- Enviar dados --");
            Console.WriteLine("");

            string url_api = "https://zeit-endpoint.brmaeji.now.sh/api/avg";
            var response = await _service.SendAVG(url_api, model);

            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync();

                Console.WriteLine(content.Result);
            }
        }
    }
}
