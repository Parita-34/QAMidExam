using System;

namespace PreWorkMidTerm
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoiceString = "";
            int userChoiceInt = 0;
            Program p = new Program();
            do
            {
                Console.WriteLine("1. Enter Screen Dimensions");
                Console.WriteLine("2. Exit");
                userChoiceString = Console.ReadLine();
            } while (!int.TryParse(userChoiceString, out userChoiceInt) || (userChoiceInt < 1 || userChoiceInt > 2));

            switch (userChoiceInt)
            {
                case 1:
                    p.userEnteredData();
                    break;

                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

            Console.ReadKey();
        }


        public void userEnteredData()
        {
            string heightString = "";
            string widthString = "";
            string diagnolString = "";
            int heightInt = 0;
            int widthInt = 0;
            double diagnolDouble = 0;

            do
            {
                Console.Write("Please Enter Height =");
                heightString = Console.ReadLine();
            } while (!int.TryParse(heightString, out heightInt) || !(heightInt > 0));

            do
            {
                Console.Write("Please Enter Width =");
                widthString = Console.ReadLine();
            } while (!int.TryParse(widthString, out widthInt) || !(heightInt > 0));

            do
            {
                Console.Write("Please Enter Diagnol =");
                diagnolString = Console.ReadLine();
            } while (!double.TryParse(diagnolString, out diagnolDouble) || !(heightInt > 0));

            PixelCal.ppiCalculation(heightInt, widthInt, diagnolDouble);
        }
    }
}

