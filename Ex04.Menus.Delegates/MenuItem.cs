using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        private readonly string r_MenuItemName;

        protected MenuItem(string i_MenuItemName)
        {
            r_MenuItemName = i_MenuItemName;
        }

        public string MenuItemName
        {
           get { return r_MenuItemName; }
        }

        public abstract void Show();
    }
}