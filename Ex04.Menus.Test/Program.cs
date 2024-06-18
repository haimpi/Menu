﻿using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            InterfaceUsage interfaceUsageTest = new InterfaceUsage();
            DelegateUsage delegateUsageTest = new DelegateUsage();

            interfaceUsageTest.RunInterfaceUsage();
            delegateUsageTest.RunDelegateUsage();
        }
    }
}