using HW2Task_2;

class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();

        Client client1 = new Client("John", "Doe");
        Client client2 = new Client("Jane", "Smith");

        Account account1 = new Account(new Money(1000, 0), 0.05);
        Account account2 = new Account(new Money(2000, 0), 0.03);
        Account account3 = new Account(new Money(500, 0), 0.04);

        bank.OpenAccount(client1, account1);
        bank.OpenAccount(client1, account2);
        bank.OpenAccount(client2, account3);

        bank.AddClient(client1);
        bank.AddClient(client2);

        Console.WriteLine($"Total balance for {client1.FirstName} {client1.LastName}: {client1.GetTotalBalance()}");
        Console.WriteLine($"Total balance for {client2.FirstName} {client2.LastName}: {client2.GetTotalBalance()}");

        Console.WriteLine("\nAll clients and their accounts:");
        foreach (var client in bank.GetAllClients())
        {
            Console.WriteLine($"Client: {client.FirstName} {client.LastName}");
            Console.WriteLine("Accounts:");
            foreach (var account in client.Accounts)
            {
                Console.WriteLine($"    Balance: {account.Balance.Amount}");
            }
        }
    }
}
