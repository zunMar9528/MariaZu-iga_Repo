using System;

namespace Entidades1
{
    public class Persona
    {
        #region atributos
        private int _id;
        private String _nombre;
        private String _apellidos;
        private int _cedula;
        #endregion

        #region propiedades
        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public int Cedula { get => _cedula; set => _cedula = value; }

        #endregion
        #region contructor
        public Persona()
        {

        }

        public Persona(string nombre, string apellidos, int identificador, int cedula)
        {
            _id = identificador;
            _nombre = nombre;
            _apellidos = apellidos;
            _cedula = cedula;

        }


        #endregion

    }
}
