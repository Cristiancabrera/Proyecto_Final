using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Final
{
    public class Garaje: propiedades
    {
        string abierta_cerrada;
        string bodega;

        public string Abierta_cerrada
        {
            get
            {
                return abierta_cerrada;
            }

            set
            {
                abierta_cerrada = value;
            }
        }

        public string Bodega
        {
            get
            {
                return bodega;
            }

            set
            {
                bodega = value;
            }
        }
    }
}