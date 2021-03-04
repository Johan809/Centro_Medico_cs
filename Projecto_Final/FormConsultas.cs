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
    public partial class FormConsultas : Form
    {
        Query Consulta = new Query();
        public FormConsultas()
        {
            InitializeComponent();
        }

        public void LlenarGrid() //Metodo para el dataview
        {
            dataGridView1.DataSource = Consulta.Grid();
            dataGridView2.DataSource = Consulta.Grid();
            dataGridView3.DataSource = Consulta.Grid();

        }

        private void TxtBuscar_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Nombre")
            {
                try
                {
                    Consulta.Nombre = txtParametro1.Text;

                    Consulta.NomTabla = "Paciente";
                    Consulta.CadenaComando = $"Select * from Paciente where Nombre = '{Consulta.Nombre}' ";

                    dataGridView1.DataSource = Consulta.Buscar();
                    
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

            if(comboBox1.Text == "Email")
            {
                try
                {
                    Consulta.Email = txtParametro1.Text;

                    Consulta.NomTabla = "Paciente";
                    Consulta.CadenaComando = $"Select * from Paciente where Email = '{Consulta.Email}' ";

                    dataGridView1.DataSource = Consulta.Buscar();
                    
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void BtnSeleccion_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Nombre")
            {
                label2.Text = "Ingrese el nombre del Paciente: ";

                label2.Visible = true;
                txtParametro1.Visible = true;
            }

            if(comboBox1.Text == "Email")
            {
                label2.Text = "Ingrese el Email del Paciente: ";

                label2.Visible = true;
                txtParametro1.Visible = true;
            }
            Consulta.NomTabla = "Paciente";
            LlenarGrid();
        }

        private void BtnSeleccion2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Nombre")
            {
                label4.Text = "Ingrese el nombre del Medico: ";

                label4.Visible = true;
                txtParametro2.Visible = true;
            }

            if (comboBox2.Text == "Exequatur")
            {
                label4.Text = "Ingrese el Exequatur del Medico: ";

                label4.Visible = true;
                txtParametro2.Visible = true;
            }
            Consulta.NomTabla = "Medico";
            LlenarGrid();
        }

        private void BtnBuscar2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Nombre")
            {
                try
                {
                    Consulta.Nombre = txtParametro2.Text;

                    Consulta.NomTabla = "Medico";
                    Consulta.CadenaComando = $"Select * from Medico where Nombre = '{Consulta.Nombre}' ";

                    dataGridView2.DataSource = Consulta.Buscar();
                    dataGridView2.Visible = true;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

            if (comboBox2.Text == "Exequatur")
            {
                try
                {
                    Consulta.Exequatur = txtParametro2.Text;

                    Consulta.NomTabla = "Medico";
                    Consulta.CadenaComando = $"Select * from Medico where Exequatur = '{Consulta.Exequatur}' ";

                    dataGridView2.DataSource = Consulta.Buscar();
                    dataGridView2.Visible = true;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {
            Consulta.NomTabla = "Medico";
            LlenarGrid();
        }

        private void BtnSeleccionar3_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Nombre")
            {
                label6.Text = "Ingrese el nombre del Medico: ";

                label6.Visible = true;
                txtParametro3.Visible = true;
                comboBox4.Visible = false;
                Consulta.NomTabla = "CitaMedica";
            }

            if (comboBox3.Text == "Exequatur")
            {
                label6.Text = "Seleccione el Exequatur del Medico: ";

                label6.Visible = true;
                comboBox4.Visible = true;
                txtParametro3.Visible = false;
                Consulta.NomTabla = "Medico";
            }
            
            LlenarGrid();
        }

        private void BtnBuscar3_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Nombre")
            {
                try
                {
                    Consulta.Nombre = txtParametro3.Text;

                    Consulta.NomTabla = "CitaMedica";
                    Consulta.CadenaComando = $"Select * from CitaMedica where Medico = '{Consulta.Nombre}' ";

                    dataGridView3.DataSource = Consulta.Buscar();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

            if (comboBox3.Text == "Exequatur")
            {
                try
                {
                    Consulta.NomTabla = "CitaMedica";
                    Consulta.CadenaComando = $"Select * from CitaMedica where Medico = '{comboBox4.SelectedValue.ToString()}' ";

                    dataGridView3.DataSource = Consulta.Buscar();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void FormConsultas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'centro_MedicoDataSet1.Medico' table. You can move, or remove it, as needed.
            this.medicoTableAdapter.Fill(this.centro_MedicoDataSet1.Medico);

        }
    }
}
