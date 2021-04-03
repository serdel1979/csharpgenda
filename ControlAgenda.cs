using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda
{
    class ControlAgenda
    {

        private AdministradorAgenda _agenda;

        public ControlAgenda(AdministradorAgenda agenda)
        {
            _agenda = agenda;
        }

        public void VerContactos()
        {

            
            LimpiarPantalla();
            MostrarMenu();

            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Contactos en orden ascendente!!!");
                    _agenda.MostrarOrdenados();
                    break;
                case "2":
                    Console.WriteLine("Contactos en orden descendente!!!");
                    _agenda.MostrarDescendente();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opcion no válida!!!");
                    break;

            }
            PresionaParaSeguir();
        }


        public void BorrarUltimo()
        {
            LimpiarPantalla();
            if (_agenda.BorrarUltimo())
            {
                Console.WriteLine("Contacto borrado");
            }
            else
            {
                Console.WriteLine("No se puede borrar");
            }
            PresionaParaSeguir();
        }


        public void BuscarPorNombre()
        {
            LimpiarPantalla();
            Contacto contacto;
            Console.Write("Buscar contacto");
            Console.Write("Ingrese nombre a buscar: ");
            string nombre = Console.ReadLine();
            contacto = _agenda.BuscaPorNombre(nombre);
            if(contacto != null)
            {
                Console.WriteLine(contacto.ToString());
            }
            else
            {
                Console.WriteLine("El conntacto {0} no existe", nombre);
            }
            PresionaParaSeguir();
        }

        public void AgregarContacto()
        {
            LimpiarPantalla();
            Console.WriteLine("Nuevo contacto");
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Teléfono:");
            string telefono = Console.ReadLine();
            Console.WriteLine("Correo: ");
            string correo = Console.ReadLine();
            Contacto contacto = new Contacto(nombre,correo,telefono);
            if (_agenda.AgregarNuevo(contacto))
            {
                Console.WriteLine("Contacto agregado");
            }
            else
            {
                Console.WriteLine("Error al agregar el contacto");
            }
            PresionaParaSeguir();
        }


        static void PresionaParaSeguir()
        {
            Console.WriteLine("Presiona una tecla...");
            Console.ReadKey();
        }

        private void MostrarMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("======AGENDA=======");
            sb.AppendLine("1. Mostrar orden ascendente");
            sb.AppendLine("2. Mostrar orden descendente");
            sb.AppendLine("3. Salir");
            sb.Append("Seleccione opción: ");
            Console.WriteLine(sb.ToString());
        }
        private static void LimpiarPantalla()
        {
            Console.Clear();
        }


        public static void AcercaDe()
        {
            LimpiarPantalla();
            Console.WriteLine("Hecho pór Sergio");
            PresionaParaSeguir();
        }
    }
}
