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
            this.components = new System.ComponentModel.Container();
            this.lab_doc = new System.Windows.Forms.Label();
            this.jc_doctor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Jc_Paciente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Jc_hora = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.jt_desc = new System.Windows.Forms.TextBox();
            this.AgregaCitas = new System.Windows.Forms.Button();
            this.EliminaCita = new System.Windows.Forms.Button();
            this.TablaCliente = new System.Windows.Forms.DataGridView();
            this.hospitalDataSet = new P.HospitalDataSet();
            this.hospitalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteTableAdapter = new P.HospitalDataSetTableAdapters.PacienteTableAdapter();
            this.citasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citasTableAdapter = new P.HospitalDataSetTableAdapters.CitasTableAdapter();
            this.pacienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.citasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jl_cod = new System.Windows.Forms.Label();
            this.jt_cod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.jc_doctor.Items.AddRange(new object[] {
            "Seleccione",
            "Carlos Arguedas",
            "María Zúñiga",
            "Nela Marín"});
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
            this.Jc_Paciente.Items.AddRange(new object[] {
            "Seleccione",
            "Minor Cardenas",
            "Daniel Bonilla",
            "Leonardo León",
            "Maria del Mar Zúñiga",
            "Julio Sánchez",
            "Fiorella Ramírez",
            "Jorge Núñez",
            "Adrián Navarro",
            "Eduardo Bagnarello",
            "Jose Mora"});
            this.Jc_Paciente.Location = new System.Drawing.Point(309, 214);
            this.Jc_Paciente.Name = "Jc_Paciente";
            this.Jc_Paciente.Size = new System.Drawing.Size(121, 21);
            this.Jc_Paciente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hora: ";
            // 
            // Jc_hora
            // 
            this.Jc_hora.FormattingEnabled = true;
            this.Jc_hora.Items.AddRange(new object[] {
            "Seleccione",
            "8:00 a.m",
            "9:00 a.m",
            "10:00 a.m",
            "11:00 a.m",
            "12:00a.m",
            "",
            "",
            ""});
            this.Jc_hora.Location = new System.Drawing.Point(554, 211);
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
            // jt_desc
            // 
            this.jt_desc.BackColor = System.Drawing.SystemColors.Window;
            this.jt_desc.Location = new System.Drawing.Point(114, 249);
            this.jt_desc.Name = "jt_desc";
            this.jt_desc.Size = new System.Drawing.Size(561, 20);
            this.jt_desc.TabIndex = 9;
            // 
            // AgregaCitas
            // 
            this.AgregaCitas.Location = new System.Drawing.Point(76, 289);
            this.AgregaCitas.Name = "AgregaCitas";
            this.AgregaCitas.Size = new System.Drawing.Size(164, 27);
            this.AgregaCitas.TabIndex = 10;
            this.AgregaCitas.Text = "Agregar Citas";
            this.AgregaCitas.UseVisualStyleBackColor = true;
            this.AgregaCitas.Click += new System.EventHandler(this.Jb_agregarCita_Click);
            // 
            // EliminaCita
            // 
            this.EliminaCita.Location = new System.Drawing.Point(469, 292);
            this.EliminaCita.Name = "EliminaCita";
            this.EliminaCita.Size = new System.Drawing.Size(185, 24);
            this.EliminaCita.TabIndex = 11;
            this.EliminaCita.Text = "Eliminar Cita";
            this.EliminaCita.UseVisualStyleBackColor = true;
            this.EliminaCita.Click += new System.EventHandler(this.EliminaCita_Click);
            // 
            // TablaCliente
            // 
            this.TablaCliente.AllowUserToAddRows = false;
            this.TablaCliente.AllowUserToDeleteRows = false;
            this.TablaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaCliente.Location = new System.Drawing.Point(30, 23);
            this.TablaCliente.Name = "TablaCliente";
            this.TablaCliente.ReadOnly = true;
            this.TablaCliente.Size = new System.Drawing.Size(645, 156);
            this.TablaCliente.TabIndex = 12;
            this.TablaCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalDataSetBindingSource
            // 
            this.hospitalDataSetBindingSource.DataSource = this.hospitalDataSet;
            this.hospitalDataSetBindingSource.Position = 0;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.hospitalDataSet;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // citasBindingSource
            // 
            this.citasBindingSource.DataMember = "Citas";
            this.citasBindingSource.DataSource = this.hospitalDataSet;
            // 
            // citasTableAdapter
            // 
            this.citasTableAdapter.ClearBeforeFill = true;
            // 
            // pacienteBindingSource1
            // 
            this.pacienteBindingSource1.DataMember = "Paciente";
            this.pacienteBindingSource1.DataSource = this.hospitalDataSet;
            // 
            // citasBindingSource1
            // 
            this.citasBindingSource1.DataMember = "Citas";
            this.citasBindingSource1.DataSource = this.hospitalDataSet;
            // 
            // jl_cod
            // 
            this.jl_cod.AutoSize = true;
            this.jl_cod.Location = new System.Drawing.Point(312, 295);
            this.jl_cod.Name = "jl_cod";
            this.jl_cod.Size = new System.Drawing.Size(43, 13);
            this.jl_cod.TabIndex = 13;
            this.jl_cod.Text = "Código:";
            // 
            // jt_cod
            // 
            this.jt_cod.Location = new System.Drawing.Point(361, 293);
            this.jt_cod.Name = "jt_cod";
            this.jt_cod.Size = new System.Drawing.Size(100, 20);
            this.jt_cod.TabIndex = 14;
            // 
            // Hora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 331);
            this.Controls.Add(this.jt_cod);
            this.Controls.Add(this.jl_cod);
            this.Controls.Add(this.TablaCliente);
            this.Controls.Add(this.EliminaCita);
            this.Controls.Add(this.AgregaCitas);
            this.Controls.Add(this.jt_desc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Jc_hora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Jc_Paciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jc_doctor);
            this.Controls.Add(this.lab_doc);
            this.Name = "Hora";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Hora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab_doc;
        private System.Windows.Forms.ComboBox jc_doctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Jc_Paciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Jc_hora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jt_desc;
        private System.Windows.Forms.Button AgregaCitas;
        private System.Windows.Forms.Button EliminaCita;
        private System.Windows.Forms.DataGridView TablaCliente;
        private System.Windows.Forms.BindingSource hospitalDataSetBindingSource;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private HospitalDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.BindingSource citasBindingSource;
        private HospitalDataSetTableAdapters.CitasTableAdapter citasTableAdapter;
        private System.Windows.Forms.BindingSource pacienteBindingSource1;
        private System.Windows.Forms.BindingSource citasBindingSource1;
        private System.Windows.Forms.Label jl_cod;
        private System.Windows.Forms.TextBox jt_cod;
    }
}

