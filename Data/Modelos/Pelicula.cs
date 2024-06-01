using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proyecto_Final_Semestre.Data.Modelos
{
    internal class Pelicula
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha_estreno { get; set; }
        public int Duracion { get; set; }
        public string Categoria { get; set; }
        public decimal Presupuesto { get; set; }
        public string Clasificacion { get; set; }

        // Constructor sin parámetros
        public Pelicula()
        {
        
        }

        //Constructor
        public Pelicula(int id, string nombre, DateTime fecha_estreno, int duracion, string categoria, decimal presupuesto, string clasificacion)
        {
            ID = id;
            Nombre = nombre;
            Fecha_estreno = fecha_estreno;
            Duracion = duracion;
            Categoria = categoria;
            Presupuesto = presupuesto;
            Clasificacion = clasificacion;

        }















    }
}
