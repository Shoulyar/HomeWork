using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Task_2
{
    public class Bank
    {
        public List<Client> Clients { get; }
        public List<Account> Accounts { get; }

        public Bank()
        {
            Clients = new List<Client>();
            Accounts = new List<Account>();
        }

        public void AddClient(Client client)
        {
            Clients.Add(client);
        }

        public void OpenAccount(Client client, Account account)
        {
            client.AddAccount(account);
            Accounts.Add(account);
        }

        public List<Account> GetAllAccounts()
        {
            return Accounts;
        }

        public List<Client> GetAllClients()
        {
            return Clients;
        }
    }
}
