using System;
using RestSharp;

namespace HypeSquad_Console_Tool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "HypeSquad Tool | https://github.com/NotDippe ";

            Console.WriteLine("Choose Badge:");
            Console.WriteLine("Type 1 For Bravery");
            Console.WriteLine("Type 2 For Brillance");
            Console.WriteLine("Type 3 For Balance");

            //Badge String
            string badge = Console.ReadLine();

            Console.Clear();

            //Token string
            Console.WriteLine("Insert your discord token:");
            string token = Console.ReadLine();


            //Requests For Badge
            var client = new RestClient("https://canary.discord.com/api/v9/hypesquad/online"); //API
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", token);
            request.AddHeader("content-type", "application/json");
            request.AddCookie("__dcfduid", "ad494cb358b94f9fba9531dad664dd93");
            request.AddParameter("application/json", "{\"house_id\": " + badge + "}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            //Success
            Console.Clear();
            Console.WriteLine("Badge Changed!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
      

        }
    }
}
