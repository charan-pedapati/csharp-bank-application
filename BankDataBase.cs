class BankDataBase{
    AccountDetails[]? bankAccounts;
    static int index = 0;
    public void AddBankAccountToDataBase(AccountDetails bankAccount)
    {
        this.bankAccounts[index] = bankAccount;
        index+=1;
    }

    public void DisplayBankAccounts()
    {
        Console.WriteLine("=> Confidential Information. Please Enter PIN to proceed:");
        string? PIN = Console.ReadLine();
        if (PIN=="0000")
        {   Console.WriteLine("PIN Validated Successfully. Displaying Accounts in Bank Database...\n\n");
            Console.WriteLine("--------------------------------\n");
            int i=0;
            int length = this.bankAccounts.Count()  ;
            for (i = 0; i < length; i++)
            {
                Console.WriteLine("Name     :   ",this.bankAccounts[i].userName);
                Console.WriteLine("Acc No   :   ",this.bankAccounts[i].bankAccountNumber);
                Console.WriteLine("Balance  :   ",this.bankAccounts[i].bankBalance);
                Console.WriteLine("\n");

            }
        }

        else{
            Console.WriteLine("Wrong PIN. Authorization Failed.");
        }

    }
}
