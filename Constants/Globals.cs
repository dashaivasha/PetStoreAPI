using System.IO;

namespace PetStore6
{
    static class Globals
    {
        public static readonly string PetPath = Path.Combine("TestData", "Pet.json");
        public static readonly string OrderPath = Path.Combine("TestData", "Order.json");
        public static readonly string DataPath = Path.Combine("TestData", "TestData.json");
    }
}
