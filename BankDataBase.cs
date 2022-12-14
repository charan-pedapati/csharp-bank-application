class BankDataBase{
    static int index = 0;
    public AccountDetails[] bankAccounts = new AccountDetails[10];
    public void AddBankAccountToDataBase(AccountDetails bankAccount)
    {   this.bankAccounts[index] = new AccountDetails();
        this.bankAccounts[index] = bankAccount;
        index+=1;
    }

    public void DisplayBankAccounts()
    {
        Console.WriteLine("=> Confidential Information. Please Enter PIN to proceed:");
        string? PIN = Console.ReadLine();
        if (PIN=="0000")
        {   Console.WriteLine("\n=> PIN Validated Successfully. Displaying Accounts in Bank Database...");
            Console.WriteLine("--------------------------------\n");
            int i=0;
            while(this.bankAccounts[i]!= null)
            {
                Console.WriteLine("-> Name             :   "+this.bankAccounts[i].userName);
                Console.WriteLine("-> Account Number   :   "+this.bankAccounts[i].bankAccountNumber);
                Console.WriteLine("-> Current Balance  :   "+this.bankAccounts[i].bankBalance+"/- INR");
                Console.WriteLine("-> Address          :   "+this.bankAccounts[i].address);
                Console.WriteLine("-> Mobile           :   "+this.bankAccounts[i].mobile);
                i+=1;
                Console.WriteLine("\n");

            }
        }

        else{
            Console.WriteLine("Wrong PIN. Authorization Failed.");
        }

    }
}
