using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Projecto_Final
{
    public interface MetodosRegistro //Interface con los metodos utilizados
    {
        void Registrar();
        void Actualizar();
        void Borrar();
        DataTable Grid();
    }
    public abstract class Persona : MetodosRegistro //Clase abstracta padre de las demas clases
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public string CadenaComando;

        //Creando la Conexion SQL:
        public SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-DHSIQKL\\SQLSERVERMEDIA20;Initial Catalog='Centro Medico';Integrated Security=True");
        public SqlCommand comando;

        public virtual void Registrar()
        {
            conexion.Open();

            comando = new SqlCommand(CadenaComando, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }
        public virtual void Actualizar()
        {
            conexion.Open();

            comando = new SqlCommand(CadenaComando, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }
        public virtual void Borrar()
        {
            conexion.Open();

            comando = new SqlCommand(CadenaComando, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }
        public virtual DataTable Grid()
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
    }
    public class Paciente : Persona //Clase Hija Paciente
    {
        public string Direccion { get; set; }

        public override void Registrar()
        {
            CadenaComando = $"insert into Paciente values ({ID}, '{Cedula}', '{Nombre}','{Telefono}', '{Email}', '{Direccion}')";
            base.Registrar();
        }

        public override void Actualizar()
        {
            CadenaComando = $"update Paciente set Nombre = '{Nombre}', Cedula = '{Cedula}', Telefono = '{Telefono}', EMail = '{Email}', Direccion = '{Direccion}'  where ID = {ID}";
            base.Actualizar();
        }

        public override void Borrar()
        {
            CadenaComando = $"delete from Paciente where ID = {ID}";
            base.Borrar();
        }

        public override DataTable Grid()
        {
            CadenaComando = "select * from Paciente";
            return base.Grid();
        }
    }

    public class Medico : Persona //Clase Hija Medico
    {
        public string Exequatur { get; set; }
        public string ClinicaLabora { get; set; }

        public override void Registrar()
        {
            CadenaComando = $"insert into Medico values ({ID}, '{Cedula}', '{Exequatur}', '{Nombre}','{Telefono}', '{Email}', '{ClinicaLabora}')";
            base.Registrar();
        }

        public override void Actualizar()
        {
            CadenaComando = $"update Medico set Nombre = '{Nombre}', Cedula = '{Cedula}', Telefono = '{Telefono}', EMail = '{Email}', Exequatur = '{Exequatur}', Clinica = '{ClinicaLabora}'  where ID = {ID}";
            base.Actualizar();
        }

        public override void Borrar()
        {
            CadenaComando = $"delete from Medico where ID = {ID}";
            base.Borrar();
        }

        public override DataTable Grid()
        {
            CadenaComando = "select * from Medico";
            return base.Grid();
        }
    }

    //Clase Clinica, como esta no tiene propiedades en comun, pues hereda directo del interface
    public class Clinica : MetodosRegistro 
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        //Creando la Conexion SQL:
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-DHSIQKL\\SQLSERVERMEDIA20;Initial Catalog='Centro Medico';Integrated Security=True");
        SqlCommand comando;

        public void Registrar()
        {
            conexion.Open();

            string CadenaComando = $"insert into Clinica values ({ID}, '{Nombre}', '{Direccion}')";
            comando = new SqlCommand(CadenaComando, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }

        public void Actualizar()
        {
            conexion.Open();

            string CadenaComando = $"update Clinica set Nombre = '{Nombre}', Direccion = '{Direccion}'  where ID = {ID}";
            comando = new SqlCommand(CadenaComando, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }

        public void Borrar()
        {
            conexion.Open();

            string CadenaComando = $"delete from Clinica where ID = {ID}";
            comando = new SqlCommand(CadenaComando, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }

        public DataTable Grid()
        {
            conexion.Open(); //abrir conexion

            //Estableciendo el comando
            string CadenaComando = "select * from Clinica";
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
