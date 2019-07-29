using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBAnkingProject {
    public class Savings: Account {// the : Account means that the Account Class in inherited to Savings.  
                                   //All 'Public' from Account is available
        public double IntRate { get; set; } = 0.03;

        public void  PayInterest(decimal amountofInterest) {
            this.Deposit(amountofInterest);
        }
        public decimal CalcInterest(int months) {
            double interestTobePaid = 
                this.IntRate / 12 * months * (double)this.GetBalance();//the (double) is CAST. Temp change to type for GetBalance
            return (decimal) interestTobePaid;
        }



    }
}
