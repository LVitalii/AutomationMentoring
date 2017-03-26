using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    public class Bank
    {
        public Bank()
        {
            accounts = new Dictionary<int, int>();
        }

        private Dictionary<int, int> accounts;

        public void PutMoneyToAccount(IHashId accountHolder, int quantity)
        {
            int q = 0;

            if (accounts.TryGetValue(accountHolder.Id, out q))
            {
                accounts[accountHolder.Id] = q + quantity;
                Console.WriteLine("Money were added to existed account");
            }
            else
            {
                accounts.Add(accountHolder.Id, quantity);
                Console.WriteLine("No active account was found. So a new one is created and money were added to it");
            }

            Console.WriteLine("Account balance is: " + GetAccountBalance(accountHolder));
        }

        public void GetMoneyFromAccount(IHashId accountHolder, int quantity)
        {
            int q = 0;

            if (accounts.TryGetValue(accountHolder.Id, out q))
            {
                accounts[accountHolder.Id] = q - quantity;
                Console.WriteLine("Money were substracted from existed account");
            }
            else
            {
                Console.WriteLine("No active account was found. So there is nothing to get from");
            }

            Console.WriteLine("Account balance is: " + GetAccountBalance(accountHolder));
        }

        public int GetAccountBalance(IHashId accountHolder)
        {
            try
            {
                return accounts[accountHolder.Id];
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine("There is no existed account for this client");
                return 0;
            }
                        
        }

    }
}
