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
            int moneyCount;
            int crystalsCount;
            int crystalCost = 10;
            Console.WriteLine("Добро пожаловать в магазин кристаллов! Только сегодня один кристалл стоит " + crystalCost + " золота. Сколько у вас его есть?");
            moneyCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Хорошо, какое количество кристаллов вам надо?");
            crystalsCount = Convert.ToInt32(Console.ReadLine());
            moneyCount -= crystalsCount * crystalCost;
            Console.WriteLine("После покупки у вас в сумке " + moneyCount + " монет и " + crystalsCount + " кристаллов");
            Console.ReadKey();
        }
    }
}
