namespace HotelTesinaVersion2.Formularios.Habitaciones
{
    partial class FormModificarHabitacion
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
            this.cboboxHabitacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.txtNumHabitacion = new System.Windows.Forms.TextBox();
            this.btnModificarHabitacion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboboxHabitacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboxEstado);
            this.groupBox1.Controls.Add(this.txtNumHabitacion);
            this.groupBox1.Controls.Add(this.btnModificarHabitacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboxTipoHabitacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Location = new System.Drawing.Point(86, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 338);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // cboboxHabitacion
            // 
            this.cboboxHabitacion.FormattingEnabled = true;
            this.cboboxHabitacion.Location = new System.Drawing.Point(315, 51);
            this.cboboxHabitacion.Name = "cboboxHabitacion";
            this.cboboxHabitacion.Size = new System.Drawing.Size(121, 24);
            this.cboboxHabitacion.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Seleccione la habitacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ingrese Numero de Habitacion";
            // 
            // cboxEstado
            // 
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Disponible",
            "Ocupado",
            "Sin Servicio"});
            this.cboxEstado.Location = new System.Drawing.Point(315, 139);
            this.cboxEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(108, 24);
            this.cboxEstado.TabIndex = 12;
            // 
            // txtNumHabitacion
            // 
            this.txtNumHabitacion.Location = new System.Drawing.Point(315, 100);
            this.txtNumHabitacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumHabitacion.Name = "txtNumHabitacion";
            this.txtNumHabitacion.Size = new System.Drawing.Size(108, 22);
            this.txtNumHabitacion.TabIndex = 17;
            // 
            // btnModificarHabitacion
            // 
            this.btnModificarHabitacion.ForeColor = System.Drawing.Color.Black;
            this.btnModificarHabitacion.Location = new System.Drawing.Point(177, 273);
            this.btnModificarHabitacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarHabitacion.Name = "btnModificarHabitacion";
            this.btnModificarHabitacion.Size = new System.Drawing.Size(156, 47);
            this.btnModificarHabitacion.TabIndex = 15;
            this.btnModificarHabitacion.Text = "Modificar Habitacion";
            this.btnModificarHabitacion.UseVisualStyleBackColor = true;
            this.btnModificarHabitacion.Click += new System.EventHandler(this.btnModificarHabitacion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Estado";
            // 
            // cboxTipoHabitacion
            // 
            this.cboxTipoHabitacion.FormattingEnabled = true;
            this.cboxTipoHabitacion.Location = new System.Drawing.Point(315, 219);
            this.cboxTipoHabitacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxTipoHabitacion.Name = "cboxTipoHabitacion";
            this.cboxTipoHabitacion.Size = new System.Drawing.Size(179, 24);
            this.cboxTipoHabitacion.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ingrese el Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tipo de Habitacion";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(315, 180);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(80, 22);
            this.txtPrecio.TabIndex = 20;
            // 
            // FormModificarHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(720, 403);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormModificarHabitacion";
            this.Text = "FormModificarHabitacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.TextBox txtNumHabitacion;
        private System.Windows.Forms.Button btnModificarHabitacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxTipoHabitacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cboboxHabitacion;
        private System.Windows.Forms.Label label1;
    }
}