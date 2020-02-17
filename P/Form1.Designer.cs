namespace P
{
    partial class Hora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TablaCliente = new System.Windows.Forms.DataGridView();
            this.lab_doc = new System.Windows.Forms.Label();
            this.jc_doctor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Jc_Paciente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Jc_hora = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AgregaCitas = new System.Windows.Forms.Button();
            this.EliminaCita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaCliente
            // 
            this.TablaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaCliente.Location = new System.Drawing.Point(12, 27);
            this.TablaCliente.Name = "TablaCliente";
            this.TablaCliente.Size = new System.Drawing.Size(776, 180);
            this.TablaCliente.TabIndex = 1;
            this.TablaCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lab_doc
            // 
            this.lab_doc.AutoSize = true;
            this.lab_doc.Location = new System.Drawing.Point(24, 214);
            this.lab_doc.Name = "lab_doc";
            this.lab_doc.Size = new System.Drawing.Size(45, 13);
            this.lab_doc.TabIndex = 2;
            this.lab_doc.Text = "Doctor: ";
            // 
            // jc_doctor
            // 
            this.jc_doctor.FormattingEnabled = true;
            this.jc_doctor.Location = new System.Drawing.Point(76, 214);
            this.jc_doctor.Name = "jc_doctor";
            this.jc_doctor.Size = new System.Drawing.Size(121, 21);
            this.jc_doctor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Paciente:";
            // 
            // Jc_Paciente
            // 
            this.Jc_Paciente.FormattingEnabled = true;
            this.Jc_Paciente.Location = new System.Drawing.Point(309, 214);
            this.Jc_Paciente.Name = "Jc_Paciente";
            this.Jc_Paciente.Size = new System.Drawing.Size(121, 21);
            this.Jc_Paciente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hora: ";
            // 
            // Jc_hora
            // 
            this.Jc_hora.FormattingEnabled = true;
            this.Jc_hora.Location = new System.Drawing.Point(575, 217);
            this.Jc_hora.Name = "Jc_hora";
            this.Jc_hora.Size = new System.Drawing.Size(121, 21);
            this.Jc_hora.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Observaciones:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 249);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(673, 20);
            this.textBox1.TabIndex = 9;
            // 
            // AgregaCitas
            // 
            this.AgregaCitas.Location = new System.Drawing.Point(76, 289);
            this.AgregaCitas.Name = "AgregaCitas";
            this.AgregaCitas.Size = new System.Drawing.Size(164, 27);
            this.AgregaCitas.TabIndex = 10;
            this.AgregaCitas.Text = "Agregar Citas";
            this.AgregaCitas.UseVisualStyleBackColor = true;
            // 
            // EliminaCita
            // 
            this.EliminaCita.Location = new System.Drawing.Point(469, 292);
            this.EliminaCita.Name = "EliminaCita";
            this.EliminaCita.Size = new System.Drawing.Size(185, 24);
            this.EliminaCita.TabIndex = 11;
            this.EliminaCita.Text = "Eliminar Cita";
            this.EliminaCita.UseVisualStyleBackColor = true;
            // 
            // Hora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 345);
            this.Controls.Add(this.EliminaCita);
            this.Controls.Add(this.AgregaCitas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Jc_hora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Jc_Paciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jc_doctor);
            this.Controls.Add(this.lab_doc);
            this.Controls.Add(this.TablaCliente);
            this.Name = "Hora";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TablaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView TablaCliente;
        private System.Windows.Forms.Label lab_doc;
        private System.Windows.Forms.ComboBox jc_doctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Jc_Paciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Jc_hora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AgregaCitas;
        private System.Windows.Forms.Button EliminaCita;
    }
}

