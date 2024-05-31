using Proyecto_Final_Semestre.Data.DataAcces;
using Proyecto_Final_Semestre.Data.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Semestre
{
    public partial class Form1 : Form
    {
        ConexionMySql Clscone = new ConexionMySql();
        Pelicula ppelicula = new Pelicula();
        private PeliculasBD pelicula;
        List<Pelicula> todos;



        public Form1()
        {
            InitializeComponent();
            pelicula = new PeliculasBD("localhost", "root", "59104667");
        }
        private void button1_cargar_Click(object sender, EventArgs e)
        {
            dataGridView1_tabla.DataSource = pelicula.Leertodo();
        }













        //=====================================================================================================
        //=====================================================================================================
        //=====================================================================================================
        private void label_id_Click(object sender, EventArgs e)
        {

        }

    }
}
