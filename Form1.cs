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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Proyecto_Final_Semestre
{
    public partial class Form1 : Form
    {

        //clase para minimizar el trabajo.
        Pelicula peli = new Pelicula();

        List<Pelicula> Todos = new List<Pelicula>();










        //Crear variable para clase base.
        private PeliculasBD ppelicula;

        //Lista de categorias.
        private string[] calificacionpelis =
        {
            "PG-13",
            "PG",
            "R",
            "G",
        };



        public Form1()
        {
            InitializeComponent();
            ppelicula = new PeliculasBD("localhost", "root", "59104667");
            ffllenarcombobox();
        }

        //Llenar el combobox con los datos del vector.
        public void ffllenarcombobox()
        {
            // Llenar el ComboBox con las categorías.
            comboBox1_categoria.Items.AddRange(calificacionpelis);
        }
        private void comboBox1_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox1_clasificacion.Text = this.comboBox1_categoria.SelectedItem.ToString();
        }


        //Cargar la tabla.
        private void button1_cargar_Click(object sender, EventArgs e)
        {
            dataGridView1_tabla.DataSource = ppelicula.Leertodo();
        }

        
        //Agregar nueva pelicula.
        private void button1_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                string Nombre = textBox_nombre.Text;
                DateTime Fecha_estreno = dateTimePicker1_fecha_estreno.Value;
                int Duracion = int.Parse(textBox1_duracion.Text);
                string Categoria = textBox1_categoria.Text;
                decimal Presupuesto = decimal.Parse(textBox1_presupuesto.Text);
                string Clasificacion = textBox1_clasificacion.Text;

                int respuesta = ppelicula.CrearPelicula(Nombre, Fecha_estreno, Duracion, Categoria, Presupuesto, Clasificacion);
                if (respuesta > 0)
                {
                    MessageBox.Show("Pelicula ingresada correctamente");
                    dataGridView1_tabla.DataSource = ppelicula.Leertodo();
                }
                else
                {
                    MessageBox.Show("Error al ingresar la pelicula");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dato ingresaso no valido: \"{ex}\"");
            }
        }

        //Boton para buscar.
        private void button1_buscar_Click(object sender, EventArgs e)
        {
            int idpeliculabuscar = int.Parse(textBox_id.Text);

            DataTable peliculaencontrada = ppelicula.BuscarPeliculaPorId(idpeliculabuscar);

            if (peliculaencontrada.Rows.Count > 0)
            {
                try
                {
                    // El personaje fue encontrado
                    string nombre = peliculaencontrada.Rows[0]["nombre"].ToString();
                    DateTime fecha_estreno = Convert.ToDateTime(peliculaencontrada.Rows[0]["fecha_estreno"].ToString());
                    int duracion = int.Parse(peliculaencontrada.Rows[0]["duracion"].ToString());
                    string categoria = peliculaencontrada.Rows[0]["categoria"].ToString();
                    decimal presupuesto = Convert.ToDecimal(peliculaencontrada.Rows[0]["presupuesto"].ToString());
                    string clasificacion = peliculaencontrada.Rows[0]["clasificacion"].ToString();

                    textBox_nombre.Text = nombre;
                    dateTimePicker1_fecha_estreno.Value = fecha_estreno;
                    textBox1_duracion.Text = Convert.ToString(duracion);
                    textBox1_categoria.Text = categoria;
                    textBox1_presupuesto.Text = Convert.ToString(presupuesto);
                    textBox1_clasificacion.Text = clasificacion;

                    MessageBox.Show($"Pelicula encontrada. \"{nombre}\"");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Dato ingresaso no valido: \"{ex}\"");
                }
            }
            else
            {
                MessageBox.Show($"No se encontró el personaje con ID: \"{idpeliculabuscar}\"");
            }
        }

        
        private void button1_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(textBox_id.Text);
                string Nombre = textBox_nombre.Text;
                DateTime Fecha_estreno = dateTimePicker1_fecha_estreno.Value;
                int Duracion = int.Parse(textBox1_duracion.Text);
                string Categoria = textBox1_categoria.Text;
                decimal Presupuesto = decimal.Parse(textBox1_presupuesto.Text);
                string Clasificacion = textBox1_clasificacion.Text;


                int respuesta = ppelicula.ActualizarPelicula(Id, Nombre, Fecha_estreno, Duracion, Categoria, Presupuesto, Clasificacion);
                if (respuesta > 0)
                {
                    MessageBox.Show("Personaje Actualizado correctamente");
                    dataGridView1_tabla.DataSource = ppelicula.Leertodo();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el personaje");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dato ingresaso no valido: \"{ex}\"");
            }
        }

        private void button1_borrar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox_id.Text);


            int respuesta = ppelicula.EliminarPelicula(id);
            if (respuesta > 0)
            {
                MessageBox.Show("Personaje Eliminado correctamente");
                dataGridView1_tabla.DataSource = ppelicula.Leertodo();
            }
            else
            {
                MessageBox.Show("Error al Eliminar el personaje");
            }



        }
















        //=====================================================================================================
        //=====================================================================================================
        //=====================================================================================================
        private void label_id_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_categoria_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
