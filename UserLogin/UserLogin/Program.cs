namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {
            string userName = "lunanera";
            int password = 16111999;
            while (true)
            {
                Console.WriteLine("Please enter your user name and password for login...");

                Console.Write("User name: ");
                string enteredUserName = Console.ReadLine();

                Console.Write("Password: ");
                int enteredpassword = 0;
                
                int.TryParse(Console.ReadLine(), out enteredpassword);

                if (enteredUserName == userName)
                {
                    Console.WriteLine("Your user name is correct");
                    if (enteredpassword == password)
                    {
                        Console.WriteLine("Login successful...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your user name is correct but your password is wrong...");
                    }

                }
                else
                {
                    Console.WriteLine("Your user name is wrong...");
                }
            }
            Console.ReadLine();


        }
    }
}