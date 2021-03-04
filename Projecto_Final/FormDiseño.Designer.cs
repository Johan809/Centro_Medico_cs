namespace Projecto_Final
{
    partial class FormDiseño
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiseño));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnMini = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.BarraMenu = new System.Windows.Forms.Panel();
            this.SubMenu = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnClinica = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnMedico = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnMoneda = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCitaMedica = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOld = new System.Windows.Forms.Button();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.BarraMenu.SuspendLayout();
            this.SubMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.btnMini);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(829, 33);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnMini
            // 
            this.btnMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMini.Image = global::Projecto_Final.Properties.Resources.mini;
            this.btnMini.Location = new System.Drawing.Point(770, 3);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(25, 25);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMini.TabIndex = 1;
            this.btnMini.TabStop = false;
            this.btnMini.Click += new System.EventHandler(this.BtnMini_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Projecto_Final.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(801, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BarraMenu
            // 
            this.BarraMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraMenu.Controls.Add(this.SubMenu);
            this.BarraMenu.Controls.Add(this.panel9);
            this.BarraMenu.Controls.Add(this.panel10);
            this.BarraMenu.Controls.Add(this.btnMoneda);
            this.BarraMenu.Controls.Add(this.panel6);
            this.BarraMenu.Controls.Add(this.panel8);
            this.BarraMenu.Controls.Add(this.btnConsulta);
            this.BarraMenu.Controls.Add(this.panel4);
            this.BarraMenu.Controls.Add(this.panel5);
            this.BarraMenu.Controls.Add(this.btnCitaMedica);
            this.BarraMenu.Controls.Add(this.panel7);
            this.BarraMenu.Controls.Add(this.panel2);
            this.BarraMenu.Controls.Add(this.btnRegistro);
            this.BarraMenu.Controls.Add(this.panel1);
            this.BarraMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraMenu.Location = new System.Drawing.Point(0, 33);
            this.BarraMenu.Name = "BarraMenu";
            this.BarraMenu.Size = new System.Drawing.Size(196, 428);
            this.BarraMenu.TabIndex = 1;
            this.BarraMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraMenu_Paint);
            this.BarraMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BarraMenu_MouseClick);
            // 
            // SubMenu
            // 
            this.SubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.SubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SubMenu.Controls.Add(this.panel14);
            this.SubMenu.Controls.Add(this.btnClinica);
            this.SubMenu.Controls.Add(this.panel12);
            this.SubMenu.Controls.Add(this.btnMedico);
            this.SubMenu.Controls.Add(this.panel13);
            this.SubMenu.Controls.Add(this.btnPaciente);
            this.SubMenu.Location = new System.Drawing.Point(22, 197);
            this.SubMenu.Name = "SubMenu";
            this.SubMenu.Size = new System.Drawing.Size(174, 130);
            this.SubMenu.TabIndex = 0;
            this.SubMenu.Visible = false;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(200)))));
            this.panel14.Location = new System.Drawing.Point(0, 85);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(8, 35);
            this.panel14.TabIndex = 24;
            // 
            // btnClinica
            // 
            this.btnClinica.FlatAppearance.BorderSize = 0;
            this.btnClinica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(200)))));
            this.btnClinica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClinica.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinica.ForeColor = System.Drawing.Color.White;
            this.btnClinica.Location = new System.Drawing.Point(6, 85);
            this.btnClinica.Name = "btnClinica";
            this.btnClinica.Size = new System.Drawing.Size(168, 35);
            this.btnClinica.TabIndex = 23;
            this.btnClinica.Text = "Clinica";
            this.btnClinica.UseVisualStyleBackColor = true;
            this.btnClinica.Click += new System.EventHandler(this.BtnClinica_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(200)))));
            this.panel12.Location = new System.Drawing.Point(0, 46);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(8, 35);
            this.panel12.TabIndex = 22;
            // 
            // btnMedico
            // 
            this.btnMedico.FlatAppearance.BorderSize = 0;
            this.btnMedico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(200)))));
            this.btnMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedico.ForeColor = System.Drawing.Color.White;
            this.btnMedico.Location = new System.Drawing.Point(7, 46);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(164, 35);
            this.btnMedico.TabIndex = 21;
            this.btnMedico.Text = "Medico";
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.BtnMedico_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(200)))));
            this.panel13.Location = new System.Drawing.Point(0, 7);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(8, 35);
            this.panel13.TabIndex = 20;
            // 
            // btnPaciente
            // 
            this.btnPaciente.FlatAppearance.BorderSize = 0;
            this.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(200)))));
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.ForeColor = System.Drawing.Color.White;
            this.btnPaciente.Location = new System.Drawing.Point(6, 7);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(165, 35);
            this.btnPaciente.TabIndex = 19;
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.BtnPaciente_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BackgroundImage = global::Projecto_Final.Properties.Resources.moneda2;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Location = new System.Drawing.Point(22, 286);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(24, 23);
            this.panel9.TabIndex = 18;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(200)))));
            this.panel10.Location = new System.Drawing.Point(0, 279);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(8, 35);
            this.panel10.TabIndex = 17;
            // 
            // btnMoneda
            // 
            this.btnMoneda.FlatAppearance.BorderSize = 0;
            this.btnMoneda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(200)))));
            this.btnMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoneda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoneda.ForeColor = System.Drawing.Color.White;
            this.btnMoneda.Location = new System.Drawing.Point(3, 279);
            this.btnMoneda.Name = "btnMoneda";
            this.btnMoneda.Size = new System.Drawing.Size(193, 35);
            this.btnMoneda.TabIndex = 16;
            this.btnMoneda.Text = "Conversor";
            this.btnMoneda.UseVisualStyleBackColor = true;
            this.btnMoneda.Click += new System.EventHandler(this.BtnMoneda_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = global::Projecto_Final.Properties.Resources.newconsultas;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(22, 245);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(24, 23);
            this.panel6.TabIndex = 15;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(200)))));
            this.panel8.Location = new System.Drawing.Point(0, 238);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(8, 35);
            this.panel8.TabIndex = 14;
            // 
            // btnConsulta
            // 
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(200)))));
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(3, 238);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(193, 35);
            this.btnConsulta.TabIndex = 13;
            this.btnConsulta.Text = "Consultas";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::Projecto_Final.Properties.Resources.cita;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(22, 204);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(24, 23);
            this.panel4.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(0, 197);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(8, 35);
            this.panel5.TabIndex = 11;
            // 
            // btnCitaMedica
            // 
            this.btnCitaMedica.FlatAppearance.BorderSize = 0;
            this.btnCitaMedica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(200)))));
            this.btnCitaMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitaMedica.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitaMedica.ForeColor = System.Drawing.Color.White;
            this.btnCitaMedica.Location = new System.Drawing.Point(3, 197);
            this.btnCitaMedica.Name = "btnCitaMedica";
            this.btnCitaMedica.Size = new System.Drawing.Size(193, 35);
            this.btnCitaMedica.TabIndex = 10;
            this.btnCitaMedica.Text = "Cita Medica";
            this.btnCitaMedica.UseVisualStyleBackColor = true;
            this.btnCitaMedica.Click += new System.EventHandler(this.BtnCitaMedica_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BackgroundImage = global::Projecto_Final.Properties.Resources.newpersona;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(22, 165);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(24, 23);
            this.panel7.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(0, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 35);
            this.panel2.TabIndex = 2;
            // 
            // btnRegistro
            // 
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(200)))));
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.Location = new System.Drawing.Point(3, 158);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(193, 35);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.BtnRegistro_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Projecto_Final.Properties.Resources.icono1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(22, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 111);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Projecto_Final.Properties.Resources.Logo_Centro_Medico;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.btnOld);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(196, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 428);
            this.panel3.TabIndex = 2;
            // 
            // btnOld
            // 
            this.btnOld.BackColor = System.Drawing.Color.Transparent;
            this.btnOld.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(200)))));
            this.btnOld.FlatAppearance.BorderSize = 0;
            this.btnOld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOld.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(200)))));
            this.btnOld.Location = new System.Drawing.Point(0, 0);
            this.btnOld.Name = "btnOld";
            this.btnOld.Size = new System.Drawing.Size(75, 23);
            this.btnOld.TabIndex = 1;
            this.btnOld.UseVisualStyleBackColor = false;
            this.btnOld.Click += new System.EventHandler(this.BtnOld_Click);
            // 
            // FormDiseño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BarraMenu);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDiseño";
            this.Text = "Sistema Centro Medico";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.BarraMenu.ResumeLayout(false);
            this.SubMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel BarraMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMini;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnMoneda;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCitaMedica;
        private System.Windows.Forms.Panel SubMenu;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnClinica;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnOld;
    }
}