using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projecto_Final
{
    public partial class FormCita : Form
    {
        Cita cita = new Cita();

        public FormCita()
        {
            InitializeComponent();
        }

        public void Limpiar() //Metodo para Limpiar
        {
            foreach (Control tool in Controls)
            {
                if (tool is TextBox)
                {
                    tool.Text = "";
                }
            }
        }

        public void LlenarGrid() //Metodo para el dataview
        {
            dataGridView1.DataSource = cita.Grid();
        }

        public void CamposVacios() //Metodo para evitar campos vacios
        {
            foreach (Control lim in Controls)
            {
                if (lim is TextBox)
                {
                    if (string.IsNullOrEmpty(lim.Text))
                    {
                        MessageBox.Show("Debe completar la informacion.");
                    }
                }
            }
        }

        private void FormCita_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'centro_MedicoDataSet.Paciente' table. You can move, or remove it, as needed.
            this.pacienteTableAdapter.Fill(this.centro_MedicoDataSet.Paciente);
            // TODO: This line of code loads data into the 'centro_MedicoDataSet.Medico' table. You can move, or remove it, as needed.
            this.medicoTableAdapter.Fill(this.centro_MedicoDataSet.Medico);
            // TODO: This line of code loads data into the 'centro_MedicoDataSet.Clinica' table. You can move, or remove it, as needed.
            this.clinicaTableAdapter.Fill(this.centro_MedicoDataSet.Clinica);

            LlenarGrid();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                cita.Paciente = listPaciente.Text;

                cita.Borrar();

                MessageBox.Show("Los datos han sido eliminados con Exito");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            LlenarGrid();
            Limpiar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                cita.Fecha = txtFecha.Text;
                cita.Hora = txtHora.Text;
                cita.Causa = txtCausa.Text;
                cita.Paciente = listPaciente.Text;
                cita.Medico = listMedico.Text;
                cita.Clinica = listClinica.Text;

                cita.Registrar();

                MessageBox.Show("Los datos han sido registrados con Exito");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            CamposVacios();
            LlenarGrid();
            Limpiar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                cita.Fecha = txtFecha.Text;
                cita.Hora = txtHora.Text;
                cita.Causa = txtCausa.Text;
                cita.Paciente = listPaciente.Text;
                cita.Medico = listMedico.Text;
                cita.Clinica = listClinica.Text;

                cita.Actualizar();

                MessageBox.Show("Los datos han sido actualizados con Exito");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            CamposVacios();
            LlenarGrid();
            Limpiar();
        }
    }
    //Clase Cita, Hereda directamente de la interface
    public class Cita : MetodosRegistro
    {
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Clinica { get; set; }
        public string Paciente { get; set; }
        public string Medico { get; set; }
        public string Causa { get; set; }

        //Creando la Conexion SQL:
        public SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-DHSIQKL\\SQLSERVERMEDIA20;Initial Catalog='Centro Medico';Integrated Security=True");
        public SqlCommand comando;

        public void Registrar()
        {
            conexion.Open();

            string CadenaComando = $"insert into CitaMedica values ('{Fecha}', '{Hora}', '{Clinica}', '{Paciente}', '{Medico}', '{Causa}')";
            comando = new SqlCommand(CadenaComando, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }

        public void Actualizar()
        {
            conexion.Open();

            string CadenaComando = $"update CitaMedica set Fecha = '{Fecha}', Hora = '{Hora}', Medico = '{Medico}' where Paciente = '{Paciente}'";
            comando = new SqlCommand(CadenaComando, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }

        public void Borrar()
        {
            conexion.Open();

            string CadenaComando = $"delete from CitaMedica where Paciente = '{Paciente}'";
            comando = new SqlCommand(CadenaComando, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }

        public DataTable Grid()
        {
            conexion.Open(); //abrir conexion

            //Estableciendo el comando
            string CadenaComando = "select * from CitaMedica";
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
