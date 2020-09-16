using Exercicio1.Library.Models;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio1.Business.Components
{
    public class AverageComponent
    {
        public static AverageModelDTO Average(List<AverageCSV> model_csv)
        {
            AverageModelDTO model = new AverageModelDTO();

            model.Averages =
            (from people in model_csv
             group people by people.City into peopleGroup
             select new AverageDTO
             {
                 City = peopleGroup.Key,
                 Age = decimal.Round(peopleGroup.Average(x => x.Age), 2),
             }).ToList();

            return model;
        }
    }
}
