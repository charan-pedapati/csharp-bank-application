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
            BankDataBase usersData = new BankDataBase();
            usersData.AddBankAccountToDataBase(bankAccount);
            bankAccount = null;
            Console.WriteLine("\n~~~~~~~~~~~ MAIN MENU ~~~~~~~~~~~~");
            string option = "0";
            do{
                Console.WriteLine("");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("");
                Console.WriteLine("=> Please enter the operation you want to perform:");
                Console.WriteLine("   1. Withdrawl\n   2. Balance Check\n   3. Add Money (Deposit)\n   4. Create new Bank Account\n   5. Display all Users(Bank Employee Only)");
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
                    {   Console.WriteLine("=> Enter the account Number:");
                        string accountNumber = Console.ReadLine() ?? "";
                        Console.WriteLine("=> Enter PIN:");
                        int i =0;
                        string? PIN = Console.ReadLine() ?? "";
                        while (usersData.bankAccounts[i]!=null)
                        {
                            if(usersData.bankAccounts[i].bankAccountNumber == accountNumber)
                            {
                                bankAccount = usersData.bankAccounts[i];
                            }

                            i+=1;
                        }

                         if (bankAccount == null)
                        {
                            Console.WriteLine("=> Requested Bank Account doesn't exist.");
                        }
                        else{
                            bankAccount.WithdrawAmount(PIN); 
                         }
                        break;
                    }

                    case "2":
                    {   Console.WriteLine("=> Enter the account Number:");
                        string accountNumber = Console.ReadLine() ?? "";
                        Console.WriteLine("=> Enter PIN:");
                        string? PIN = Console.ReadLine() ?? "";
                        int i = 0;
                        while (usersData.bankAccounts[i]!=null)
                        {
                            if(usersData.bankAccounts[i].bankAccountNumber == accountNumber)
                            {
                                bankAccount = usersData.bankAccounts[i];
                            }

                            i+=1;
                        }
                        if (bankAccount == null)
                        {
                            Console.WriteLine("=> Requested Bank Account doesn't exist.");
                        }
                        else{
                            bankAccount.GetBankBalance(PIN);
                        }
                        break;
                    }
                    case "3":
                    {   Console.WriteLine("=> Enter the account Number:");
                        string accountNumber = Console.ReadLine() ?? "";
                        Console.WriteLine("=> Enter PIN:");
                        string? PIN = Console.ReadLine() ?? "";
                        if (bankAccount == null)
                        {
                            Console.WriteLine("=> Requested Bank Account doesn't exist.");
                        }
                        else{
                            bankAccount.DepositAmount(PIN);
                        }
                        break;
                    }
                    // Implement Bank Database Scenario here.
                    case "4":
                    {
                        AccountDetails newBankAccount = new AccountDetails();
                        newBankAccount.CreateBankAccount();
                        usersData.AddBankAccountToDataBase(newBankAccount);
                        break;
                    }

                    case "5":
                    {
                        usersData.DisplayBankAccounts();
                        break;
                    }
                }
                

            

            }while(option!="y");
            
        }
 
    }

    

        
    }


