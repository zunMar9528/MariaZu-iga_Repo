using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocios;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace AccesoDatos1
{
    public class ConnexionBD
    {
        ConexionBD con = new ConexionBD();

        public void AgregarCita(Citas cita)
        {
            SqlCommand comand = new SqlCommand("agregar", con.Conexion())
            {
                CommandType = CommandType.StoredProcedure
            };
            comand.Parameters.AddWithValue("@idCita", SqlDbType.Int).Value = cita.IdCita;
            comand.Parameters.AddWithValue("@nombreDoctor", SqlDbType.VarChar).Value = cita.NombreDoctor;
            comand.Parameters.AddWithValue("@nombreCliente", SqlDbType.VarChar).Value = cita.NombreCliente;
            comand.Parameters.AddWithValue("@descripcion", SqlDbType.VarChar).Value = cita.DescCitas;
            comand.Parameters.AddWithValue("@fecha", SqlDbType.VarChar).Value = cita.Fecha;

            comand.ExecuteNonQuery();
        }
        public void Eliminar(Citas cita)
        {
            try
            {

                SqlCommand command = new SqlCommand("eliminar", con.Conexion())
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@idCita", SqlDbType.Int).Value = cita.IdCita;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        public DataTable MostrarCitas()
        {
            try
            {
                DataTable data = new DataTable();

                SqlCommand command = new SqlCommand("select * from Citas", con.Conexion());
                SqlDataAdapter sqlData = new SqlDataAdapter(command);

                sqlData.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }

}

