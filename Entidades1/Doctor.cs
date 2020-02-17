using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades1
{
   public  class Doctor :Persona
    {
        #region atributos
        private String _especialidad;


        #endregion

        #region propiedades
        public string Especialidad { get => _especialidad; set => _especialidad = value; }
        #endregion

        #region constructor
        public Doctor()
        {

        }
        public Doctor(string especialidad)
        {
            _especialidad = especialidad;
        }

        public Doctor(string especialidad, string nombre, string apellidos, int id, int cedula)
            : base(nombre, apellidos, id, cedula)
        {
            _especialidad = especialidad;
        }

        #endregion
    }
}
