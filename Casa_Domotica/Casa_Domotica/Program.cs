using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;

namespace Casa_Domotica
{
    class Program
    {
        static casa app = new casa();
        static Menu m = new Menu();

        static void Main(string[] args)
        {

            int opciones = 0;
            while (opciones != 18)
            {
                opciones = m.Listamenu();

                if (opciones == 1)
                {
                    app.Enviardato("q");
                }
                if (opciones == 2)
                {
                    app.Enviardato("w");
                }
                if (opciones == 3)
                {
                    app.Enviardato("e");
                }
                if (opciones == 4)
                {
                    app.Enviardato("r");
                }
                if (opciones == 5)
                {
                    app.Enviardato("t");
                }
                if (opciones == 6)
                {
                    app.Enviardato("y");
                }
                if (opciones == 7)
                {
                    app.Enviardato("u");
                }
                if (opciones == 8)
                {
                    app.Enviardato("0");
                    app.Enviardato("5");
                }
                if (opciones == 9)
                {
                    app.Enviardato("1");
                    app.Enviardato("6");
                }
                if (opciones == 10)
                {
                    app.Enviardato("2");
                    app.Enviardato("7");
                }
                if (opciones == 11)
                {
                    app.Enviardato("3");
                    app.Enviardato("8");
                }
                if (opciones == 12)
                {
                    app.Enviardato("4");
                    app.Enviardato("9");
                }
                if (opciones == 13)
                {
                    app.Enviardato("i");
                }
                if (opciones == 14)
                {
                    app.Enviardato("o");
                }
                if (opciones == 15)
                {
                    app.Enviardato("p");
                }
                if (opciones == 16)
                {
                    app.Enviardato("a");
                }
                if (opciones == 17)
                {
                    app.Enviardato("s");
                }
            }
        }
    }
}
