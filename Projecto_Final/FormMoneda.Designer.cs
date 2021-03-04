namespace Projecto_Final
{
    partial class FormMoneda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMoneda));
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MonOrigList = new System.Windows.Forms.ComboBox();
            this.MonDestList = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.labelresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMoneda
            // 
            this.txtMoneda.Location = new System.Drawing.Point(171, 112);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(116, 23);
            this.txtMoneda.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escriba el monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Moneda Origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Moneda Destino";
            // 
            // MonOrigList
            // 
            this.MonOrigList.FormattingEnabled = true;
            this.MonOrigList.Items.AddRange(new object[] {
            "Peso Dom.",
            "Dolar",
            "Euro"});
            this.MonOrigList.Location = new System.Drawing.Point(14, 33);
            this.MonOrigList.Name = "MonOrigList";
            this.MonOrigList.Size = new System.Drawing.Size(140, 23);
            this.MonOrigList.TabIndex = 4;
            // 
            // MonDestList
            // 
            this.MonDestList.FormattingEnabled = true;
            this.MonDestList.Items.AddRange(new object[] {
            "Peso Dom.",
            "Dolar",
            "Euro"});
            this.MonDestList.Location = new System.Drawing.Point(310, 33);
            this.MonDestList.Name = "MonDestList";
            this.MonDestList.Size = new System.Drawing.Size(140, 23);
            this.MonDestList.TabIndex = 5;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(84, 195);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(87, 27);
            this.btnConvertir.TabIndex = 6;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.BtnConvertir_Click);
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.BackColor = System.Drawing.Color.Transparent;
            this.labelresult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelresult.Location = new System.Drawing.Point(283, 201);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(62, 15);
            this.labelresult.TabIndex = 7;
            this.labelresult.Text = "Resultado";
            // 
            // FormMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projecto_Final.Properties.Resources.Blanco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 283);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.MonDestList);
            this.Controls.Add(this.MonOrigList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoneda);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMoneda";
            this.Text = "Conversor de Moneda";
            this.Load += new System.EventHandler(this.FormMoneda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MonOrigList;
        private System.Windows.Forms.ComboBox MonDestList;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label labelresult;
    }
}