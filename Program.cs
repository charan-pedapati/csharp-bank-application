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
            AccountDetails bankAccount = new AccountDetails();
            bankAccount.CreateBankAccount();
            Console.WriteLine("\n~~~~~~~~~~~ MAIN MENU ~~~~~~~~~~~~");
            string option = "0";
            do{
                Console.WriteLine("");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("");
                Console.WriteLine("=> Please enter the operation you want to perform:");
                Console.WriteLine("   1. Withdrawl\n   2. Balance Check\n   3. Add Money (Deposit)\n   4. Create new Bank Account");
                Console.WriteLine("Press (y) to exit...");
                Console.WriteLine("");
                Console.WriteLine("----------------------------------");
                option = Console.ReadLine() ?? "";
                switch(option)
                {
                    case "y":
                    {
                        break;
                    }

                    case "1":
                    {
                        bankAccount.WithdrawAmount();
                        break;
                    }

                    case "2":
                    {
                        bankAccount.GetBankBalance();
                        break;
                    }
                    case "3":
                    {
                        bankAccount.DepositAmount();
                        break;
                    }
                }
                

            

            }while(option!="y");
            
        }
 
    }

    

        
    }


