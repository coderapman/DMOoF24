using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MenuSys2
{
    internal class MenuItem
    {
        public string Title { get; set; }

        public MenuItem(string Title)
        {
            this.Title = Title;
        }
    }
}
