using Proyecto_Final_Semestre.Data.DataAcces;
//using Proyecto_Final_Semestre.Data.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        //===============================================================================================
        //DEFINICIONES ==================================================================================
        //===============================================================================================

        //Crear variable para clase base.
        private PeliculasBD ppelicula;

        //Crear una direccion para mostrar las imagenes.
        private Dictionary<string, string> peliculaImagenes;

        //Lista de calificaciones.
        private string[] calificacionpelis =
        {
            "PG-13",
            "PG",
            "R",
            "G",
        };

        //lista de categorías.
        private string[] categoriaspelis =
        {
            "Acción",
            "Animación",
            "Aventura",
            "Ciencia Ficción",
            "Comedia",
            "Drama",
            "Fantacía",
            "Romance",
        };



        //===============================================================================================
        //FUNCIONES =====================================================================================
        //===============================================================================================

        public Form1()
        {
            InitializeComponent();
            ppelicula = new PeliculasBD("localhost", "root", "59104667");
            ffllenarcombobox();
            CargarPeliculas();

            string base_imagen = "base_imagen";
            ffmostrarimagen(base_imagen);
        }

        //Combobox de las calificacion
        private void comboBox1_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox1_clasificacion.Text = this.comboBox1_categoria.SelectedItem.ToString();
        }

        //Combobox de las categorías
        private void comboBox1_categoriass_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox1_categoria.Text = this.comboBox1_categoriass.SelectedItem.ToString();
        }
        
        //Llenar el combobox con los datos del vector.
        public void ffllenarcombobox()
        {
            // Llenar el ComboBox con las categorías.
            comboBox1_categoria.Items.AddRange(calificacionpelis);
            comboBox1_categoriass.Items.AddRange(categoriaspelis);

        }

        //Cargar las direccion de las imagenes de las peliculas.
        public void CargarPeliculas()
        {
            peliculaImagenes = new Dictionary<string, string>();

            peliculaImagenes.Add("La Red Social", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\la_red_social.jpg"));
            peliculaImagenes.Add("El Origen", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\el_origen.jpg"));
            peliculaImagenes.Add("Los Vengadores", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\los_vengadores.jpg"));
            peliculaImagenes.Add("Gravedad", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\gravedad.jpg"));
            peliculaImagenes.Add("Interestelar", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\interestelar.jpg"));
            peliculaImagenes.Add("Mad Max: Furia en el Camino", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\mad_max_furia_en_el_camino.jpg"));
            peliculaImagenes.Add("Toy Story 3", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\toy_story_3.jpg"));
            peliculaImagenes.Add("Mi Villano Favorito", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\mi_villano_favorito.jpg"));
            peliculaImagenes.Add("Frozen: Una Aventura Congelada", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\frozen_una_aventura_congelada.jpg"));
            peliculaImagenes.Add("Los Minions", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\los_minions.jpg"));
            peliculaImagenes.Add("Harry Potter y las Reliquias de la Muerte - Parte 1", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\harry_potter_y_las_reliquias_de_la_muerte_parte_1.jpg"));
            peliculaImagenes.Add("Harry Potter y las Reliquias de la Muerte - Parte 2", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\harry_potter_y_las_reliquias_de_la_muerte_parte_2.jpg"));
            peliculaImagenes.Add("La Saga Crepúsculo: Eclipse", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\la_saga_crepusculo_eclipse.jpg"));
            peliculaImagenes.Add("La Saga Crepúsculo: Amanecer - Parte 1", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\la_saga_crepusculo_amanecer_parte_1.jpg"));
            peliculaImagenes.Add("La Saga Crepúsculo: Amanecer - Parte 2", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\la_saga_crepusculo_amanecer_parte_2.jpg"));
            peliculaImagenes.Add("Los Juegos del Hambre", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\los_juegos_del_hambre.jpg"));
            peliculaImagenes.Add("Los Juegos del Hambre: En Llamas", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\los_juegos_del_hambre_en_llamas.jpg"));
            peliculaImagenes.Add("Los Juegos del Hambre: Sinsajo - Parte 1", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\los_juegos_del_hambre_sinsajo_parte_1.jpg"));
            peliculaImagenes.Add("Los Juegos del Hambre: Sinsajo - Parte 2", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\los_juegos_del_hambre_sinsajo_parte_2.jpg"));
            peliculaImagenes.Add("Misión Rescate", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\mision_rescate.jpg"));
            peliculaImagenes.Add("Jurassic World", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\jurassic_world.jpg"));
            peliculaImagenes.Add("007: Operación Skyfall", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\007_operacion_skyfall.jpg"));
            peliculaImagenes.Add("007: Spectre", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\007_spectre.jpg"));
            peliculaImagenes.Add("Iron Man 3", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\iron_man_3.jpg"));
            peliculaImagenes.Add("Rápidos y Furiosos 5in Control", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\rapidos_y_furiosos_5in_control.jpg"));
            peliculaImagenes.Add("¿Qué Pasó Ayer? Parte II", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\que_paso_ayer_parte_ii.jpg"));
            peliculaImagenes.Add("Transformers: El Lado Oscuro de la Luna", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\transformers_el_lado_oscuro_de_la_luna.jpg"));
            peliculaImagenes.Add("El Caballero de la Noche Asciende", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\el_caballero_de_la_noche_asciende.jpg"));
            peliculaImagenes.Add("El Hobbit: Un Viaje Inesperado", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\el_hobbit_un_viaje_inesperado.jpg"));
            peliculaImagenes.Add("El Hobbit: La Desolación de Smaug", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\el_hobbit_la_desolacion_de_smaug.jpg"));
            peliculaImagenes.Add("El Hobbit: La Batalla de los Cinco Ejércitos", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\el_hobbit_la_batalla_de_los_cinco_ejercitos.jpg"));
            peliculaImagenes.Add("base_imagen", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes\\base_imagen.jpg"));

        }

        //Mostrar la imagen en el picturebox.
        public void ffmostrarimagen(string nombre)
        {
            if (peliculaImagenes.ContainsKey(nombre))
            {
                string rutaImagen = peliculaImagenes[nombre];
                try
                {
                    pictureBox1_portadas_peliculas.Image = Image.FromFile(rutaImagen);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Fallo en encontrar la imagen");
            }
        }





        //===============================================================================================
        //BOTONES========================================================================================
        //===============================================================================================

        //Cargar la tabla.
        private void button1_cargar_Click(object sender, EventArgs e)
        {
            dataGridView1_tabla.DataSource = ppelicula.Leertodo();
        }

        //Limpiar los datos de los texboxs.
        private void button1_limpiar_datos_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_nombre.Clear();

            textBox1_duracion.Clear();
            textBox1_categoria.Clear();
            textBox1_presupuesto.Clear();
            textBox1_clasificacion.Clear();

            string base_imagen = "base_imagen";
            ffmostrarimagen(base_imagen);
        }

        //Boton para buscar.
        private void button1_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                int idpeliculabuscar = int.Parse(textBox_id.Text);

                DataTable peliculaencontrada = ppelicula.BuscarPeliculaPorId(idpeliculabuscar);

                if (peliculaencontrada.Rows.Count > 0)
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
                    dataGridView1_tabla.DataSource = ppelicula.Leertodo();


                    ffmostrarimagen(nombre);

                    MessageBox.Show($"Pelicula encontrada. \"{nombre}\"");
                }
                else
                {
                    MessageBox.Show($"No se encontró la pelicula con ID: \"{idpeliculabuscar}\"");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el ingreso de datos: " + ex);
            }
        }

        //Agregar nueva pelicula.
        private void button1_agregar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas agregar esta nueva película?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
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
                        MessageBox.Show("Pelicula agregada correctamente");
                        dataGridView1_tabla.DataSource = ppelicula.Leertodo();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar la pelicula");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Dato ingresado no valido: \"{ex}\"");
                }
            }
            else
            {
                MessageBox.Show("Creación ANULADA");
            }
        }

        //Actualizar pelicula
        private void button1_actualizar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas actualizar esta película?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
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
            else
            {
                MessageBox.Show("Actualización ANULADA");
            }
        }

        //Borrar pelicula.
        private void button1_borrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas borrar esta película?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int id = int.Parse(textBox_id.Text);
                int respuesta = ppelicula.EliminarPelicula(id);
                if (respuesta > 0)
                {
                    MessageBox.Show("Personaje Eliminado correctamente");
                    dataGridView1_tabla.DataSource = ppelicula.Leertodo();
                    textBox_id.Clear();
                    textBox_nombre.Clear();

                    textBox1_duracion.Clear();
                    textBox1_categoria.Clear();
                    textBox1_presupuesto.Clear();
                    textBox1_clasificacion.Clear();
                }
                else
                {
                    MessageBox.Show("Error al Eliminar el personaje");
                }
            }
            else
            {
                MessageBox.Show("Eliminación ANULADA");
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

        private void pictureBox1_portadas_peliculas_Click(object sender, EventArgs e)
        {

        }

    }
}
