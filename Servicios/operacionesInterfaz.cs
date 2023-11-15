using ClasesYListas.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClasesYListas.Servicios
{
    internal interface operacionesInterfaz
    {
      
        public void darAlta(List<ClienteDto> listaAntigua);

    }

}
