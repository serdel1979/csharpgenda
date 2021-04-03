using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda
{
    class AdministradorAgenda
    {

        private const int TAM = 10;
        private Contacto[] _contactos;
        private int _indice;

        public int NumContactos {
            get
            {
                return _indice;
            }
        }

        public AdministradorAgenda()
        {
            _contactos = new Contacto[TAM];
            _indice = 0;
        }

        public Boolean AgregarNuevo(Contacto contacto)
        {
            if(_indice < TAM)
            {
                _contactos[_indice] = contacto;
                _indice++;
                return true;
            }
            else
            {
                return false;
            }  
        }

        public Boolean BorrarUltimo()
        {
            if(_indice > 0)
            {
                _contactos[_indice] = null;
                _indice--;
                return true;
            }
            else
            {
                return false;
            }
        }


        private Boolean NoHayContactos()
        {
            if(_indice == 0)
            {
                return true;
            }
            
            return false;

        }

        private string CadenaContactos(Contacto[] contactos)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < _indice; i++)
            {
                if (contactos[i] == null) continue;
                string dato = string.Format("{0}. {1}",i + 1, contactos[i]);
                sb.AppendLine(dato);
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return CadenaContactos(_contactos);
        }


        public void MostrarContactos()
        {
            Console.WriteLine(this);
        }


        public void MostrarOrdenados()
        {
            if (!NoHayContactos())
            {
                Contacto[] ordenados = new Contacto[_indice];
                Array.Copy(_contactos, ordenados, _indice);
                Array.Sort(ordenados);
                Console.WriteLine(CadenaContactos(ordenados));
            }
        }

        public void MostrarDescendente()
        {
            if (!NoHayContactos())
            {
                Contacto[] ordenados = new Contacto[_indice];
                Array.Copy(_contactos, ordenados, _indice);
                Array.Sort(ordenados);
                Array.Reverse(ordenados);
                Console.WriteLine(CadenaContactos(ordenados));
            }
        }

        public Contacto BuscaPorNombre(string nombre)
        {
            foreach (Contacto c in _contactos)
            {
                if (c != null && c.Nombre == nombre)
                {
                    return c;
                }
            }
            return null;
        }

    }
}
