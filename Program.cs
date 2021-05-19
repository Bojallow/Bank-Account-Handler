namespace Bank {

    class Account {
        private double totalAmount = 0;

        static void Main(string[] args) {
            System.Console.WriteLine("Welcome to the bank!");
            Account acc = new Account();
            string ans;
            System.Console.WriteLine(acc.totalAmount);

            do {
                System.Console.Write("Would you like to deposit or withdraw? ");
                ans = System.Console.ReadLine().ToLower();
            } while((ans != "deposit") && (ans != "withdraw"));

            if(ans == "deposit") {
                acc.deposit();
            } else if(ans == "withdraw") {
                acc.withdraw();
            }
        }

        private void deposit() {
            System.Console.Write("How much money would you like to deposit? ");
            totalAmount += System.Convert.ToDouble(System.Console.ReadLine());
        }

        private void withdraw() {
            System.Console.Write("How much money would you like to withdaw? ");
            double wd = System.Convert.ToDouble(System.Console.ReadLine());

            if(wd > totalAmount) {
                System.Console.WriteLine("You do not have enough money.");
            } else {
                totalAmount -= wd;
            }  
        }
    }
}