using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class InterfaceUsage
    {
        public void RunInterfaceUsage()
        {
            MainMenu mainMenu = new MainMenu("Interface MainMenu");
            SubMenu showDateTime = new SubMenu("Show Date/Time");
            SubMenu versionAndCapitals = new SubMenu("Version and Capitals");
            ActionMenuItem showDateMethod = new ActionMenuItem("Show Date", new ShowDate());
            ActionMenuItem showTimeMethod = new ActionMenuItem("Show Time", new ShowTime());
            ActionMenuItem countCapitalsMethod = new ActionMenuItem("Count Capitals", new CountCapitals());
            ActionMenuItem versionMethod = new ActionMenuItem("Show Version", new ShowVersion());

            mainMenu.AddItem(showDateTime, versionAndCapitals);
            showDateTime.AddItem(showDateMethod, showTimeMethod);
            versionAndCapitals.AddItem(countCapitalsMethod, versionMethod);
            mainMenu.Show();
        }
    }
}