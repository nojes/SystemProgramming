using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using App.Entities;
using Good = App.Models.Good;

namespace App
{
    class Program
    {
        private static readonly ShopContext Context = new ShopContext();

        static void Main(string[] args)
        {
            Console.WindowWidth = 100;
            Console.WindowHeight = 50;

            Func<int, int, List<Good>> action = GetGoods;

            IAsyncResult asyncResult = action.BeginInvoke(1, 1, ShowGoods, null);
            List<Good> goods = action.EndInvoke(asyncResult);

            foreach (Good good in goods) {
                Console.WriteLine(good);
            };
           

            Console.ReadKey();
        }

        private static void MainAction()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine(MethodBase.GetCurrentMethod());
            }
        }

        private static void ShowGoods(IAsyncResult asyncResult)
        {
            MainAction();
        }

        static List<Good> GetAllGoods()
        {
            return Context.Database.SqlQuery<Good>("exec dbo.GetGoods")
                .ToList();
        }

        static List<Good> GetGoods(int manufacturerId)
        {
            return Context.Database.SqlQuery<Good>($"exec dbo.GetGoods {manufacturerId}")
                .ToList();
        }

        static List<Good> GetGoods(int manufacturerId, int categoryId)
        {
            return Context.Database.SqlQuery<Good>($"exec dbo.GetGoods {manufacturerId}, {categoryId}")
                .ToList();
        }
    }
}
