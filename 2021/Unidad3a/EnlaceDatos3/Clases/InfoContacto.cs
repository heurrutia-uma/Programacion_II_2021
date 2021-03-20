using System;
using System.ComponentModel;

namespace EnlaceDatos3.Clases
{
    class InfoContacto : INotifyPropertyChanged
    {
        private string _nombre;
        private string _email;
        private string _telefono;

        public string Nombre
        {
            get { return _nombre; }
            set 
            {
                _nombre = value;
                CambioPropiedad("Nombre");
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                CambioPropiedad("Email");
            }
        }

        public string Telefono
        {
            get { return _telefono; }
            set
            { 
                _telefono = value;
                CambioPropiedad("Telefono");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void CambioPropiedad(string _nombrePropiedad)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_nombrePropiedad));
            }
        }
    }
}
