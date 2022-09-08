namespace exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number between 1 and 10");
            int number = int.Parse(Console.ReadLine());
            if (number > 0 && number < 11)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}