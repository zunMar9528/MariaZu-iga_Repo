using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocios;



namespace AccesoDatos1

{
    public class Proceso1
    {
        List<object> listaPersona = new List<object>();
        List<Citas> listCita = new List<Citas>();
        ConnexionBD acd = new ConnexionBD();
        public void AgregarPersona(object agrega) => listaPersona.Add(agrega);
        public List<object> ReturListaPersona() => listaPersona;

        public void AgregarCita(Citas cita)
        {
            acd.AgregarCita(cita);
            listCita.Add(cita);
        }

        public void EliminarCita(Citas cita)
        {
            acd.Eliminar(cita);
            listCita.Remove(cita);
        }

        public void Connection(Citas cita)
        {
            acd.AgregarCita(cita);
            acd.AgregarCita(cita);
        }

        public DataTable CitasTabla()
        {
            ConnexionBD conexion = new ConnexionBD();

            return conexion.MostrarCitas();
        }



    }
}

