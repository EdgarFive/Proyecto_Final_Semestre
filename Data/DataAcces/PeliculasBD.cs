﻿using MySql.Data.MySqlClient;
using Proyecto_Final_Semestre.Data.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proyecto_Final_Semestre.Data.DataAcces
{
    internal class PeliculasBD
    {
        // Información de conexión a la base de datos
        private string connectionString = "Server=localhost;Database=db_proyectofinal;Uid=root;Pwd=59104667;";
        MySqlConnection connection;


        //Constructor.
        public PeliculasBD(string servidor, string usur, string pwd)
        {
            connectionString = "Server=" + servidor + ";Database=db_proyectofinal;Uid=" + usur + ";Pwd=" + pwd + ";";
        }
        

        public DataTable Leertodo()
        {
            DataTable peliculass = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM tb_peliculas";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(peliculass);
                    }
                }
            }
            return peliculass;

            /*
            DataTable peliculas = new DataTable();
                connection.Open();
                string sql = "SELECT * FROM tb_peliculas";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(peliculas);
                    }
                }
            return peliculas;*/
        }

        public int CrearPelicula(string Nombre, DateTime Fecha_estreno, int Duracion, string Categoria, decimal Presupuesto, string Clasificacion)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = "INSERT INTO tb_peliculas (nombre, fecha_estreno, duracion, categoria, presupuesto, clasificacion) VALUES (@nombre, @fecha_estreno, @duracion, @categoria, @presupuesto, @clasificacion)";
                MySqlCommand command = new MySqlCommand(sql, connection);

                connection.Open();
                try
                {
                    command.Parameters.AddWithValue("@nombre", Nombre);
                    command.Parameters.AddWithValue("@fecha_estreno", Fecha_estreno);
                    command.Parameters.AddWithValue("@duracion", Duracion);
                    command.Parameters.AddWithValue("@categoria", Categoria);
                    command.Parameters.AddWithValue("@presupuesto", Presupuesto);
                    command.Parameters.AddWithValue("@clasificacion", Clasificacion);
                    connection.Open();
                    
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el registro: " + ex.Message);
                    return command.ExecuteNonQuery();

                }
                finally
                {
                    connection.Close();
                }
            }
        }
        
        
        /*
        public List<Pelicula> ObtenerTodasLasPeliculas()
        {
            List<Pelicula> peliculass = new List<Pelicula>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = "SELECT * FROM tb_peliculas";
                MySqlCommand cmd = new MySqlCommand(sql, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Pelicula pppeliculass = new Pelicula
                        (
                            id: reader.GetInt32("ID"),
                            nombre: reader.GetString("Nombre"),
                            fecha_estreno: reader.GetDateTime ("Fecha_estreno"),
                            duracion: reader.GetInt32("Duracion"),
                            categoria: reader.GetString("Categoria"),
                            presupuesto: reader.GetDecimal("Presupuesto"),
                            clasificacion: reader.GetString("Clasificacion")
                        );

                        peliculass.Add(pppeliculass);
                    }
                    return peliculass;
                    reader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return peliculass;
        }
        */


        //Busca una pelicula por su ID
        public DataTable BuscarPeliculaPorId(int id)
        {
            DataTable peliculat = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM tb_peliculas WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(peliculat);
                    }
                }
            }
            return peliculat;
        }

        //Actualizar el Pelicula.
        public int ActualizarPelicula(int Id, string Nombre, DateTime Fecha_estreno, int Duracion, string Categoria, decimal Presupuesto, string Clasificacion)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE tb_peliculas SET nombre = @nombre, fecha_estreno = @fecha_estreno, duracion = @duracion, categoria = @categoria, presupuesto = @presupuesto, clasificacion = @clasificacion WHERE id = @id";     
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@id", Id);
                        command.Parameters.AddWithValue("@nombre", Nombre);
                        command.Parameters.AddWithValue("@fecha_estreno", Fecha_estreno);
                        command.Parameters.AddWithValue("@duracion", Duracion);
                        command.Parameters.AddWithValue("@categoria", Categoria);
                        command.Parameters.AddWithValue("@presupuesto", Presupuesto);
                        command.Parameters.AddWithValue("@clasificacion", Clasificacion);
                        connection.Open();

                        return command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar el registro: " + ex.Message);
                        return command.ExecuteNonQuery();
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
        }

        public int EliminarPelicula(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM tb_peliculas WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    return command.ExecuteNonQuery();
                }
            }
        }



    }
}
