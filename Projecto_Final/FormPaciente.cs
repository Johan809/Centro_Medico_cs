using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_Final
{
    public partial class FormPaciente : Form
    {
        Paciente pac = new Paciente();

        public FormPaciente()
        {
            InitializeComponent();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e) //Boton LImpiar
        {
            Limpiar();
            LlenarGrid();
        }

        public void Limpiar() //Metodo para Limpiar
        {
            foreach (Control tool in this.groupBox1.Controls)
            {
                if (tool is TextBox)
                {
                    tool.Text = "";
                }
            }
        }

        public void CamposVacios() //Metodo para evitar campos vacios
        {
            foreach(Control lim in Controls)
            {
                if(lim is TextBox)
                {
                    if (string.IsNullOrEmpty(lim.Text))
                    {
                        MessageBox.Show("Debe completar la informacion.");
                    }
                }
            }
        }

        public void LlenarGrid() //Metodo para el dataview
        {
            dataGridView1.DataSource = pac.Grid();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                pac.ID = int.Parse(txtID.Text);
                pac.Nombre = txtNombre.Text;
                pac.Cedula = txtCedula.Text;
                pac.Telefono = txtTelefono.Text;
                pac.Email = txtEmail.Text;
                pac.Direccion = txtDireccion.Text;

                pac.Registrar();

                MessageBox.Show("Los datos han sido registrado con Exito");
            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            CamposVacios();
            LlenarGrid();
            Limpiar();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                pac.ID = int.Parse(txtID.Text);
                pac.Nombre = txtNombre.Text;
                pac.Cedula = txtCedula.Text;
                pac.Telefono = txtTelefono.Text;
                pac.Email = txtEmail.Text;
                pac.Direccion = txtDireccion.Text;

                pac.Actualizar();

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

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                pac.ID = int.Parse(txtID.Text);

                pac.Borrar();

                MessageBox.Show("Los datos han sido eliminados con Exito");
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            LlenarGrid();
            Limpiar();
        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }
    }
}
