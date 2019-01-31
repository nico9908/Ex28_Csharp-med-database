using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28
{
    class Program
    {
        Menu menu = new Menu();

        static void Main(string[] args)
        {
            Program pro = new Ex28.Program();
            pro.Run();
        }

        private void Run()
        {
            menu.RunMenu();
        }
    }
}
