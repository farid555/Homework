using System;

namespace exercise_100
 {
    public class Debt // create class
    {
        private double balance;
        private double interestRate;

        public Debt (double initialBalance, double initialInterestRate) //Constructor
        {
            this.balance = initialBalance;
            this.interestRate = initialInterestRate;
        }
        public void PrintBalance () {
            Console.WriteLine (this.balance); // it'll show me the money
        }
        public void WaitOneYear () {
            this.balance = this.balance * interestRate; //debt is increased by multiplying the balance by the interest rate
        }

    }
}