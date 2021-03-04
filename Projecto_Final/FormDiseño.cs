using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Projecto_Final
{
    public partial class FormDiseño : Form
    {
        public FormDiseño()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0); 
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            SubMenu.Visible = true;
        }

        private void BtnPaciente_Click(object sender, EventArgs e)
        {
            SubMenu.Visible = false;
            FormPaciente pac = new FormPaciente();
            pac.Show();
        }

        private void BtnMedico_Click(object sender, EventArgs e)
        {
            SubMenu.Visible = false;
            FormMedico med = new FormMedico();
            med.Show();
        }

        private void BtnClinica_Click(object sender, EventArgs e)
        {
            SubMenu.Visible = false;
            FormClinica cli = new FormClinica();
            cli.Show();
        }

        private void BtnOld_Click(object sender, EventArgs e)
        {
            Form1 old = new Form1();
            old.Show();
            Hide();
        }

        private void BtnCitaMedica_Click(object sender, EventArgs e)
        {
            FormCita cita = new FormCita();
            cita.Show();
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            FormConsultas con = new FormConsultas();
            con.Show();
        }

        private void BtnMoneda_Click(object sender, EventArgs e)
        {
            FormMoneda coin = new FormMoneda();
            coin.Show();
        }

        private void BarraMenu_Paint(object sender, PaintEventArgs e)
        {
            //Aqui iba una prueba fallida
        }

        private void BarraMenu_MouseClick(object sender, MouseEventArgs e)
        {
            SubMenu.Visible = false;
        }
    }
}
