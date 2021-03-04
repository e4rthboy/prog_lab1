using System;

namespace ConsoleApp
{
    public static class InputHelper
    {
        public static int IntInput()
        {
            if (int.TryParse(Console.ReadLine(),out var number))
            {
                return number;
            }

            return 0;
        }
        
        public static double DoubleInput()
        {
            if (double.TryParse(Console.ReadLine(), out var number))
            {
                return number;
            }

            return 0;
        }
        
        public static bool BoolInput()
        {
            if (bool.TryParse(Console.ReadLine(), out var number))
            {
                return number;
            }

            return false;
        }


        public static string StringInput()
        {
            return Console.ReadLine() ?? "Отсутствует";
        }

        public static DateTime DateTimeInput()
        {
            Console.WriteLine("Введите год");
            int year = IntInput();
            
            Console.WriteLine("Введите месяц (число)");
            int month = IntInput();
            
            Console.WriteLine("Введите день");
            int day = IntInput();

            var dateTime = new DateTime(year, month, day);

            return dateTime;
        }
    }
}