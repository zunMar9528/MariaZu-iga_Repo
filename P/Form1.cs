using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using AccesoDatos1;
using Entidades1;

namespace P
{
    public partial class Hora : Form
    {
        Proceso1 proces = new Proceso1();
        Citas cita = new Citas();
        Cliente clien = new Cliente();
        Doctor doctor = new Doctor();

        public Hora()
        {
            InitializeComponent();
            FiltrarListaPersona();
            InsertarTabla();
        }

        void InsertarTabla()
        {
            DataTable dt = new DataTable();


            if ((dt = proces.CitasTabla()) != null)
            {
                TablaCliente.DataSource = dt;
            }


            //dt.Columns.Add("Hola");
            //dt.Columns.Add("Adios");
            //dt.Columns.Add("Hi");
            //dt.Columns.Add("Chao");
            //DataRow row = dt.NewRow() ;
            //row[0] = "N";
            //row[1] = "NN";
            //row[2] = "NNN";
            //row[3] = "NNNN";
            //dt.Rows.Add(row);
            //Jd_dataGrid.DataSource = dt;

        }

        void FiltrarListaPersona()
        {
            List<object> lista;

            lista = proces.ReturListaPersona();

            foreach (var item in lista)
            {
                if (item is Cliente)
                {

                }
                else if (item is Doctor)
                {

                }
            }
        }

        private void Jb_agregarCita_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                int idcita = random.Next(1, 999);
                DateTime date = DateTime.Now;
                string fecha = "";
                fecha = Jc_hora.Items[Jc_hora.SelectedIndex].ToString()+"-"+  Convert.ToString(date.Day) + "/" + Convert.ToString(date.Month) + "/" + Convert.ToString(date.Year);
                Citas cita = new Citas(idcita, jc_doctor.Items[jc_doctor.SelectedIndex].ToString(), Jc_Paciente.Items[Jc_Paciente.SelectedIndex].ToString(), jt_desc.Text, fecha);

                proces.AgregarCita(cita);
                InsertarTabla(); 
            }
            catch (Exception ex)
            {

                Console.WriteLine("El error es: " + ex);
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            jt_cod.Text = TablaCliente.Rows[row].Cells[0].Value.ToString();
          

        }

        private void EliminaCita_Click(object sender, EventArgs e)
        {
            cita.IdCita = int.Parse(jt_cod.Text);
            proces.EliminarCita(cita);
            InsertarTabla();
        }

        private void Hora_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet.Citas' Puede moverla o quitarla según sea necesario.
            this.citasTableAdapter.Fill(this.hospitalDataSet.Citas);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet.Paciente' Puede moverla o quitarla según sea necesario.
            this.pacienteTableAdapter.Fill(this.hospitalDataSet.Paciente);

        }
    }
}
