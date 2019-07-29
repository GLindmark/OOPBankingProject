using System;

namespace OOPBAnkingProject {
    class Program {

        static void Main(string[] args) {

            MoneyMarket monm = new MoneyMarket();
            monm.Number = "1003";
            monm.Name = "MoneyMarket 1";
            monm.MMRate = .1;

            monm.Deposit(2000);
            monm.Withdraw(1000);
            monm.PayInterest(12);

            Console.WriteLine($"MoneyMarket Balance is {monm.GetBalance()}");



            //Savings sav = new Savings();
            //sav.Number = "1002";//the .Number is available, but is not in the Savings Class.  That is because it is inherited from Account
            //sav.Name = "Savings 1";
            //sav.IntRate = .05;

            //sav.Deposit(200);
            //sav.Withdraw(100);
            //decimal interestTobePaid = sav.CalcInterest(6);//number of months of interest
            //sav.PayInterest(interestTobePaid);
            //decimal savbal = sav.GetBalance();
            //Console.WriteLine($"Saving balance is {savbal}");

            ////sav.Deposit(10);//always begin the line with the variable
            //sav.Withdraw(10);
            //decimal balance = sav.GetBalance();
            //Console.WriteLine($"Account Balance is {balance} (should be 10)");//added the (should be 10) to verify result

            //sav.Deposit(200);
            //balance = sav.GetBalance();
            //Console.WriteLine($"Account Balance is {balance} (should be 10)");

            //sav.Withdraw(100);
            //balance = sav.GetBalance();
            //Console.WriteLine($"Account Balance is {balance} (should be 10)");

            //sav.Withdraw(35);
            //balance = sav.GetBalance();
            //Console.WriteLine($"Account Balance is {balance}");



            /*
                        Account acct = new Account();// creates a new account instance with Default Constructor
                        acct.Number = "1001";    //establishes a property as an instance using the 'variable.property name'
                        acct.Name = "Test Account";//we have just established the three properties

                        acct.Deposit(10);//always begin the line with the variable
                        acct.Withdraw(10);
                        decimal balance = acct.GetBalance();
                        Console.WriteLine($"Account Balance is {balance} (should be 10)");//added the (should be 10) to verify result

                        acct.Deposit(-10);
                        balance = acct.GetBalance();
                        Console.WriteLine($"Account Balance is {balance} (should be 10)");*/
        }
    }
}
