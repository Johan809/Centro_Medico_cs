namespace Projecto_Final
{
    partial class FormConsultas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSeleccion1 = new System.Windows.Forms.Button();
            this.txtParametro1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtParametro2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.btnSeleccion2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.centro_MedicoDataSet1 = new Projecto_Final.Centro_MedicoDataSet1();
            this.btnSeleccionar3 = new System.Windows.Forms.Button();
            this.txtParametro3 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btnBuscar3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.medicoTableAdapter = new Projecto_Final.Centro_MedicoDataSet1TableAdapters.MedicoTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centro_MedicoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(544, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.btnSeleccion1);
            this.tabPage1.Controls.Add(this.txtParametro1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtBuscar1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(536, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Paciente";
            // 
            // btnSeleccion1
            // 
            this.btnSeleccion1.Location = new System.Drawing.Point(313, 44);
            this.btnSeleccion1.Name = "btnSeleccion1";
            this.btnSeleccion1.Size = new System.Drawing.Size(87, 25);
            this.btnSeleccion1.TabIndex = 10;
            this.btnSeleccion1.Text = "Seleccionar";
            this.btnSeleccion1.UseVisualStyleBackColor = true;
            this.btnSeleccion1.Click += new System.EventHandler(this.BtnSeleccion_Click);
            // 
            // txtParametro1
            // 
            this.txtParametro1.Location = new System.Drawing.Point(330, 126);
            this.txtParametro1.Name = "txtParametro1";
            this.txtParametro1.Size = new System.Drawing.Size(140, 22);
            this.txtParametro1.TabIndex = 9;
            this.txtParametro1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nombre",
            "Email"});
            this.comboBox1.Location = new System.Drawing.Point(133, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 22);
            this.comboBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione un Parametro de Busqueda: ";
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.Location = new System.Drawing.Point(230, 191);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(87, 25);
            this.txtBuscar1.TabIndex = 5;
            this.txtBuscar1.Text = "Buscar";
            this.txtBuscar1.UseVisualStyleBackColor = true;
            this.txtBuscar1.Click += new System.EventHandler(this.TxtBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(9, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 144);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.txtParametro2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnBuscar2);
            this.tabPage2.Controls.Add(this.btnSeleccion2);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(536, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Medico";
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // txtParametro2
            // 
            this.txtParametro2.Location = new System.Drawing.Point(330, 126);
            this.txtParametro2.Name = "txtParametro2";
            this.txtParametro2.Size = new System.Drawing.Size(140, 22);
            this.txtParametro2.TabIndex = 6;
            this.txtParametro2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.Location = new System.Drawing.Point(230, 191);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(87, 25);
            this.btnBuscar2.TabIndex = 4;
            this.btnBuscar2.Text = "Buscar";
            this.btnBuscar2.UseVisualStyleBackColor = true;
            this.btnBuscar2.Click += new System.EventHandler(this.BtnBuscar2_Click);
            // 
            // btnSeleccion2
            // 
            this.btnSeleccion2.Location = new System.Drawing.Point(313, 44);
            this.btnSeleccion2.Name = "btnSeleccion2";
            this.btnSeleccion2.Size = new System.Drawing.Size(87, 25);
            this.btnSeleccion2.TabIndex = 3;
            this.btnSeleccion2.Text = "Seleccionar";
            this.btnSeleccion2.UseVisualStyleBackColor = true;
            this.btnSeleccion2.Click += new System.EventHandler(this.BtnSeleccion2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Nombre",
            "Exequatur"});
            this.comboBox2.Location = new System.Drawing.Point(133, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 22);
            this.comboBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Seleccione un Parametro de Busqueda:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 272);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(521, 144);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage3.Controls.Add(this.comboBox4);
            this.tabPage3.Controls.Add(this.btnSeleccionar3);
            this.tabPage3.Controls.Add(this.txtParametro3);
            this.tabPage3.Controls.Add(this.comboBox3);
            this.tabPage3.Controls.Add(this.btnBuscar3);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(536, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Citas Médicas ";
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.medicoBindingSource, "Exequatur", true));
            this.comboBox4.DataSource = this.medicoBindingSource;
            this.comboBox4.DisplayMember = "Exequatur";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(323, 120);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(140, 22);
            this.comboBox4.TabIndex = 10;
            this.comboBox4.ValueMember = "Nombre";
            this.comboBox4.Visible = false;
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataMember = "Medico";
            this.medicoBindingSource.DataSource = this.centro_MedicoDataSet1;
            // 
            // centro_MedicoDataSet1
            // 
            this.centro_MedicoDataSet1.DataSetName = "Centro_MedicoDataSet1";
            this.centro_MedicoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSeleccionar3
            // 
            this.btnSeleccionar3.Location = new System.Drawing.Point(323, 57);
            this.btnSeleccionar3.Name = "btnSeleccionar3";
            this.btnSeleccionar3.Size = new System.Drawing.Size(87, 25);
            this.btnSeleccionar3.TabIndex = 9;
            this.btnSeleccionar3.Text = "Seleccionar";
            this.btnSeleccionar3.UseVisualStyleBackColor = true;
            this.btnSeleccionar3.Click += new System.EventHandler(this.BtnSeleccionar3_Click);
            // 
            // txtParametro3
            // 
            this.txtParametro3.Location = new System.Drawing.Point(323, 120);
            this.txtParametro3.Name = "txtParametro3";
            this.txtParametro3.Size = new System.Drawing.Size(140, 22);
            this.txtParametro3.TabIndex = 8;
            this.txtParametro3.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Nombre",
            "Exequatur"});
            this.comboBox3.Location = new System.Drawing.Point(110, 59);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(140, 22);
            this.comboBox3.TabIndex = 7;
            // 
            // btnBuscar3
            // 
            this.btnBuscar3.Location = new System.Drawing.Point(217, 198);
            this.btnBuscar3.Name = "btnBuscar3";
            this.btnBuscar3.Size = new System.Drawing.Size(87, 25);
            this.btnBuscar3.TabIndex = 6;
            this.btnBuscar3.Text = "Buscar";
            this.btnBuscar3.UseVisualStyleBackColor = true;
            this.btnBuscar3.Click += new System.EventHandler(this.BtnBuscar3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "Opciones para filtrar por Medico: ";
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(9, 267);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(521, 143);
            this.dataGridView3.TabIndex = 0;
            // 
            // medicoTableAdapter
            // 
            this.medicoTableAdapter.ClearBeforeFill = true;
            // 
            // FormConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projecto_Final.Properties.Resources.Degradado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 470);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormConsultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.FormConsultas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centro_MedicoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button txtBuscar1;
        private System.Windows.Forms.Button btnSeleccion1;
        private System.Windows.Forms.TextBox txtParametro1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParametro2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.Button btnSeleccion2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnBuscar3;
        private System.Windows.Forms.Button btnSeleccionar3;
        private System.Windows.Forms.TextBox txtParametro3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private Centro_MedicoDataSet1 centro_MedicoDataSet1;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private Centro_MedicoDataSet1TableAdapters.MedicoTableAdapter medicoTableAdapter;
    }
}