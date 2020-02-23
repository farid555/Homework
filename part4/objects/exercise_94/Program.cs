using System;

namespace exercise_94
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
      Account heikkisAccount = new Account ("Heikki's account", 1000.00);
      heikkisAccount.Withdrawal (100);
      
      Account personalAccount = new Account ("Personal account", 0.00);
      personalAccount.Deposit (100);

      Console.WriteLine (heikkisAccount);
      Console.WriteLine (personalAccount);

      //new_account.Deposit (20);
      //Console.WriteLine (new_account.balance);

      /* Account heikkisSwissAccount = new Account ("Heikki's account in Switzerland", 1000000.00);

      Console.WriteLine ("Intial state");
      Console.WriteLine (heikkisAccount);
      Console.WriteLine (heikkisSwissAccount);

      heikkisAccount.Withdrawal (20);
      Console.WriteLine ("The balance of Heikki's account is now: " + heikkisAccount.balance);
      heikkisSwissAccount.Deposit (200);
      Console.WriteLine ("The balance of Heikki's other account is now: " + heikkisSwissAccount.balance);

      Console.WriteLine ("End state");
      Console.WriteLine (heikkisAccount);
      Console.WriteLine (heikkisSwissAccount); */

    }
  }
}



