using System;

namespace exercise_100
 {
    public class Debt // create class
    {
        private double blance;
        private double interestRate;

        public Debt (double initialBalance, double initialInterestRate) //Constructor
        {
            this.blance = initialBalance;
            this.interestRate = initialInterestRate;
        }
        public void PrintBalance () {
            Console.WriteLine (this.blance); // it'll show me the money
        }
        public void WaitOneYear () {
            this.blance = this.blance * interestRate; //debt is increased by multiplying the balance by the interest rate
        }

    }
}