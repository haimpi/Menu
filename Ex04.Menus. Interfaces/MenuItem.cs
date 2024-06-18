using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem : IExecute
    {
        private readonly string r_MenuItemName;

        protected MenuItem(string i_MenuName) 
        {
            r_MenuItemName = i_MenuName;
        }

        public abstract void Execute();

        public string MenuItemName
        {
            get { return r_MenuItemName; }
        }
    }
}