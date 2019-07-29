using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBAnkingProject {
    public class MoneyMarket : Account {

        public double MMRate { get; set; } = 0.03;

        
            public void PayInterest(int months) {
                    double interestTobePaid =
                    this.MMRate / 12 * months * (double)this.GetBalance();
            
                decimal intTobePaidAsDecimal = (decimal)interestTobePaid;
                this.Deposit(intTobePaidAsDecimal);
                  }
                                                         
            /*
            public double IntRate { get; set; } = 0.03;

            public void PayInterest(decimal amountofInterest) {
                this.Deposit(amountofInterest);
            }
            public decimal CalcInterest(int months) {
                double interestTobePaid =
                    this.IntRate / 12 * months * (double)this.GetBalance();//the (double) is CAST. Temp change to type for GetBalance
                return (decimal)interestTobePaid;
            }*/

        }
}
