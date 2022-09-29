using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crystal_store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            int crystals;
            int crystalCost = 10;

            Console.WriteLine("Добро пожаловать в магазин кристаллов! Только сегодня один кристалл стоит " + crystalCost + " золота. Сколько у вас его есть?");
            money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Хорошо, какое количество кристаллов вам надо?");
            crystals = Convert.ToInt32(Console.ReadLine());
            money -= crystals * crystalCost;

            Console.WriteLine("После покупки у вас в сумке " + money + " монет и " + crystals + " кристаллов");
            Console.ReadKey();
        }
    }
}
