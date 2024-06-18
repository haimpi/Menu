using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public delegate void SelectItemInvoker();

    public class TaskMenu : MenuItem
    {
        public event SelectItemInvoker ExecutedTask;

        public TaskMenu(string i_MenuItem, SelectItemInvoker i_OnSelectItem) : base(i_MenuItem)
        {
            ExecutedTask += i_OnSelectItem;
        }

        protected virtual void OnSelectedTheTask()
        {
            ExecutedTask?.Invoke();
        }

        public override void Show()
        {
            OnSelectedTheTask();
        }
    }
}