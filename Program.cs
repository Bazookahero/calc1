using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace calculator
{
    internal class Program
    {
        public void CalcAddition()
        {
            Console.WriteLine("Please write a number you want something added to");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please write a number you want to add to {0}", number1);
            double number2 = double.Parse(Console.ReadLine());
            double answer = number1 + number2;
            Console.WriteLine("the answer is: {0}", answer);

        }
        public void CalcSubtraction()
        {
            Console.WriteLine("Please write a number you want something subtracted from");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please write a number you want to subtract {0} with", number1);
            double number2 = double.Parse(Console.ReadLine());
            double answer = number1 - number2;
            Console.WriteLine("the answer is: {0}", answer);

        }
        public void CalcMultiplication()
        {
            Console.WriteLine("Please write a number you want to multiply");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please write a number you want to multiply {0} with", number1);
            double number2 = double.Parse(Console.ReadLine());
            double answer = number1 * number2;
            Console.WriteLine("the answer is: {0}", answer);

        }
        public void CalcDivision()
        {
            Console.WriteLine("Please write a number you want divided");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please write a number you want to divide {0} with", number1);
            double number2 = double.Parse(Console.ReadLine());
            while (number2 == 0)
            {
                Console.WriteLine("Please do not try to divide by 0");
                Console.WriteLine("Please write a number you want to divide {0} with", number1);
                number2 = double.Parse(Console.ReadLine());
            }
            double answer = number1 / number2;
            Console.WriteLine("the answer is: {0}", answer);

        }
        static void Main(string[] args)
        {
            int i = 0;
            while (i != 9)
            {


                Console.WriteLine("-------------Calculator-------------");
                Console.WriteLine("enter the selection you want to do");
                Console.WriteLine("Press 1 for addition");
                Console.WriteLine("Press 2 for subtraction");
                Console.WriteLine("Press 3 for multiplication");
                Console.WriteLine("Press 4 for division");
                Console.WriteLine("Press 9 to exit the calculator");
                i = int.Parse(Console.ReadLine());
                Program calc = new Program();


                switch (i)
                {
                    case 1:
                        calc.CalcAddition();
                        break;
                    case 2:
                        calc.CalcSubtraction();
                        break;
                    case 3:
                        calc.CalcMultiplication();
                        break;
                    case 4:
                        calc.CalcDivision();
                        break;
                    case 9:
                        break;
                }


                {
                }

            }
        }
    }
}