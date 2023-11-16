using ClasesYListas.Dtos;
using ClasesYListas.Servicios;

namespace ClasesYListas
{
    /// <summary>
    /// clase principal donde se encuentra el procedimiento de nuestra aplicacion 
    /// <author>jpr-16/11/23</author>
    /// </summary>
    class Program
    {
        /// <summary>
        /// metodod inicial donde se encuentra el procedimiento 
        /// <author>jpr-16/11/23</author>
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            /*Para que esto funciones poner en public los atributos de ClienteDto
             * //LISTAS DE TIPOS PRIMITIVOS
             //asi se hacen las listas en c#,<tipologia de la lista>

             List<int> listaEnteros = new List<int>();
             //añadir
             listaEnteros.Add(22);
             int entero = 6;
             listaEnteros.Add(entero);
             //[22][6]

             //acceder ¿Las posiciones de las listas empiezan en el cero!
             //directo
             listaEnteros[0]=entero;//[6][6]
             listaEnteros[1] = 22;//[6][22]
             int posicion0 = listaEnteros[0];//posicion0=6
             int posicion1 = listaEnteros[1];//posicion1=22


             //recorrer toda la lista 
             //indirecto
             for (int posicion=0;posicion<listaEnteros.Count();posicion++)
             {
                 Console.WriteLine(listaEnteros[posicion]);

             }

             //lISTA CON TIPO OBJETO
             List<ClienteDto> listaClientes = new List<ClienteDto>();
             //Crear un cliente
             ClienteDto cliente1 = new ClienteDto();
             cliente1.nombreCliente = "Jaime";
             cliente1.apellidosCliente = "Prieto";
             string nombreCompleto = cliente1.nombreCliente + cliente1.apellidosCliente;

             ClienteDto cliente2 = new ClienteDto();
             cliente2.nombreCliente = "pepe";
             cliente2.apellidosCliente = "Garcia";

             //Añadir los clientes a la lista.
             listaClientes.Add(cliente1);
             listaClientes.Add(cliente2);
             //[cliente1][cliente2]

             //Acceder a un cliente especifico 
            ClienteDto cliente2Prims= listaClientes[1];

             //accedidio al cliente que estaba en la posicion 1 en la lista
             //y dentro de ese cliente hemos accedidio a su campo nombre
            Console.WriteLine(listaClientes[1].nombreCliente);

             //Accedemos a referencia de memoria del objeto
             Console.WriteLine(listaClientes);

             //Accedemos a la referencia de memoria del objeto 
             Console.WriteLine(listaClientes[0]);

             //Recorrer toda la lista
             for(int posicion = 0;posicion<listaClientes.Count();posicion++)
             {
                 Console.WriteLine("Nombre:" + listaClientes[posicion].nombreCliente);
             }


             //Eliminar, cuando se elimina la lista se desplaza para cubrir el espacio libre
             //listaClientes.RemoveAt(0);
             //Console.WriteLine(listaClientes.Count());

             //foreach
             Console.WriteLine(listaClientes[1].nombreCliente);
             Console.WriteLine(cliente2.nombreCliente);
             Console.WriteLine(cliente2Prims.nombreCliente);
             cliente2Prims.nombreCliente = "Alfonso";
             Console.WriteLine(cliente2Prims.nombreCliente);
             Console.WriteLine(listaClientes[1].nombreCliente);
             Console.WriteLine(cliente2.nombreCliente);

             foreach (ClienteDto cliente in listaClientes)
             {
                 cliente.nombreCliente = "Rocio";
             }
             Console.WriteLine(cliente2.nombreCliente);
             Console.WriteLine(listaClientes[1].nombreCliente);
             Console.WriteLine(cliente2Prims.nombreCliente);

             //Modificar

             foreach (ClienteDto cliente in listaClientes)
             {
                 if (cliente.nombreCliente == "Rocio")
                 {
                     cliente.apellidosCliente = "Leal";
                 }
             }
             Console.WriteLine(cliente2.apellidosCliente);*/



            //Atributos en privados
            //que es el modificador que tienen por defecto el lenguaje c#


            /*  ClienteDto cliente = new ClienteDto();
              //set
              cliente.NombreCliente = "Marcos";
              //get
              string nombre = cliente.NombreCliente;

              ClienteDto cliente1 = new ClienteDto("jaime", "PR");
            */

            /*  ClienteDto cliente = new ClienteDto("jaime","54179875V");

              cliente.toString();
              Console.WriteLine(cliente);//referencia de memoria
              Console.WriteLine(cliente.toString());//valores de los campos 
              Instanciar un cliente nuevo con un nombre y dni y luego se imprimira por consola el objeto con nombre y dni con el metodo tostring*/

            MenuInterfaz mi = new MenuImplementacion();
            operacionesInterfaz oi = new operacionesImplementacion();
            List<ClienteDto> listaCliente= new List<ClienteDto>();
            

            mi.mensajeBienvenida();
            int opcionUsuario;
            bool cerrarMenu=false;

            while(!cerrarMenu)
            {
               opcionUsuario= mi.menu();
                switch (opcionUsuario)
                {
                    case 0:
                        Console.WriteLine("[INFOS]- A continuacion se cerrara el menu.Que tenga un buen dia");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFOS]- A continuacion se podra dar de alta\n");
                        oi.darAlta(listaCliente);
                        break;
                    case 2:
                        Console.WriteLine("[INFOS]- A continuacion se podra dar de baja");
                        string afirmacion = mi.afirmacion();
                        if (afirmacion == "si")
                        {
                          
                        }
                        else
                        {
                            Console.WriteLine("Gracias por su operacion.\n");
                            break;
                        }

                        break; 
                    case 3:
                        Console.WriteLine("[INFOS]- Aqui podra interactuar con su cuenta");
                        Console.WriteLine("[INFOS]- Por desgracia esta accion esta inhabilitada temporalmente, muchas gracias\n");
                        break;
                    default:
                        Console.WriteLine("[INFOS]-Error en la operacion elegida por favor elija una opcion correctamente\n");
                        break;

                }
            }
           








        }

    }
}