using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class ShowTime : IExecute
    {
        public void Execute()
        {
            ShowCurrentTime();
        }

        public static void ShowCurrentTime()
        {
            Console.WriteLine("The hour is: " + DateTime.Now.ToString("HH:mm:ss\n"));
        }
    }
}