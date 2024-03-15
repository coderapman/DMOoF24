using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MenuSys2
{
    internal class Menu
    {
        public string title;
        public MenuItem[] menuitem;
        public int itemcount;   

        public Menu(string title) 
        { 
            this.title = title;
            this.menuitem = new MenuItem[100];
            this.itemcount = 0;
        }

        public void AddMenuItem(string item)
        {
            this.menuitem[itemcount] = new MenuItem(item);
            itemcount++;
        }

        public void show()
        {
            Console.WriteLine(this.title);
            Console.WriteLine("=================");
            for (int n = 0; n < this.itemcount; n++) 
            {
                Console.WriteLine(this.menuitem[n].Title);
            }
        }

        public MenuItem Choose()
        {
            int theChoice = 0;
            do
            {
                Console.WriteLine("Vælge et punkt på menuen: fra 1 til " + this.itemcount);
                string v = Console.ReadLine();
                theChoice = int.Parse(v);
            } while (theChoice > this.itemcount);
            Console.WriteLine("Du valgte: " + this.menuitem[theChoice - 1].Title);
            return this.menuitem[theChoice-1];
        }
    }
}
