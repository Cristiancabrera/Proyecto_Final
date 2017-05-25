using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Proyecto_Final
{
    public partial class _Default : Page
    {
        List<comunidad> listcomunidad = new List<comunidad>();
        List<DatosPropietarios> listdatosPropie = new List<DatosPropietarios>();
        List<gastos> listgastos = new List<gastos>();
        List<Pagos> listpagos = new List<Pagos>();
        List<propiedades> listpropiedades = new List<propiedades>();
 
        protected void Page_Load(bool A, bool B, bool C, bool D, bool E)
        {
            if (A == true)
            {
                string Archivo = "C:\\Users\\Cristian Cabrera\\Desktop\\Proyecto_Programacion\\Proyecto_Final\\Proyecto_Final\\Comunidad.txt";
                FileStream stream = new FileStream(Archivo, FileMode.Open, FileAccess.Read);
                StreamReader leer = new StreamReader(stream);
                while (leer.Peek() > -1)
                {
                    comunidad comunidadtemp = new comunidad();
                    comunidadtemp.Identificacion = leer.ReadLine();
                    comunidadtemp.Nombre= leer.ReadLine();
                    comunidadtemp.Poblacion = leer.ReadLine();
                    listcomunidad.Add(comunidadtemp);
                }
                leer.Close();
            }
            if (B == true)
            {
                string Archivo1 = "C:\\Users\\Cristian Cabrera\\Desktop\\Proyecto_Programacion\\Proyecto_Final\\Proyecto_Final\\Gastos.txt";
                FileStream stream1 = new FileStream(Archivo1, FileMode.Open, FileAccess.Read);
                StreamReader leer1 = new StreamReader(stream1);
                while (leer1.Peek() > -1)
                {
                    gastos gastostemp = new gastos();
                    gastostemp.Identificacion2 = leer1.ReadLine();
                    gastostemp.Nombre1 = leer1.ReadLine();
                    gastostemp.TipoReparto = leer1.ReadLine();         
                    listgastos.Add(gastostemp);
                }
                leer1.Close();
            }
            if (C == true)
            {
                string Archivo2 = "C:\\Users\\Cristian Cabrera\\Desktop\\Proyecto_Programacion\\Proyecto_Final\\Proyecto_Final\\Propiedades.txt";
                FileStream stream2 = new FileStream(Archivo2, FileMode.Open, FileAccess.Read);
                StreamReader leer2 = new StreamReader(stream2);
                while (leer2.Peek() > -1)
                {
                    propiedades propiedadestemp = new propiedades();
                    propiedadestemp.CodigoPropiedad = leer2.ReadLine();
                    propiedadestemp.Codigopropietario = leer2.ReadLine();
                    propiedadestemp.Tipo = leer2.ReadLine();
                    propiedadestemp.Metroscuadrados = leer2.ReadLine();
                    listpropiedades.Add(propiedadestemp);
                }
                leer2.Close();
            }
            if (D == true)
            {
                string Archivo3 = "C:\\Users\\Cristian Cabrera\\Desktop\\Proyecto_Programacion\\Proyecto_Final\\Proyecto_Final\\DatosPropietarios.txt";
                FileStream stream2 = new FileStream(Archivo3, FileMode.Open, FileAccess.Read);
                StreamReader leer3 = new StreamReader(stream2);
                while (leer3.Peek() > -1)
                {
                    DatosPropietarios datosprotemp = new DatosPropietarios();
                    datosprotemp.Nombre = leer3.ReadLine();
                    datosprotemp.Nit = leer3.ReadLine();
                    datosprotemp.Email = leer3.ReadLine();
                    listdatosPropie.Add(datosprotemp);
                }
                leer3.Close();
            }
            if (E == true)
            {
                string Archivo4 = "C:\\Users\\Cristian Cabrera\\Desktop\\Proyecto_Programacion\\Proyecto_Final\\Proyecto_Final\\Pagos.txt";
                FileStream stream2 = new FileStream(Archivo4, FileMode.Open, FileAccess.Read);
                StreamReader leer4 = new StreamReader(stream2);
                while (leer4.Peek() > -1)
                {
                    Pagos pagostemp = new Pagos();
                    pagostemp.Idgastos = leer4.ReadLine();
                    pagostemp.Importe = leer4.ReadLine();
                    pagostemp.TipoReparto = leer4.ReadLine();
                    pagostemp.Descripcion = leer4.ReadLine();
                    listpagos.Add(pagostemp);
                }
                leer4.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool A = true;
            bool B = false;
            bool C = false;
            bool D = false;
            bool E = false;


            Page_Load(A, B, C, D, E);

            GridView1.DataSource = null;
            GridView1.DataBind();
            GridView1.DataSource = listcomunidad;
            GridView1.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            bool A = false;
            bool B = true;
            bool C = false;
            bool D = false;
            bool E = false;


            Page_Load(A, B, C, D, E);

            GridView1.DataSource = null;
            GridView1.DataBind();
            GridView1.DataSource = listgastos;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            bool A = false;
            bool B = false;
            bool C = true;
            bool D = false;
            bool E = false;


            Page_Load(A, B, C, D, E);

            GridView1.DataSource = null;
            GridView1.DataBind();
            GridView1.DataSource = listpropiedades;
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            bool A = false;
            bool B = false;
            bool C = false;
            bool D = true;
            bool E = false;


            Page_Load(A, B, C, D, E);

            GridView1.DataSource = null;
            GridView1.DataBind();
            GridView1.DataSource = listdatosPropie;
            GridView1.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            bool A = false;
            bool B = false;
            bool C = false;
            bool D = false;
            bool E = true;


            Page_Load(A, B, C, D, E);

            GridView1.DataSource = null;
            GridView1.DataBind();
            GridView1.DataSource = listpagos;
            GridView1.DataBind();
        }
    }
}