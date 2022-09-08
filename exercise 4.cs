namespace exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the speed limit?");
            int speedLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("What was the speed of the car?");
            double carSpeed = double.Parse(Console.ReadLine());
            if (carSpeed <= speedLimit)
            { Console.WriteLine("ok");
            }
            double overLimit = (carSpeed - speedLimit);
            double failurePoint = overLimit / 5;
            if (carSpeed > speedLimit)
                for (double i = failurePoint; i <= overLimit; )
                {
                    Console.WriteLine("failure point increased by 1");
                    i = i + 5;
                }
            Console.WriteLine("total failure points: {0}", failurePoint);
            if (failurePoint >= 12)
            {
                Console.WriteLine("driver's license suspended");
            }
        }
    }
}