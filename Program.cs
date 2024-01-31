// See https://aka.ms/new-console-template for more information


namespace LogInApp
{
  class Program
  {
    static string newUser;
    static string newPassword;

    static void Main(string[] args)
    {
        
       
        Register();
        Login();
        Console.Read();
    }

    public static void Register()
    {
        Console.WriteLine("Please, create your account. Type your username and press enter:");
        newUser = Console.ReadLine();

        Console.WriteLine("Please, set up your new password and press enter:");
        newPassword = Console.ReadLine();

        Console.WriteLine("Thank you for registering us us.");
        Console.WriteLine("---------------------------------");
    }
    public static void Login()
    {
      Console.WriteLine("Please, enter your username:");
        if(newUser == Console.ReadLine())
        {

        Console.WriteLine($"Welcome, {newUser} Type your password:");
       
          if(newPassword == Console.ReadLine())
          {
            Console.WriteLine($"Hello, {newUser}, you are logged in.");
          }else
          {
            Console.WriteLine($"Sorry, {newUser}, the password you typed does not match");
          }
        }else
        {
          Console.WriteLine("Sorry, the username you typed does not match");
        }
    }
  }
}
