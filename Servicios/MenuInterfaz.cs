using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYListas.Servicios
{
    internal interface MenuInterfaz
    {
        public void mensajeBienvenida();

        public int menu();

        public string afirmacion();
    }
}
