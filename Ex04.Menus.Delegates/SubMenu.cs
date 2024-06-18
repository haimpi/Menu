using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        private readonly Dictionary<int, MenuItem> r_MenuItems;
        private readonly StringBuilder r_MenuTextBuilder;
        private readonly string r_BackOrExit;
        private const int k_ExitKeyNumber = 0;
        private int m_DictionaryKey = 1;

        public SubMenu(string i_MenuName, bool i_IsMainMenu = false) : base(i_MenuName) 
        {
            r_MenuItems = new Dictionary<int, MenuItem>();
            r_MenuTextBuilder = new StringBuilder();
            r_BackOrExit = i_IsMainMenu ? "Exit" : "Back";
        }

        private void showCurrentMenu()
        {
            int itemNumber = 1;
            int minKey = r_MenuItems.Keys.Min();
            int maxKey = r_MenuItems.Keys.Max();

            r_MenuTextBuilder.Clear();
            r_MenuTextBuilder.AppendLine($"**{MenuItemName}**");
            r_MenuTextBuilder.AppendLine("-----------------------------");
            foreach (KeyValuePair<int, MenuItem> menuItem in r_MenuItems)
            {
                r_MenuTextBuilder.AppendLine($"{itemNumber++} -> {menuItem.Value.MenuItemName}");
            }

            r_MenuTextBuilder.AppendLine($"0 -> {r_BackOrExit}");
            r_MenuTextBuilder.AppendLine("-----------------------------");
            r_MenuTextBuilder.AppendLine($"Enter your request: ({minKey} to {maxKey}) or press '0' to {r_BackOrExit}.");
            Console.WriteLine(r_MenuTextBuilder.ToString());
        }

        public override void Show()
        {
            do
            {
                showCurrentMenu();
                int userChoice = getUserInput();

                Console.Clear();
                if (userChoice == k_ExitKeyNumber)
                {
                    break;
                }

                if (r_MenuItems.TryGetValue(userChoice, out MenuItem selectedItem))
                {
                    selectedItem.Show(); 
                }

            } while (true);
        }

        private int getUserInput()
        {
            int userChoice;

            while (!int.TryParse(Console.ReadLine(), out userChoice) || !r_MenuItems.ContainsKey(userChoice)
                   && userChoice != k_ExitKeyNumber)
            {
                Console.WriteLine("Invalid input. Please try again.");
            }

            return userChoice;
        }

        public void AddItem(params MenuItem[] i_ItemsToAdd)
        {
            foreach (MenuItem item in i_ItemsToAdd)
            {
                r_MenuItems.Add(m_DictionaryKey++, item);
            }
        }
    }
}