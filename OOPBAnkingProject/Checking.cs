using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBAnkingProject {
    class Checking : Account {

        private int lastCheckNumber = 0;//This is a property that is private and the value is set to '0'.

        public bool pay(int CheckNumber, decimal amount) {
            bool success = this.Withdraw(amount);
            if (success) {
                this.lastCheckNumber = CheckNumber;
                return true;
            }
            return false;
        }
        
        public override string Print() {
            return base.Print() + $" | {lastCheckNumber}";
        }
    }
}
    
