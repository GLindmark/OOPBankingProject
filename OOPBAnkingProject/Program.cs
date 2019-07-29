using System;

namespace OOPBAnkingProject {
    class Program {

        static void Main(string[] args) {

            Savings sav = new Savings();
            sav.Number = "1002";//the .Number is available, but is not in the Savings Class.  That is because it is inherited from Account
            sav.Name = "Savings 1";

            sav.Deposit(20);
            sav.Withdraw(10);

            decimal savbal = sav.GetBalance();
            Console.WriteLine($"Saving balance is {savbal}");



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
