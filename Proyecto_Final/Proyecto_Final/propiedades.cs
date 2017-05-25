using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Final
{
    public class propiedades
    {
        string tipo;
        string codigoPropiedad;
        string metroscuadrados;
        string codigopropietario;
        List <string>Gastos;

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public string CodigoPropiedad
        {
            get
            {
                return codigoPropiedad;
            }

            set
            {
                codigoPropiedad = value;
            }
        }

        public string Metroscuadrados
        {
            get
            {
                return metroscuadrados;
            }

            set
            {
                metroscuadrados = value;
            }
        }

        public string Codigopropietario
        {
            get
            {
                return codigopropietario;
            }

            set
            {
                codigopropietario = value;
            }
        }

        public List<string> Gastos1
        {
            get
            {
                return Gastos;
            }

            set
            {
                Gastos = value;
            }
        }
    }
}