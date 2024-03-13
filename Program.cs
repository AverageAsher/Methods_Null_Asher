namespace Methods_Null_Asher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Multiplication method
            int result = Multiply(5, 3);
            Console.WriteLine("Multiplication result: " + result);

            // Welcome method
            WelcomeUser();

            // Ask for user's name
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            // Greet user
            GreetUser(userName);

            // Farewell method
            Farewell();
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static void WelcomeUser()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static void GreetUser(string name)
        {
            Console.WriteLine("Hello, " + name + "! It is nice to meet you!");
        }

        static void Farewell()
        {
            Console.WriteLine("Have a fantastic day!");
        }
    }
}