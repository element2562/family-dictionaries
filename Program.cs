using System;
using System.Collections.Generic;
namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){ 
                {"name", "Krista"},
                {"age", "42"}
            });
            myFamily.Add("brother", new Dictionary<string,string>() {
                {"name", "Colton"},
                {"age", "25"}
            });

            foreach (var item in myFamily)
            {
                Console.WriteLine($"{item.Value["name"]} is my {item.Key} and is {item.Value["age"]}");
            }

        }
    }
}
