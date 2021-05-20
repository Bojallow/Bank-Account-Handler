namespace Bank {
    class Account {
        private double totalAmount = 0;

        public Account() {}
        
        ~Account() {}

        static void Main(string[] args) {
            System.Console.WriteLine("Welcome to the bank!");
            Account acc = new Account();
            string ans;

            do {
                System.Console.Write("Would you like to deposit or withdraw? ");
                ans = System.Console.ReadLine().ToLower();
            } while((ans != "deposit") && (ans != "withdraw") && (ans != "no"));

            if(ans == "deposit") {
                acc.Deposit();
            } else if(ans == "withdraw") {
                acc.Withdraw();
            } else {
                System.Console.WriteLine("We are transfering you to the Hacked Accounts Department.");
                Info info = new Info();
                info.HowHacked = info.HowHacked();
                System.Console.WriteLine(info.HowHacked);
            }
        }

        /*
         * adds user's inputed value to totalAmount
         * 
         * @param 
         * @return
         */
        private void Deposit() {
            System.Console.Write("How much money would you like to deposit? ");
            totalAmount += System.Convert.ToDouble(System.Console.ReadLine());
        }

        private void Withdraw() {
            System.Console.Write("How much money would you like to withdaw? ");
            double wd = System.Convert.ToDouble(System.Console.ReadLine());

            if(wd > totalAmount) {
                System.Console.WriteLine("You do not have enough money.");
            } else {
                totalAmount -= wd;
            }  
        }
    }

    class HackedAccount {
        public HackedAccount() {}

        ~HackedAccount() {} 

        public string HowHacked() {
            System.Console.WriteLine("How was your account hacked? ");
            return System.Console.ReadLine();
        }
    }
    
    class Info : HackedAccount {
        private string howHacked;

        public string HowHacked {
            get { return howHacked; }
            set { howHacked = value; }
        }
    }
}
