using MySql.Data.MySqlClient;
using ProjectMaster.DiseñoMessageBox;
using System;

using System.Windows.Forms;

namespace ProjectMaster.Conection
{
    internal class Conexion
    {
        private MySqlConnection conexion;
        private string server = "bnjriowbvo57ch81epdx-mysql.services.clever-cloud.com";
        private string database = "bnjriowbvo57ch81epdx";
        private string user = "uphuq0lvmunpqiwk";
        private string password = "ciBKkDwyvUqlW3WwTiy2";
        private string cadenaConexion;
        CargarApp cargar = new CargarApp();

        public Conexion()
        {
            cadenaConexion = "Database=" + database +
                "; DataSource=" + server +
                "; User Id= " + user +
                "; Password=" + password;
        }
        public void crearConexion()
        {
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                cargar.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Estamos experimentanto problemas tecnicos. Perdon por los inconvenientes.\nEl equipo de Project_Master", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        public MySqlConnection obtenerConexion()
        {
            return conexion;
        }


        public MySqlDataReader realizarConsulta(string stringConsulta, MySqlConnection c)
        {
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = c;
            consulta.CommandText = stringConsulta;

            try
            {
                MySqlDataReader reader = consulta.ExecuteReader();
                return reader;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error de MySQL: " + ex.Message);


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }
            return null;
        }

        public void realizarSentenciaBD(string stringConsulta, MySqlConnection c)
        {
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = c;
            consulta.CommandText = stringConsulta;

            try
            {
                consulta.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error de MySQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

    }
}