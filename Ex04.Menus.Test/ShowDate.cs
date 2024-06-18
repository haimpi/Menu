using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class ShowDate : IExecute
    {
        public void Execute()
        {
            ShowCurrentDate();
        }

        public static void ShowCurrentDate()
        {
            Console.WriteLine($"Current date: {DateTime.Now:yyyy-MM-dd}\n");
        }
    }
}