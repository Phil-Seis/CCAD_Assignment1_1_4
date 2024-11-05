namespace CCAD_Assignment1_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to print the result of dividing two numbers.
            
            Console.WriteLine("Please type in two numbers below: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            double diff = Convert.ToDouble(num1 / num2);
            Console.WriteLine("The difference of your two numbers is: " + diff);
        }
    }
}
