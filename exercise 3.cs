namespace exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter the height of the image:");
            double height = double.Parse(Console.ReadLine());
            Console.Write("please enter the width of the image:");
            double width = double.Parse(Console.ReadLine());
            if (height > width)
            {
                Console.WriteLine("the image is a portrait");
            }
            else
            { Console.WriteLine("the image is a landscape");
            };

        }
    }
}