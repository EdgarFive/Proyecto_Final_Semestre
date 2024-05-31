using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Semestre.Data.DataAcces
{
    internal class PeliculasBD
    {
        // Información de conexión a la base de datos
        private string connectionString = "Server=localhost;Database=db_proyectofinal;Uid=root;Pwd=59104667;";

        //Constructor.
        public PeliculasBD(string servidor, string usur, string pwd)
        {
            connectionString = "Server=" + servidor + ";Database=db_proyectofinal;Uid=" + usur + ";Pwd=" + pwd + ";";
        }

        public DataTable Leertodo()
        {
            DataTable pelicualas = new DataTable();

            using (MySqlConnection coneccion = new MySqlConnection(connectionString))
            {
                coneccion.Open();

                string sql = "SELECT * FROM tb_peliculas";
                using (MySqlCommand command = new MySqlCommand(sql, coneccion))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(pelicualas);
                    }
                }
            }
            return pelicualas;
        }










    }
}
