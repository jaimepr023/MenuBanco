using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYListas.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public string afirmacion()
        {
            Console.WriteLine("¿Estas seguro que quieres darte de baja?. Elija la opcion si para continuaor, de lo contrario especifique la opcion no");
            string afirmacion = Console.ReadLine();
            return afirmacion;
        }


        public void mensajeBienvenida()
        {
            string afirmacion;
            Console.WriteLine("Bienvenido/a, al banco de españa.\n");
            
        }

        public int menu()
        {
            int opcionseleccionada;
            Console.WriteLine("Elija la opcion que usted quiera:");
            Console.WriteLine("·····································");
            Console.WriteLine("Opcion 0. Cerrar menu");
            Console.WriteLine("Opcion 1. Darse de alta");
            Console.WriteLine("Opcion 2. Darse de baja");
            Console.WriteLine("Opcion 3. Interactuar con la cuenta");
            Console.WriteLine("·····································");
            opcionseleccionada = Console.ReadKey(true).KeyChar - ('0');
            return opcionseleccionada;
        }

    }
}
