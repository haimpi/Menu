using Ex04.Menus.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class DelegateUsage
    {
        public void RunDelegateUsage()
        {
            MainMenu mainMenu = new MainMenu("Delegates MainMenu");
            SubMenu dateTimeSubMenu = new SubMenu("Show Date/Time");
            SubMenu versionAndCapitalsSubMenu = new SubMenu("Version and Capitals");

            dateTimeSubMenu.AddItem(new TaskMenu("Show Date", ShowDate.ShowCurrentDate));
            dateTimeSubMenu.AddItem(new TaskMenu("Show Time", ShowTime.ShowCurrentTime));
            versionAndCapitalsSubMenu.AddItem(new TaskMenu("Count Capitals", CountCapitals.CountCapitalsLetters));
            versionAndCapitalsSubMenu.AddItem(new TaskMenu("Show Version", ShowVersion.ShowVersionMethod));
            mainMenu.AddItem(dateTimeSubMenu, versionAndCapitalsSubMenu);
            mainMenu.Show();
        }
    }
}