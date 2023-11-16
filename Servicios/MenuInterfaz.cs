using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYListas.Servicios
{
    /// <summary>
    /// interfaz donde esta los metodos logicos para interactuar con el menu
    /// <author>jpr-16/11/23</author>
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// metodo que nos da el mensaje de bienvendia
        /// <author>jpr-16/11/23</author>
        /// </summary>
        public void mensajeBienvenida();

        /// <summary>
        /// Metodo que nos muestra por pantalla el menu y nos devuelve la opcion elegida
        /// <author>jpr-16/11/23</author>
        /// </summary>
        /// <returns></returns>
        public int menu();

        /// <summary>
        /// metod que nos devuelve si quiere afirmar la operacion dedarnos de baja
        /// <author>jpr-16/11/23</author>
        /// </summary>
        /// <returns></returns>
        public string afirmacion();
    }
}
