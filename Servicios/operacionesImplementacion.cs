using ClasesYListas.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClasesYListas.Servicios
{
    internal class operacionesImplementacion : operacionesInterfaz
    {
       private ClienteDto crearCliente()
        {
            Console.WriteLine("Dame tu ID");
            long IDCliente = Int64.Parse(Console.ReadLine());
            Console.WriteLine("Dame tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Dame tu apellido completo");
            string apellido = Console.ReadLine();
            Console.WriteLine("Dame tu DNI");
            string DNI = Console.ReadLine();
            Console.WriteLine("Dame tu email");
            string email = Console.ReadLine();
            Console.WriteLine("Dame tu fecha de alta");
            string fechaAlta = Console.ReadLine();
            Console.WriteLine("Dame tu fecha de nacimiento");
            string fecha = Console.ReadLine();
            


            ClienteDto clientenuevo = new ClienteDto(IDCliente,nombre,apellido,DNI,fecha,email,fechaAlta);
            return clientenuevo;
            
        }

        public void darAlta(List<ClienteDto> listaAntigua)
        {

            ClienteDto nuevocliente = crearCliente();
            listaAntigua.Add(nuevocliente);
            Console.WriteLine(nuevocliente.ToString());
        }

        
    }
}
