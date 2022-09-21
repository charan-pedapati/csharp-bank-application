using System;
namespace BankApplication

{
    class BankApplicationMain
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Welcome to Vardhani Bank!");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("=> Creating a new bank account for you");
            Console.WriteLine("=> Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("=> Your Father Name:");
            string fatherName = Console.ReadLine();
            Console.WriteLine("=> Your Address:");
            string address = Console.ReadLine();
            Console.WriteLine("=> Your Mobile Number:");
            string mobile = Console.ReadLine();
            Console.WriteLine("=> Initial Depostit (Must be a positive Value!):");
            string balance = Console.ReadLine();
            Console.WriteLine("Processing Request...");
            Console.WriteLine("");
            Console.WriteLine("=> Bank Account Created!");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Name             :   "+name);
            Console.WriteLine("Father's Name    :   "+fatherName);
            Console.WriteLine("Address          :   "+address);
            Console.WriteLine("Mobile           :   "+mobile);
            Console.WriteLine("Current Balance  :   "+balance);
            Console.WriteLine("Account Number   :   32435734725");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");

            Console.WriteLine("=> Please enter operation you want to perform:");
            Console.WriteLine("   1. Withdrawl\n   2. Balance Check\n   3. Add Money (Deposit)");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
        }
    }
}