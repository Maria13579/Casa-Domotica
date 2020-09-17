using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa_Domotica
{
    class Menu
    {
        private int op = 0;
        public int Listamenu()
        {

            Console.WriteLine("-----------Control Remoto-----------");
            Console.WriteLine("1. Encender Luz Sala");
            Console.WriteLine("2. Apagar Luz Sala");
            Console.WriteLine("4. Encender Televisor");
            Console.WriteLine("5. Apagar Televisor");
            Console.WriteLine("6. Abrir Garage ");
            Console.WriteLine("7. Medio abrir Garage");
            Console.WriteLine("8. Cerrar Garage");
            Console.WriteLine("9. Cortina 1 ");
            Console.WriteLine("10. Cortina 2");
            Console.WriteLine("11. Cortina 3");
            Console.WriteLine("12. Cortina 4");
            Console.WriteLine("13. Cortina 5");
            Console.WriteLine("14. Luz estudio 1");
            Console.WriteLine("15. Luz estudio 2");
            Console.WriteLine("16. Luz estudio 3");
            Console.WriteLine("17. Luz estudio 4");
            Console.WriteLine("18. Luz estudio 5");
            Console.WriteLine("19. Salir");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Digite el numero de opcion: ");
            try
            {
                op = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ingrese valores numericos...");
            }

            return op;


        }
    }
}
