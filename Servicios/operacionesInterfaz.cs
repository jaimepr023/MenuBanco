using ClasesYListas.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClasesYListas.Servicios
{
    /// <summary>
    /// Interfaz de nuestro metodos operadores
    /// <author>jpr-16/11/23</author>
    /// </summary>
    internal interface operacionesInterfaz
    {
        /// <summary>
        /// metodo de darnos de alta
        /// <author>jpr-16/11/23</author>
        /// </summary>
        /// <param name="listaAntigua"></param>

        public void darAlta(List<ClienteDto> listaAntigua);

    }

}
