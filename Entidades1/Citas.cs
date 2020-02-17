using System;
using System.Collections.Generic;
using System.Text;


namespace LogicaNegocios
{
    public class Citas
    {
        #region atributos
        private int _idCita;
        private String _nombreDoctor;
        private String _nombreCliente;
        private String _descCitas;
        private String _fecha;


        #endregion

        #region propiedades
        public int IdCita { get => _idCita; set => _idCita = value; }
        public string NombreDoctor { get => _nombreDoctor; set => _nombreDoctor = value; }
        public string NombreCliente { get => _nombreCliente; set => _nombreCliente = value; }
        public string DescCitas { get => _descCitas; set => _descCitas = value; }
        public string Fecha { get => _fecha; set => _fecha = value; }
        #endregion

        #region constructor
        public Citas()
        {

        }
        public Citas(int idCita, string nombreDoctor, string nombreCliente, string descripcionCita, string fecha)
        {
            IdCita = idCita;
            NombreDoctor = nombreDoctor;
            NombreCliente = nombreCliente;
            DescCitas = descripcionCita;
            Fecha = fecha;
        }
        #endregion
    }
}
