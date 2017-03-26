using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    public static class TasksCollection3
    {
        public static void Execute()
        {
            List<String> clients = new List<string>();
            Dictionary<string, List<string>> purchases = new Dictionary<string, List<string>>();

            do
            {
                Console.WriteLine("Please select one of the following:\n a: Add new client\n b: Show all clients\n c: Login by client\n d: Exit");
                string keyEntered = Console.ReadLine();

                switch (keyEntered)
                {
                    case "a": AddNewClient(clients, purchases); break;
                    case "b": ShowAllClients(clients); break;
                    case "c": WorkByClient(clients, purchases); break;
                    case "d": return;
                    default: Console.WriteLine("Please repeat the selection"); break;

                }

            }
            while (true);
        }


        public static void AddNewClient(List<string> clients, Dictionary<string, List<string>> purchases)
        {
            Console.WriteLine("Enter new client");
            string clientName = Console.ReadLine();
            clients.Add(clientName);
            purchases.Add(clientName, new List<string>());
        }


        private static void ShowAllClients(List<string> clients)
        {
            if (clients.Count == 0)
            {
                Console.WriteLine("There is no clients");
            }
            else
            {
                Console.WriteLine("Clients names are:");
                foreach (string client in clients)
                {
                    Console.WriteLine(client);
                }
            }
        }


        private static void WorkByClient(List<string> clients, Dictionary<string, List<string>> purchases)
        {
            Console.WriteLine("Please select the number of the client (starting from 0) from the list in order to work with:");
            ShowAllClients(clients);
            string choise = Console.ReadLine();
            int choiseNum = 0;
            if (!Int32.TryParse(choise, out choiseNum))
            {
                Console.WriteLine("Wrong number. Ended working with login!");
                return;
            }

            if (choiseNum > clients.Count)
            {
                Console.WriteLine("Client does not exist. Ended working with login!");
                return;
            }

            string client = clients[choiseNum];

            WorkWithPurchase(client, purchases);
        }


        public static void WorkWithPurchase(string client, Dictionary<string, List<string>> purchases)
        {
            do
            {
                Console.WriteLine("Select what to do\n a: buy something\n b: print all purchases\n c: exit");
                string choiseBuy = Console.ReadLine();
                switch (choiseBuy)
                {
                    case "a": BuyAThing(client, purchases); break;
                    case "b": ShowPurcases(client, purchases); break;
                    case "c": return;
                    default: Console.WriteLine("Please, repeat the selection"); break;
                }

            }
            while (true);
        }

        private static void ShowPurcases(string client, Dictionary<string, List<string>> purchases)
        {
            Console.WriteLine("Purchase busket of " + client + " is:");
            foreach (string thing in purchases[client])
            {
                Console.WriteLine(thing);
            }
        }

        private static void BuyAThing(string client, Dictionary<string, List<string>> purchases)
        {
            Console.WriteLine("Enter the thing to buy");
            purchases[client].Add(Console.ReadLine());
        }
    }
}
