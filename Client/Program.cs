namespace Client
{
    using Data;
    using Newtonsoft.Json;
    using Simple.OData.Client;
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var client = new ODataClient("http://localhost:5000/");

            var users = client
                .For<Users>()
                .Top(2)
                .FindEntriesAsync().Result;

            Console.WriteLine(JsonConvert.SerializeObject(users));

            Console.ReadKey();
        }
    }
}
