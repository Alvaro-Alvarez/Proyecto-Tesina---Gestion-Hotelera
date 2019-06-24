namespace HotelTesinaVersion2.Formularios.ConsumicionesPorHabitaciones
{
    partial class FormAgregarConsumicionPorHabitacion
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
            this.datePickerConsumcion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarConsumicion = new System.Windows.Forms.Button();
            this.cboboxHabitacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboboxConsumicion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datePickerConsumcion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRegistrarConsumicion);
            this.groupBox1.Controls.Add(this.cboboxHabitacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboboxConsumicion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(103, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione";
            // 
            // datePickerConsumcion
            // 
            this.datePickerConsumcion.Location = new System.Drawing.Point(265, 149);
            this.datePickerConsumcion.Name = "datePickerConsumcion";
            this.datePickerConsumcion.Size = new System.Drawing.Size(200, 22);
            this.datePickerConsumcion.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Seleccione  fecha ";
            // 
            // btnRegistrarConsumicion
            // 
            this.btnRegistrarConsumicion.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarConsumicion.Location = new System.Drawing.Point(151, 212);
            this.btnRegistrarConsumicion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarConsumicion.Name = "btnRegistrarConsumicion";
            this.btnRegistrarConsumicion.Size = new System.Drawing.Size(156, 47);
            this.btnRegistrarConsumicion.TabIndex = 18;
            this.btnRegistrarConsumicion.Text = "Registrar Consumicion";
            this.btnRegistrarConsumicion.UseVisualStyleBackColor = true;
            this.btnRegistrarConsumicion.Click += new System.EventHandler(this.btnRegistrarConsumicion_Click);
            // 
            // cboboxHabitacion
            // 
            this.cboboxHabitacion.FormattingEnabled = true;
            this.cboboxHabitacion.Location = new System.Drawing.Point(265, 110);
            this.cboboxHabitacion.Name = "cboboxHabitacion";
            this.cboboxHabitacion.Size = new System.Drawing.Size(200, 24);
            this.cboboxHabitacion.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Seleccione la habitacion";
            // 
            // cboboxConsumicion
            // 
            this.cboboxConsumicion.FormattingEnabled = true;
            this.cboboxConsumicion.Location = new System.Drawing.Point(265, 67);
            this.cboboxConsumicion.Name = "cboboxConsumicion";
            this.cboboxConsumicion.Size = new System.Drawing.Size(200, 24);
            this.cboboxConsumicion.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Seleccione la consumicion";
            // 
            // FormAgregarConsumicionPorHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(702, 474);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAgregarConsumicionPorHabitacion";
            this.Text = "FormAgregarConsumicionPorHabitacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboboxHabitacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboboxConsumicion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrarConsumicion;
        private System.Windows.Forms.DateTimePicker datePickerConsumcion;
        private System.Windows.Forms.Label label1;
    }
}