using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades1
{
    public class Cliente: Persona
    {
        #region atributo
        private int _telefono;
        private String _correo;



        #endregion

        #region propiedades
        public int Telefono { get => _telefono; set => _telefono = value; }
        public string Correo { get => _correo; set => _correo = value; }
        #endregion

        #region constructor
        public Cliente()
        {


        }
        public Cliente(int telefono, String correo)
        {
            _telefono = telefono;
            _correo = correo;

        }

        public Cliente(int telefono, string correo, string nombre, string apellidos, int id, int cedula)
            : base(nombre, apellidos, id, cedula)
        {
            _telefono = telefono;
            _correo = correo;
        }
        #endregion
    }
}
