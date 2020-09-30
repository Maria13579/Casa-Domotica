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
                Console.Clear();
                if (opciones == 1)
                {
                    app.Enviardato("q");
                    Console.WriteLine("Luz Sala Encendida");
                }
                if (opciones == 2)
                {
                    app.Enviardato("w");
                    Console.WriteLine("Luz Sala Apagada");
                }
                if (opciones == 3)
                {
                    app.Enviardato("e");
                    Console.WriteLine("Televisor Encendido");
                }
                if (opciones == 4)
                {
                    app.Enviardato("r");
                    Console.WriteLine("Televisor Apagado");
                }
                if (opciones == 5)
                {
                    app.Enviardato("t");
                    Console.WriteLine("Garage Completamente Abierto");
                }
                if (opciones == 6)
                {
                    app.Enviardato("y");
                    Console.WriteLine("Garage Medio Abierto");
                }
                if (opciones == 7)
                {
                    app.Enviardato("u");
                    Console.WriteLine("Garage Completamente Cerrado");
                }
                if (opciones == 8)
                {
                    app.Enviardato("0");
                    app.Enviardato("5");
                    Console.WriteLine("Cortinas Primera Posición");
                }
                if (opciones == 9)
                {
                    app.Enviardato("1");
                    app.Enviardato("6");
                    Console.WriteLine("Cortinas Segunda Posición");
                }
                if (opciones == 10)
                {
                    app.Enviardato("2");
                    app.Enviardato("7");
                    Console.WriteLine("Cortinas Tercera Posición");
                }
                if (opciones == 11)
                {
                    app.Enviardato("3");
                    app.Enviardato("8");
                    Console.WriteLine("Cortinas Cuarta Posición");
                }
                if (opciones == 12)
                {
                    app.Enviardato("4");
                    app.Enviardato("9");
                    Console.WriteLine("Cortinas Quinta Posición");
                }
                if (opciones == 13)
                {
                    app.Enviardato("i");
                    Console.WriteLine("Luz Estudio Primera Intensidad");
                }
                if (opciones == 14)
                {
                    app.Enviardato("o");
                    Console.WriteLine("Luz Estudio Segunda Intensidad");
                }
                if (opciones == 15)
                {
                    app.Enviardato("p");
                    Console.WriteLine("Luz Estudio Tercera Intensidad");
                }
                if (opciones == 16)
                {
                    app.Enviardato("a");
                    Console.WriteLine("Luz Estudio Cuarta Intensidad");
                }
                if (opciones == 17)
                {
                    app.Enviardato("s");
                    Console.WriteLine("Luz Estudio Apagada");
                }
            }
        }
    }
}
