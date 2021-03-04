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
    public partial class FormClinica : Form
    {
        Clinica cl = new Clinica();
        public FormClinica()
        {
            InitializeComponent();
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

        public void LlenarGrid() //Metodo para el dataview
        {
            dataGridView1.DataSource = cl.Grid();
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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            LlenarGrid();
        }

        private void FormClinica_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                cl.ID = int.Parse(txtID.Text);
                cl.Nombre = txtNombre.Text;
                cl.Direccion = txtDireccion.Text;

                cl.Registrar();

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

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                cl.ID = int.Parse(txtID.Text);
                cl.Nombre = txtNombre.Text;
                cl.Direccion = txtDireccion.Text;

                cl.Actualizar();

                MessageBox.Show("Los datos han sido actualizado con Exito");
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
                cl.ID = int.Parse(txtID.Text);
                

                cl.Borrar();

                MessageBox.Show("Los datos han sido eliminados con Exito");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            LlenarGrid();
            Limpiar();
        }
    }
}
