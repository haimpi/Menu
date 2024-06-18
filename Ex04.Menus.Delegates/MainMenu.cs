using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private readonly SubMenu r_MainMenu;
        
        public MainMenu(string i_MenuName)
        {
            r_MainMenu = new SubMenu(i_MenuName, true);
        }

        public void AddItem(params MenuItem[] i_ItemsToAdd)
        {
            r_MainMenu.AddItem(i_ItemsToAdd);         
        }

        public void Show()
        {
            r_MainMenu.Show();
        }
    }
}