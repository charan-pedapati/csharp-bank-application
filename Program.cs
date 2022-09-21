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
                Console.WriteLine("   1. Withdrawl\n   2. Balance Check\n   3. Add Money (Deposit)");
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

                    case "2":
                    {
                        bankAccount.GetBankBalance();
                        break;
                    }
                }
                

            

            }while(option!="y");
            
        }

        static int MakeDeposit()
        {
            Console.WriteLine("~~~~~ Amount Deposit ~~~~~~");
            Console.WriteLine("=> Enter the amount you want to add in your account:");
            // depositAmount = Console.ReadLine();
            return 0;

        }

    
    }

    public class AccountDetails{
        public string bankAccountNumber="1234";
        public int bankBalance=0;
        public void CreateBankAccount()
        {   
            Console.WriteLine("=> Creating a new bank account for you");
            Console.WriteLine("=> Your Name:");
            string? name = Console.ReadLine();
            Console.WriteLine("=> Your Father Name:");
            string? fatherName = Console.ReadLine();
            Console.WriteLine("=> Your Address:");
            string? address = Console.ReadLine();
            Console.WriteLine("=> Your Mobile Number:");
            string? mobile = Console.ReadLine();
            Console.WriteLine("=> Initial Deposit (Must be a positive Value!):");
            // ! Implement try except statement if we give non integer value here.
            string balance = Console.ReadLine() ?? "";
            Console.WriteLine("Processing Request...");
            // --------------------------------------------
            string dateAndTime = DateTime.Now.ToString();
            string accountNumber = dateAndTime.Replace("-","").Replace(" ","").Replace(":","").Substring(0,10);
            this.bankAccountNumber = accountNumber;
            this.bankBalance = Convert.ToInt32(balance);
            // ---------------------------------------------
            Console.WriteLine("");
            Console.WriteLine("=> Bank Account Created!");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Name             :   "+name);
            Console.WriteLine("Father's Name    :   "+fatherName);
            Console.WriteLine("Address          :   "+address);
            Console.WriteLine("Mobile           :   "+mobile);
            Console.WriteLine("Current Balance  :   "+balance);
            Console.WriteLine("Account Number   :   "+accountNumber);
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            
            
        }

        public void GetBankBalance()
        {
            Console.WriteLine("\n\n\n Your Current Bank Balance is: "+this.bankBalance+"/-\n\n\n");
        }
    }
}