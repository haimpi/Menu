using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class ActionMenuItem : MenuItem
    {
        private readonly IExecute r_MenuExecutor;

        public ActionMenuItem(string i_Title, IExecute i_MenuExecutor)
            : base(i_Title)
        {
            r_MenuExecutor = i_MenuExecutor;
        }

        public override void Execute()
        {
            r_MenuExecutor.Execute();
        }
    }
}