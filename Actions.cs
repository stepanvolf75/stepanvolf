using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    internal class Actions
    {
    // výběr akce
    public void VyberAkce()
        {
            string Akce = Console.ReadLine();
            switch (Akce)
            {
             case "1":
                    AddClient();
                    break;
            case "2":
                    WriteAllClients();
                    break;
            case "3":
                    SearchClient();
                    break;
            case "4":
                    break;
             default:
                    Console.WriteLine("Neplatná akce, vyberte 1-4.");
                    VyberAkce();
                    break;
            }
        }

        // přidání pojištěného
        public void AddClient()
        {
            Console.WriteLine("\nZadejte jméno pojištěného:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení pojištěného:");
            string LastName = Console.ReadLine();
            Console.WriteLine("Zadejte věk pojištěného:");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte telefonní číslo pojištěného:");
            String PhoneNumber = Console.ReadLine();
            Console.WriteLine("Zadejte číslo pojištění pojištěného:");
            string InsuranceNumber = Console.ReadLine();
            Client Client = new Client(FirstName, LastName, Age, PhoneNumber, InsuranceNumber);
            Client.ListOfClients.Add(Client);
            ShowStartScreen();
        }

        // vyhledání pojištěného
        public void SearchClient()
        {
            Console.WriteLine("\nZadejte jméno pojištěného:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení pojištěného:");
            string LastName = Console.ReadLine();
            foreach (Client Client in Client.ListOfClients)
            {
                if (FirstName == Client.FirstName && LastName == Client.LastName)
                    Console.WriteLine(Client.ToString());
            }
            ShowStartScreen(); 
        }

        // výpis všech pojištěných
        public void WriteAllClients()
        {
            foreach (Client Client in Client.ListOfClients)
            {
                Console.WriteLine(Client.ToString());
            }            
            ShowStartScreen();
        }

        // návrat na úvodní obrazovku
        public void ShowStartScreen() 
        {
            Console.WriteLine("\nData byla uložena. Pokračujte libovolnou klávesou.");
            Console.ReadKey();
            StartScreen StartScreen = new StartScreen();
            StartScreen.ShowStartScreenText();
            VyberAkce();
        }
    }
}

