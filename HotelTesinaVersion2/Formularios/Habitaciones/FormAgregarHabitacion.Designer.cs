namespace HotelTesinaVersion2.Formularios.Habitaciones
{
    partial class FormAgregarHabitacion
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
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboxTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumHabitacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxEstado
            // 
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Disponible",
            "Ocupado",
            "Sin Servicio"});
            this.cboxEstado.Location = new System.Drawing.Point(277, 75);
            this.cboxEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(108, 24);
            this.cboxEstado.TabIndex = 12;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(139, 209);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(156, 47);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar Nueva Habitacion";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboxTipoHabitacion
            // 
            this.cboxTipoHabitacion.FormattingEnabled = true;
            this.cboxTipoHabitacion.Location = new System.Drawing.Point(277, 155);
            this.cboxTipoHabitacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxTipoHabitacion.Name = "cboxTipoHabitacion";
            this.cboxTipoHabitacion.Size = new System.Drawing.Size(179, 24);
            this.cboxTipoHabitacion.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tipo de Habitacion";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(277, 116);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(80, 22);
            this.txtPrecio.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ingrese el Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Estado";
            // 
            // txtNumHabitacion
            // 
            this.txtNumHabitacion.Location = new System.Drawing.Point(277, 36);
            this.txtNumHabitacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumHabitacion.Name = "txtNumHabitacion";
            this.txtNumHabitacion.Size = new System.Drawing.Size(108, 22);
            this.txtNumHabitacion.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ingrese Numero de Habitacion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboxEstado);
            this.groupBox1.Controls.Add(this.txtNumHabitacion);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboxTipoHabitacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(120, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 275);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // FormAgregarHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(729, 396);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAgregarHabitacion";
            this.Text = "FormAgregarMateria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboxTipoHabitacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumHabitacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}