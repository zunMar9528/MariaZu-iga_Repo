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
        string[,] itemHora; 

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

            itemHora = new string[3, 5];
            for (int i = 0; i < 3; i++)
            {
                itemHora[i, 0] = "08:00am";
                itemHora[i, 1] = "09:00am";
                itemHora[i, 2] = "10:00am";
                itemHora[i, 3] = "11:00am";
                itemHora[i, 4] = "12:00am";
            }

            if (TablaCliente.Rows.Count > 0)
            {
                HorasFiltro();
            }
            Jc_hora.SelectedIndex = -1;
        }



        void HorasFiltro()
        {
            for (int i = 0; i < TablaCliente.Rows.Count; i++)
            {
                string hora = TablaCliente.Rows[i].Cells[3].Value.ToString().Substring(0, 7);
                for (int j = 0; j < 3; j++)
                {
                    if (TablaCliente.Rows[i].Cells[1].Value.ToString().Equals(jc_doctor.Items[j]))
                    {
                        for (int m = 0; m < 5; m++)
                        {
                            if (itemHora[j, m].Equals(hora))
                            {
                                itemHora[j, m] = "0";
                            }
                        }
                    }
                }
            }


        }

        void DoctorHora(int doc)
        {
            Jc_hora.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                if (!itemHora[doc, i].Equals("0"))
                {
                    Jc_hora.Items.Add(itemHora[doc, i]);
                }

            }
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
                fecha = Jc_hora.Items[Jc_hora.SelectedIndex].ToString() + "-" + Convert.ToString(date.Day) + "/" + Convert.ToString(date.Month) + "/" + Convert.ToString(date.Year);
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
        void filtrarCitas()
        {


            string[,] itemHoras;
            itemHoras = new string[3, 5];
            for (int i = 0; i < 2; i++)
            {
                itemHoras[i, 1] = "08:00a.m";
                itemHoras[i, 2] = "09:00a.m";
                itemHoras[i, 3] = "10:00a.m";
                itemHoras[i, 4] = "11:00a.m";
                itemHoras[i, 5] = "12:00a.m";
            }


            for (int i = 0; i < TablaCliente.Rows.Count; i++)
            {
                string hora = TablaCliente.Rows[i].Cells[1].Value.ToString().Substring(0, 8);

                for (int j = 0; j < 2; i++)
                {
                    if (TablaCliente.Rows[i].Cells[1].Value.ToString().Equals(jc_doctor.Items[j]))
                    {
                        for (int k = 0; k < 4; k++)
                        {

                            if (itemHoras[j, k].Equals(hora))
                            {
                                itemHoras[j, k] = "0";


                            }

                        }
                    }





                }


            }
            if (itemHoras[1, 2].Equals("0"))
            {
                jc_doctor.Items.Add(itemHoras[1, 2]);
                //abrir for
            }

        
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

        private void jc_doctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoctorHora(jc_doctor.SelectedIndex);
        }
    }
}
