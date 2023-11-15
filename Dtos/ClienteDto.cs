using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYListas.Dtos
{
    internal class ClienteDto
    {
        //Atributos(caracteristicas del ente) 

        long idCliente;//PK

        string nombreCliente;

        string apellidosCliente;

        string dniCliente;//UNIVOCO

        string fechaDeNacimientpCliente;

        string emailCliente;

        string fechaAltaCliente;

        string fechadebaja;

        //Metodos GetySet
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string FechaDeNacimientpCliente { get => fechaDeNacimientpCliente; set => fechaDeNacimientpCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public string FechaAltaCliente { get => fechaAltaCliente; set => fechaAltaCliente = value; }
        public string Fechadebaja { get => fechadebaja; set => fechadebaja = value; }
        public long IdCliente { get => idCliente; set => idCliente = value; }

       //Constructores(metodods que tiene una clase para hacer el new.(TODA TIENE UN CONSTRUCTOR POR DEFECTO)
        public ClienteDto(long idCliente,string nombreCliente, string apellidosCliente, string dniCliente, string fechaDeNacimientpCliente, string emailCliente, string fechaAltaCliente)
        {
            this.idCliente = IdCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.dniCliente = dniCliente;
            this.fechaDeNacimientpCliente = fechaDeNacimientpCliente;
            this.emailCliente = emailCliente;   
            this.fechaAltaCliente = fechaAltaCliente;
          

        }

        public ClienteDto()
        {

        }

        override
        public string ToString()
        {
            Console.WriteLine("Tus datos personales se quedan guardados en nuesta base de datos. Y son los siguientes:\n");
            string clienteString = "Nombre completo-->"+this.nombreCliente + " " + this.apellidosCliente + "\n" + "DNI-->"+this.dniCliente + "\n" + "Email-->" + this.emailCliente + "\n" + "Fecha de nacimiento-->" + this.fechaDeNacimientpCliente + "\n" +  "Fecha de alta-->"+this.fechaAltaCliente +"\n" + "Fecha de baja-->" + this.fechadebaja + "\n";

            return clienteString;
           
        }


        

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
