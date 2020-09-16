using Exercicio1.Library.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Exercicio1.Business.Components
{
    public class FileComponent
    {
        public static List<AverageCSV> ReadCSVFile(string location)
        {
            try
            {
                List<AverageCSV> list = new List<AverageCSV>();

                string[] readText = File.ReadAllLines(location);
                foreach (var item in readText)
                {
                    list.Add(new AverageCSV { Name = item.Split(',')[0], City = NormalizeString.ToLowerWithOutAcents(item.Split(',')[1]), Age = int.Parse(item.Split(',')[2]) });
                }

                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
