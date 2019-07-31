using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBAnkingProject {

    public abstract class Account {//marking it 'abstract' prevents it from being instantiated

        public string Number { get; set; }
        private decimal Balance { get; set; } = 0;
        public  string Name { get; set; }
        public bool IsActive { get; set; } = true;

        abstract public void Save();

        public virtual string Print() {//added virtual on this line before the TYPE and enter override on the MoneyMarket and Savings Print lines
            return $"{this.Number}  | {this.Balance}  |  {this.Name}";

        }

        public bool TransferTo(Account ToAccount, decimal Amount) {
            bool success = this.Withdraw(Amount);//If success is true, then deposit the transfer
            if (success) {
                ToAccount.Deposit(Amount);
                return true;
            }
            return false;
        }

        public bool Deposit (decimal Amount) {
            if (Amount <= 0) {
                Console.WriteLine($"Deposit Amount must be GT zero");
            }
            else {
                this.Balance += Amount;
                return true;
            }
            return false;
        }
        public bool Withdraw(decimal Amount) {
            if (Amount <= 0) {
                Console.WriteLine("Withdraw must be GT zero");
                return false;
            }
            else {

                if (this.Balance >= Amount) {
                    this.Balance -= Amount;
                    return true;
                }
            }
            return false;
        }
        public decimal GetBalance() {
            return this.Balance;
        }


    }
}
