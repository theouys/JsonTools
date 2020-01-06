using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using JsonTools;

namespace ConsoleApp1
{
    class Program
    {
        public class mytest
        {
            public string Name { get; set; }
            public string SurName { get; set; }
        }
        static void Main(string[] args)
        {
            mytest m = new mytest();
            m.Name = "Theo";
            m.SurName = "Uys";

            List<mytest> m2 = new List<mytest>();
            m2.Add(m);

            string jsonString;
            jsonString = JsonSerializer.Serialize(m2);
            
            //jsonString = "[" + jsonString + "]";

           


            Console.Write(jsonString);



            IEnumerable<mytest> menum;
            JsonTools<mytest> retObject = new JsonTools<mytest>();

            menum =  retObject.Deserialize(jsonString);
            Console.ReadKey();

        }
    }
}
