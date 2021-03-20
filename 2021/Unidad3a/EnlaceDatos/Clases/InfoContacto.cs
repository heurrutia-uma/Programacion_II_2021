using System;

namespace EnlaceDatos.Clases
{
    class InfoContacto
    {
        private string _nombre;
        private string _email;
        private string _telefono;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
    }
}
