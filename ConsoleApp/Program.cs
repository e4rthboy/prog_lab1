using System;
using Classes.Repositories;

namespace ConsoleApp
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var toyRepository = new ToyRepository();
            var milkRepository = new MilkRepository();
            
            var showMenu = true;

            while (showMenu)
            {
                try
                {
                    showMenu = MainMenu(toyRepository, milkRepository);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                }
            }
        }
        
        private static bool MainMenu(ToyRepository toyRepository, MilkRepository milkRepository)
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Добавить игрушку");
            Console.WriteLine("2) Показать список игрушек");
            Console.WriteLine("3) Найти игрушку по ID");
            Console.WriteLine("4) Добавить молочный продукт");
            Console.WriteLine("5) Показать список молочных продуктов");
            Console.WriteLine("6) Найти молочную продукцию по ID");
            Console.WriteLine("");
            Console.WriteLine("7) Выход");
            Console.Write("\r\nВыберите вариант: ");
 
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Введите наименование");
                    var name = InputHelper.StringInput();
                    
                    Console.WriteLine("Введите артикул");
                    var vendorCode = InputHelper.StringInput();
                    
                    Console.WriteLine("Введите материал игрушки");
                    var material = InputHelper.StringInput();
                    
                    Console.WriteLine("Введите цвет игрушки");
                    var color = InputHelper.StringInput();
                    
                    Console.WriteLine("Игрушка мягкая?");
                    var isSoft = InputHelper.BoolInput();
                    
                    toyRepository.Save(name, vendorCode, material, color, isSoft);
                    
                    return true;
                case "2":
                    var list = toyRepository.GetList();
                    Console.WriteLine($"Количество элементов: {list.Count}");
                    
                    foreach (var item in toyRepository.GetList())
                    {
                        Console.WriteLine(item);
                    }
                    
                    Console.ReadKey();
                    return true;
                case "3":
                    var id = InputHelper.IntInput();
                    Console.WriteLine(toyRepository.GetById(id));
                    Console.ReadKey();
                    return true;
                case "4":
                    Console.WriteLine("Введите наименование");
                    var _name = InputHelper.StringInput();
                    
                    Console.WriteLine("Введите артикул");
                    var _vendorCode = InputHelper.StringInput();

                    Console.WriteLine("Введите тип упаковки");
                    var type = InputHelper.StringInput();
                    
                    Console.WriteLine("Тип упаковки");
                    var packageType = InputHelper.StringInput();
                    
                    Console.WriteLine("Введите дату срока годности");
                    var date = InputHelper.DateTimeInput();
                    
                    Console.WriteLine("Введите количество калорий");
                    var calorieAmount = InputHelper.IntInput();
                    
                    Console.WriteLine("Введите жирность");
                    var fat = InputHelper.DoubleInput();
                    
                    Console.WriteLine("Введите объем");
                    var size = InputHelper.DoubleInput();
                    
                    Console.WriteLine("Содержит лактозу? (1, 0)");
                    var hasLactose = InputHelper.BoolInput();
                    
                    milkRepository.Save(_name, _vendorCode, packageType, date, calorieAmount, fat, size, hasLactose);
                    return true;
                case "5":
                    var milkList = milkRepository.GetList();
                    Console.WriteLine($"Количество элементов: {milkList.Count}");
                    
                    foreach (var item in milkList)
                    {
                        Console.WriteLine(item);
                    }
                    
                    Console.ReadKey();
                    return true;
                case "6":
                    var milkId = InputHelper.IntInput();
                    
                    Console.WriteLine(milkRepository.GetById(milkId));
                    Console.ReadKey();
                    return true;
                case "7":
                    return false;
                default:
                    return true;
            }
        }
    }
}