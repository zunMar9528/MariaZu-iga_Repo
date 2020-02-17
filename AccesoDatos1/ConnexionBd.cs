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
    public class ConnexionBd
    {
        ConexionBD con = new ConexionBD();

        public void AgregarCita(Citas cita)
        {


            SqlCommand comand = new SqlCommand("sp_agregarCita", con.Conexion())
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

        public DataTable MostrarClintes()
        {
            try
            {
                DataTable data = new DataTable();

                SqlCommand command = new SqlCommand("select * from Clinte", con.Conexion());
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

