public class AccountDetails{
        public string bankAccountNumber="1234";
        public int bankBalance=0;
        public string userName = "1234";
        public string PIN = "0000";
        public string address = "XXYY";
        public string fatherName = "1234";

        public string mobile = "7384738943";
        public void CreateBankAccount()
        {   
            Console.WriteLine("=> Creating a new bank account for you...");
            Console.WriteLine("=> Your Name:");
            string name = Console.ReadLine() ?? "";
            Console.WriteLine("=> Your Father Name:");
            string? fatherName = Console.ReadLine() ?? "";
            Console.WriteLine("=> Your Address:");
            string? address = Console.ReadLine() ?? "";
            Console.WriteLine("=> Your Mobile Number:");
            string? mobile = Console.ReadLine() ?? "";
            Console.WriteLine("=> Initial Deposit (Must be a positive Value!):");
            // ! Implement try except statement if we give non integer value here.
            string balance = Console.ReadLine() ?? "";
            Console.WriteLine("Enter a PIN: (default is 0000)");
            string PIN = Console.ReadLine() ?? "0000";
            Console.WriteLine("Processing Request...");
            // --------------------------------------------
            string dateAndTime = DateTime.Now.ToString();
            string accountNumber = dateAndTime.Replace("-","").Replace(" ","").Replace(":","").Substring(4,10);
            this.bankAccountNumber = accountNumber;
            this.bankBalance = Convert.ToInt32(balance);
            this.userName = name;
            this.fatherName = fatherName;
            this.address = address;
            this.mobile = mobile;
            this.PIN = PIN;
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

        // This is for Option - 1
        public void DepositAmount(string PIN){
            if (PIN == this.PIN)
            {
                Console.WriteLine("Enter the amount you want to deposit in your bank account:");
                int amount = Convert.ToInt32(Console.ReadLine());
                this.bankBalance+= amount;
                Console.WriteLine("Amount Added Successfully!\n New Bank Balance:"+this.bankBalance+" INR");
            }

            else{
                Console.WriteLine("Authentication Failed. Please input the correct PIN.");
            }
            
        }
        // This is for option - 2
        public void GetBankBalance(string PIN)
        {
            if (PIN == this.PIN)
            {
            Console.WriteLine("\n\n\n Your Current Bank Balance is: "+this.bankBalance+"/-\n\n\n");

            }

            else{
                Console.WriteLine("Authentication Failed. Please input the correct PIN.");
            }


        }

        public void WithdrawAmount(string PIN)
        {   if (PIN == this.PIN)
            {
            Console.WriteLine("\n\n=> Please enter the amount you want to withdraw:");
            int withdrawAmount = Convert.ToInt32(Console.ReadLine());
            if (withdrawAmount>=this.bankBalance)
            {
                Console.WriteLine("Insufficient Funds, try with lesser amount!");
            }
            else{
                this.bankBalance-=withdrawAmount;
                Console.WriteLine("\n=> Amount withdrawn!\n=> Current Balance is: "+this.bankBalance+" INR\n\n");
            }
            }

            else{
                Console.WriteLine("Authentication Failed. Please input the correct PIN.");
            }


        }}