
namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;
            float result = 0;
            string answer;
            Console.WriteLine("Hello, welcome to the program calculator!");
            Console.WriteLine("Please enter your first number");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication or any other key for division");
            answer = Console.ReadLine().ToLower();
            if (answer == "a")
            {
                result = num1 + num2;

            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;

            }
            else
            {
                result = num2 == 0 ? float.NaN : num1 / num2; //Use Not a Number
            }
            if (float.IsNaN(result))

            {
                Console.WriteLine("Cannot divide by 0");
            }
            Console.WriteLine("The result is " + result);
            Console.WriteLine("Thank you for using the calcualtor program");
            Console.ReadKey();
        }
    }
}
