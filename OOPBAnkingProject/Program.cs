using System;

namespace OOPBAnkingProject {
    class Program {

        static void Main(string[] args) {

            Account acct = new Account();// creates a new account instance with Default Constructor
            acct.Number = "1001";    //establishes a property as an instance using the 'variable.property name'
            acct.Name = "Test Account";//we have just established the three properties
            acct.Deposit(10);//always begin the line with the variable
            acct.Withdraw(10);
            decimal balance = acct.GetBalance();
            Console.WriteLine($"Account Balance is {balance} (should be 10)");//added the (should be 10) to verify result
            acct.Deposit(-10);
            balance = acct.GetBalance();
            Console.WriteLine($"Account Balance is {balance} (should be 10)");
        }
    }
}
