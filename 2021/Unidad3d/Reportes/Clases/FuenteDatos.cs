using System;

namespace Reportes.Clases
{
    public class FuenteDatos
    { 
    }

    public class Cliente
    {
        public Int64 Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Municipio { get; set; }
    }
}
