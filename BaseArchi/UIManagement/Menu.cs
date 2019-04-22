using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseArchi.UIManagement
{
    abstract class Menu
    {
        string MenuTitle { get; set; }

        public Menu(string _menuTitle)
        {
            MenuTitle = _menuTitle;
        }


    }
}
