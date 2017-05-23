using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Final
{
    public class gastos
    {
        string identificacion2;
        string nombre1;
        string tipoReparto;

        public string Identificacion2
        {
            get
            {
                return identificacion2;
            }

            set
            {
                identificacion2 = value;
            }
        }

        public string Nombre1
        {
            get
            {
                return nombre1;
            }

            set
            {
                nombre1 = value;
            }
        }

        public string TipoReparto
        {
            get
            {
                return tipoReparto;
            }

            set
            {
                tipoReparto = value;
            }
        }
    }
}