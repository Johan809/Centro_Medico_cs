using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Projecto_Final
{
    public class Query
    {

        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Exequatur { get; set; }
        public string NomTabla { get; set; }
        public string CadenaComando { get; set; }


        public SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-DHSIQKL\\SQLSERVERMEDIA20;Initial Catalog='Centro Medico';Integrated Security=True");
        public SqlCommand comando;
        public DataTable Buscar()
        {
            conexion.Open(); //abrir conexion

            //Estableciendo el comando
            comando = new SqlCommand(CadenaComando, conexion);
            comando.ExecuteNonQuery(); //Ejecutando el comando

            SqlDataAdapter data = new SqlDataAdapter(comando); //Adaptando la informacion
            DataTable table = new DataTable(); // Creando la tabla

            data.Fill(table); //Llenando la tabla

            conexion.Close(); //Cerrar conexion

            return table;
        }

        public DataTable Grid()
        {
            conexion.Open(); //abrir conexion

            //Estableciendo el comando
            string CadenaComando = $"select * from {NomTabla}";
            comando = new SqlCommand(CadenaComando, conexion);
            comando.ExecuteNonQuery(); //Ejecutando el comando

            SqlDataAdapter data = new SqlDataAdapter(comando); //Adaptando la informacion
            DataTable table = new DataTable(); // Creando la tabla

            data.Fill(table); //Llenando la tabla

            conexion.Close(); //Cerrar conexion

            return table;
        }
    }
}
