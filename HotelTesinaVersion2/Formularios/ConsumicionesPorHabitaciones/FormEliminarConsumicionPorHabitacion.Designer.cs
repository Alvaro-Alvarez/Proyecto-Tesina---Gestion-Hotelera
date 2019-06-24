namespace HotelTesinaVersion2.Formularios.ConsumicionesPorHabitaciones
{
    partial class FormEliminarConsumicionPorHabitacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarConsumicion = new System.Windows.Forms.Button();
            this.dataGridViewConsumiciones = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarConsumicion);
            this.groupBox1.Controls.Add(this.dataGridViewConsumiciones);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(53, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la consumicion ";
            // 
            // btnEliminarConsumicion
            // 
            this.btnEliminarConsumicion.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarConsumicion.Location = new System.Drawing.Point(205, 273);
            this.btnEliminarConsumicion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarConsumicion.Name = "btnEliminarConsumicion";
            this.btnEliminarConsumicion.Size = new System.Drawing.Size(156, 47);
            this.btnEliminarConsumicion.TabIndex = 19;
            this.btnEliminarConsumicion.Text = "Eliminar Consumicion";
            this.btnEliminarConsumicion.UseVisualStyleBackColor = true;
            this.btnEliminarConsumicion.Click += new System.EventHandler(this.btnEliminarConsumicion_Click);
            // 
            // dataGridViewConsumiciones
            // 
            this.dataGridViewConsumiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewConsumiciones.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewConsumiciones.Location = new System.Drawing.Point(24, 37);
            this.dataGridViewConsumiciones.Name = "dataGridViewConsumiciones";
            this.dataGridViewConsumiciones.RowTemplate.Height = 24;
            this.dataGridViewConsumiciones.Size = new System.Drawing.Size(620, 219);
            this.dataGridViewConsumiciones.TabIndex = 0;
            // 
            // FormEliminarConsumicionPorHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(776, 377);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEliminarConsumicionPorHabitacion";
            this.Text = "FormEliminarConsumicionPorHabitacion";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumiciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewConsumiciones;
        private System.Windows.Forms.Button btnEliminarConsumicion;
    }
}