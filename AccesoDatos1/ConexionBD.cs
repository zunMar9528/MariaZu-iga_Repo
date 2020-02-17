using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace AccesoDatos1
{
    class ConexionBD
    {
        public SqlConnection Conexion()
        {
            SqlConnection cn;
            //SqlCommand cmd;
            // SqlDataReader dr;
            try
            {
                cn = new SqlConnection("Data Source=B-PC;Initial Catalog=Hospital;Persist Security Info=True;User ID=Progra_II;Password=123456");
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de Datos: " + ex);
                return null;
            }

        }

    }
}

