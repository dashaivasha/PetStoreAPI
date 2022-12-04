using Newtonsoft.Json;
using PetStore6.Api.Models;
using System.IO;

namespace PetStore6.TestData
{
    public class JsonManager
    {
        public static TestDetails GetTestData()
        {
            var json = File.ReadAllText(Globals.DataPath);
            var data = JsonConvert.DeserializeObject<TestDetails>(json);

            return data;
        }

        public static Pet GetPetFromJson()
        {
            var json = File.ReadAllText(Globals.PetPath);
            Pet pet = JsonConvert.DeserializeObject<Pet>(json);

            return pet;
        }

        public static Order GetOrderFromJson()
        {
            var json = File.ReadAllText(Globals.OrderPath);
            Order order = JsonConvert.DeserializeObject<Order>(json);

            return order;
        }
    }
}
