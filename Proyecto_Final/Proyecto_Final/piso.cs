using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Final
{
    public class piso : propiedades
    {
        string vhvn;
        int numHabitaciones;

        public string Vhvn
        {
            get
            {
                return vhvn;
            }

            set
            {
                vhvn = value;
            }
        }

        public int NumHabitaciones
        {
            get
            {
                return numHabitaciones;
            }

            set
            {
                numHabitaciones = value;
            }
        }
    }
}