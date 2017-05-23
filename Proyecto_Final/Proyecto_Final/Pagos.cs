using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Final
{
    public class Pagos
    {
        string idgastos;
        string descripcion;
        string importe;
        string tipoReparto;

        public string Idgastos
        {
            get
            {
                return idgastos;
            }

            set
            {
                idgastos = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Importe
        {
            get
            {
                return importe;
            }

            set
            {
                importe = value;
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