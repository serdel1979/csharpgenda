using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda
{
    class Contacto : IComparable<Contacto>
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Contacto()
        {
            Nombre = "Sin Nombre";
            Correo = "Sin correo";
            Telefono = "Sin telefono";
        }

        public Contacto(string nombre)
        {
            Nombre = nombre;
        }

        public Contacto(string nombre, string correo) : this (nombre)
        {
            Correo = correo;
        }

        public Contacto(string nombre, string correo, string telefono) : this (nombre, correo)
        {
            Telefono = telefono;
        }

        public override string ToString()
        {
            return string.Format("Nombre: ,"+Nombre+" email: "+Correo+", telefono: "+Telefono);
        }

        public override bool Equals(object obj)
        {

            if (obj == null) return false;

            Contacto c = obj as Contacto;
            if( c == null)
            {
                return false;
            }
            if (c.Nombre.Equals(Nombre)){
                if (c.Correo.Equals(Correo))
                {
                    return true;
                }
            }

            return string.Equals(Nombre, c.Nombre) && string.Equals(Telefono, c.Telefono);
        }


        public override int GetHashCode()
        {
            unchecked
            {
                int hashNombre = (Nombre != null ? Nombre.GetHashCode() : 0);
                int hashTelefono = (Telefono != null ? Telefono.GetHashCode() : 0);
                return (hashNombre * 197 ^ hashTelefono);
            }
        }

        int IComparable<Contacto>.CompareTo(Contacto other)
        {
            return Nombre.CompareTo(other.Nombre);
        }
    }
}
