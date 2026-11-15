using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> computers = new List<PC>()
            {
                new PC() {Article = 123, Name = "Иволга", Type = "Центральный", Frequency = 2.2, OZU = 16, SSD = 825, GPU = 2, Price = 120, Quantity = 22},
                new PC() {Article = 456, Name = "Рассвет", Type = "Графический", Frequency = 3.3, OZU = 32, SSD = 500, GPU = 4, Price = 220, Quantity = 13},
                new PC() {Article = 789, Name = "Пересвет", Type = "Графический", Frequency = 2.5, OZU = 32, SSD = 665, GPU = 4, Price = 310, Quantity = 2},
                new PC() {Article = 101, Name = "Эльбрус", Type = "Центральный", Frequency = 4.2, OZU = 64, SSD = 1024, GPU = 4, Price = 400, Quantity = 15},
                new PC() {Article = 111, Name = "Дождь", Type = "Центральный", Frequency = 2.6, OZU = 16, SSD = 200, GPU = 2, Price = 80, Quantity = 54},
                new PC() {Article = 132, Name = "Иволга", Type = "Графический", Frequency = 3.2, OZU = 32, SSD = 100, GPU = 3, Price = 150, Quantity = 33}
            };

            #region все компьютеры с указанным процессором

            Console.WriteLine("Введите имя процессора:");
            string name = Console.ReadLine();

            List<PC> pcs1 = computers
                .Where(x => x.Name == name)
                .ToList();

            Print(pcs1);

            #endregion

            #region все компьютеры с объемом ОЗУ не ниже, чем указано

            Console.WriteLine("Введите объем ОЗУ в ГБ:");
            int ozu = Convert.ToInt32(Console.ReadLine());

            List<PC> pcs2 = computers
                .Where(x => x.OZU >= ozu)
                .ToList();

            Print(pcs2);

            #endregion

            #region список, отсортированный по увеличению стоимости

            List<PC> pcs3 = computers
                .OrderBy(x => x.Price)
                .ToList();

            Print(pcs3);

            #endregion

            #region список, сгруппированный по типу процессора

            IEnumerable<IGrouping<string, PC>> pcs4 = computers.GroupBy(x => x.Type);

            foreach (IGrouping<string, PC> pcs in pcs4)
            {
                Console.WriteLine($"Тип процессора: {pcs.Key}.");

                foreach (PC pc in pcs)
                {
                    Console.WriteLine($"\nАртикул процессора: {pc.Article}.\n" +
                        $"Имя компьютера: {pc.Name}.\n" +
                        $"Тип процессора: {pc.Type}.\n" +
                        $"Частота процессора, ГГц: {pc.Frequency}.\n" +
                        $"Объем ОЗУ, ГБ: {pc.OZU}.\n" +
                        $"Объем SSD, ГБ: {pc.SSD}.\n" +
                        $"Объем GPU, ГБ: {pc.GPU}.\n" +
                        $"Цена компьютера, тыс.руб: {pc.Price}.\n" +
                        $"В наличии, шт: {pc.Quantity}.\n");
                }
            }

            #endregion

            #region самый дорогой компьютер

            PC pcMax = computers.OrderByDescending(x => x.Price)
                .FirstOrDefault();

            Console.WriteLine("Самый дорогой компьютер:");
            Console.WriteLine($"\nАртикул процессора: {pcMax.Article}.\n" +
                        $"Имя компьютера: {pcMax.Name}.\n" +
                        $"Тип процессора: {pcMax.Type}.\n" +
                        $"Частота процессора, ГГц: {pcMax.Frequency}.\n" +
                        $"Объем ОЗУ, ГБ: {pcMax.OZU}.\n" +
                        $"Объем SSD, ГБ: {pcMax.SSD}.\n" +
                        $"Объем GPU, ГБ: {pcMax.GPU}.\n" +
                        $"Цена компьютера, тыс.руб: {pcMax.Price}.\n" +
                        $"В наличии, шт: {pcMax.Quantity}.\n");

            #endregion

            #region самый бюджетный компьютер

            PC pcMin = computers.OrderBy(x => x.Price)
                .FirstOrDefault();

            Console.WriteLine("Самый бюджетный компьютер:");
            Console.WriteLine($"\nАртикул процессора: {pcMin.Article}.\n" +
                        $"Имя компьютера: {pcMin.Name}.\n" +
                        $"Тип процессора: {pcMin.Type}.\n" +
                        $"Частота процессора, ГГц: {pcMin.Frequency}.\n" +
                        $"Объем ОЗУ, ГБ: {pcMin.OZU}.\n" +
                        $"Объем SSD, ГБ: {pcMin.SSD}.\n" +
                        $"Объем GPU, ГБ: {pcMin.GPU}.\n" +
                        $"Цена компьютера, тыс.руб: {pcMin.Price}.\n" +
                        $"В наличии, шт: {pcMin.Quantity}.\n");

            #endregion

            #region есть ли хотя бы один компьютер в количестве не менее 30 штук

            bool isActive = computers.Any(x => x.Quantity >= 30);

            if (isActive)
            {
                Console.WriteLine("Да, имеется.");
            }

            else
            {
                Console.WriteLine("Нет, не имеется.");
            }

            #endregion

            void Print(List<PC> pcs)
            {
                foreach (PC pc in pcs)
                {
                    Console.WriteLine($"\nАртикул процессора: {pc.Article}.\n" +
                        $"Имя компьютера: {pc.Name}.\n" +
                        $"Тип процессора: {pc.Type}.\n" +
                        $"Частота процессора, ГГц: {pc.Frequency}.\n" +
                        $"Объем ОЗУ, ГБ: {pc.OZU}.\n" +
                        $"Объем SSD, ГБ: {pc.SSD}.\n" +
                        $"Объем GPU, ГБ: {pc.GPU}.\n" +
                        $"Цена компьютера, тыс.руб: {pc.Price}.\n" +
                        $"В наличии, шт: {pc.Quantity}.\n");
                }
            }

            Console.WriteLine("\nДля выхода нажмите любую клавишу:");
            Console.ReadKey();
        }
    }
}