namespace HotelTesinaVersion2.Formularios.Consumiciones
{
    partial class FormEliminarConsumicion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarConsumicion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAgregarConsumicion);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(50, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 239);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los Datos  ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(243, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seleccione la consumicion";
            // 
            // btnAgregarConsumicion
            // 
            this.btnAgregarConsumicion.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarConsumicion.Location = new System.Drawing.Point(140, 117);
            this.btnAgregarConsumicion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarConsumicion.Name = "btnAgregarConsumicion";
            this.btnAgregarConsumicion.Size = new System.Drawing.Size(156, 47);
            this.btnAgregarConsumicion.TabIndex = 8;
            this.btnAgregarConsumicion.Text = "Eliminar Consumicion";
            this.btnAgregarConsumicion.UseVisualStyleBackColor = true;
            this.btnAgregarConsumicion.Click += new System.EventHandler(this.btnAgregarConsumicion_Click);
            // 
            // FormEliminarConsumicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(552, 315);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEliminarConsumicion";
            this.Text = "FormEliminarConsumicion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarConsumicion;
    }
}