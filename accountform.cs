using System;

namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      // Variables
      string password, ct, username, mail, details;

      // Continue Prompt
      Console.Write("Welcome!\nTo set up a account you will need to fill small form\n\nContinue? (Y / N)");
      ct = Convert.ToString(Console.ReadLine());

      // Informations Set
        if(ct == "Y") {
          // Username
          Console.Write("Please type your Username: \n");
          username = Convert.ToString(Console.ReadLine());
          Console.WriteLine();
          // Mail
          Console.Write("Please type your mail: \n");
          mail = Convert.ToString(Console.ReadLine());
          Console.WriteLine();
          // Password
          Console.Write("Set your password: \n");
          password = Convert.ToString(Console.ReadLine());
          Console.WriteLine();
          // Setting Up End Info
          Console.Write("You are one step ahead to make your account! \n\n");
          // Show Prompt 
          Console.Write("Do you want to see your account details? (Y / N)");
          details = Convert.ToString(Console.ReadLine());
          if(details == "Y") {
            Console.WriteLine("--------------------");
            Console.WriteLine($"\tUsername: {username}");
            Console.WriteLine($"\tMail: {mail}");
            Console.WriteLine($"\tPassword: {password}");
            Console.WriteLine("--------------------\n");
            Console.WriteLine("Account Made!");
          } else {
            Console.WriteLine("Account Made!");
        }
      }
      if(ct == "N") {
          Console.WriteLine("Account making declined");
        }
    }
  }
}
