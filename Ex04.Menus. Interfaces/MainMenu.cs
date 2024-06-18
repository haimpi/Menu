using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly SubMenu r_MainMenu;

        public MainMenu(string i_MainMenuName)
        {
            r_MainMenu = new SubMenu(i_MainMenuName, true);
        }

        public void AddItem(params MenuItem[] i_ItemToAdd)
        {
            r_MainMenu.AddItem(i_ItemToAdd);
        }

        public void Show()
        {
            Console.Clear();
            r_MainMenu.Show();
        }
    }
}