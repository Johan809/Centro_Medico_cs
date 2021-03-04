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
    public partial class FormMedico : Form
    {
        Medico dr = new Medico();

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

        public void LlenarGrid() //Metodo para el dataview
        {
            dataGridView1.DataSource = dr.Grid();
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


        public FormMedico()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                dr.ID = int.Parse(txtID.Text);
                dr.Nombre = txtNombre.Text;
                dr.Cedula = txtCedula.Text;
                dr.Telefono = txtTelefono.Text;
                dr.Email = txtEmail.Text;
                dr.Exequatur = txtExeq.Text;
                dr.ClinicaLabora = txtClinica.Text;

                dr.Registrar();

                MessageBox.Show("Los datos han sido registrado con Exito");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            CamposVacios();
            LlenarGrid();
            Limpiar();
        }

        private void FormMedico_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                dr.ID = int.Parse(txtID.Text);
                dr.Nombre = txtNombre.Text;
                dr.Cedula = txtCedula.Text;
                dr.Telefono = txtTelefono.Text;
                dr.Email = txtEmail.Text;
                dr.Exequatur = txtExeq.Text;
                dr.ClinicaLabora = txtClinica.Text;

                dr.Actualizar();

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
                dr.ID = int.Parse(txtID.Text);

                dr.Borrar();

                MessageBox.Show("Los datos han sido eliminados con Exito");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            LlenarGrid();
            Limpiar();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
