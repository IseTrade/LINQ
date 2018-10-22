using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            IEnumerable<string> result = words.FindAll(w => w.Contains("th"));
            foreach (string word in result)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

            List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };
            IEnumerable<string> results = names.Distinct();
            foreach (string name in results)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            //=============================================//

            List<string> listOfGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };
 
            foreach (string setOfGrades in listOfGrades)
            {
                var avgGrade = listOfGrades
                    .Select(grades => grades.Split(','))                    
                    .Select(grades => Array.ConvertAll(grades, int.Parse))
                    .Select(grades => (grades.Sum() - grades.Min()) / (grades.Count() - 1))
                    .Average();
                Console.WriteLine(avgGrade);
            }
            Console.WriteLine("");

            //=============================================================//

            PrintOutFreq("TERRILL");
    Console.ReadLine();
        }

        private static void PrintOutFreq(string strInput)
        {
            //SELECT * FROM strInput WHERE COUNT(x) ORDER BY x ASC
            var charCount = strInput.GroupBy(x => x)
                .Select(x => x.Key + "" + x.Count())
                .OrderBy(x => x);

            string temp = "";
            //List<string> strOutput = new List<string>();
            foreach (string singleChar in charCount)
            {
                temp += singleChar;
                //strOutput.Add(singleChar);
            }
    Console.WriteLine(temp);
        }
    }
}
