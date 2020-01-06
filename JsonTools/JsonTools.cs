using System;
using System.Collections.Generic;
using System.Text.Json;

namespace JsonTools
{
        /*===========================================================================================
         * This class will be used to deserialize any JSON string to any object
         * of your choice.
         * OR
         * To Serialize any object of your choice into an JSON string
         * Written BY Theo Uys 6 JAN 2020 
          ===========================================================================================*/
        public class JsonTools<T>
        {
        /*===========================================================================================
        * This method will desrialize a json string into an object
        * How to use it:
        * Make sure you include this class library as a reference to your project, first compile this
        * to an dll then reference the dll to your project.
        * JsonTools myjson = new JsonTools<Product> //Where Product is your C# class
        * myjson.Deserialize(your_json_string); //Will return a List of IEnumerable List of your Product 
        * class.
        * 
        * I use a class define in my project called Product as an example.
        * 
        * Example:
        * public IEnumerable<Product> GetProducts()
        {
            JsonTools<Product> retObject = new JsonTools<Product>();
            string myjsontxt = File.OpenText(JsonFileName).ReadToEnd();
            return retObject.Deserialize(myjsontxt);
              
        }
          ===========================================================================================*/
        public IEnumerable<T> Deserialize(string JsonString)
            {

                return JsonSerializer.Deserialize<T[]>(JsonString,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }); 

            }
        }
}
