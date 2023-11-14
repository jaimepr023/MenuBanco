using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYListas.Dtos
{
    internal class ClienteDto
    {
        //Atributos(caracteristicas del ente) 

        string nombreCliente;

        string apellidosCliente;

        string dniCliente;

        string fechaDeNacimientpCliente;

        string emailCliente;

  

        string fechaAltaCliente;

        






        //Metodos GetySet
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string FechaDeNacimientpCliente { get => fechaDeNacimientpCliente; set => fechaDeNacimientpCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public string FechaAltaCliente { get => fechaAltaCliente; set => fechaAltaCliente = value; }
       

        public ClienteDto(string nombreCliente, string apellidosCliente, string dniCliente, string fechaDeNacimientpCliente, string emailCliente, string fechaAltaCliente)
        {
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.dniCliente = dniCliente;
            this.fechaDeNacimientpCliente = fechaDeNacimientpCliente;
            this.emailCliente = emailCliente;
          
            this.fechaAltaCliente = fechaAltaCliente;
           
        }

        public string toString()
        {
            Console.WriteLine("Tus datos personales se quedan guardados en nuesta base de datos. Y son los siguientes:\n");
            string todo = "Nombre completo-->"+this.nombreCliente + " " + this.apellidosCliente + "\n" + "DNI-->"+this.dniCliente + "\n" + "Email-->" + this.emailCliente + "\n" + "Fecha de nacimiento-->" + this.fechaDeNacimientpCliente + "\n" +  "Fecha de alta-->"+this.fechaAltaCliente +"\n";

            return todo;
           
        }

        //Constructores(metodods que tiene una clase para hacer el new.(TODA TIENE UN CONSTRUCTOR POR DEFECTO)

        /* public ClienteDto()
         {
         }

         public ClienteDto(string nombreCliente, string apellidosCliente)
         {
             this.nombreCliente = nombreCliente;
             this.apellidosCliente = apellidosCliente;
         }
         */






    }
}
