using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class ShowVersion : IExecute
    {
        public void Execute()
        {
            ShowVersionMethod();
        }

        public static void ShowVersionMethod()
        {
            Console.WriteLine("Version 24.1.4.9633\n");
        }
    }
}