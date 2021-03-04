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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void ConversorDeMonedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMoneda moneda = new FormMoneda();
            moneda.Show();
        }

        private void PacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPaciente paciente = new FormPaciente();
            paciente.Show();
        }

        private void MedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMedico medico = new FormMedico();
            medico.Show();
        }

        private void ClinicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClinica clinica = new FormClinica();
            clinica.Show();
        }

        private void CitaMedicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCita cita = new FormCita();
            cita.Show();
        }

        private void ConsultarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultas consultas = new FormConsultas();
            consultas.Show();
        }

        private void DesignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDiseño design = new FormDiseño();
            design.Show();
            Close();
        }
    }
}
