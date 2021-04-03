using System;
using System.Text;

namespace Agenda
{
    class Program
    {

        static ControlAgenda control = new ControlAgenda(new AdministradorAgenda());
        static void Main(string[] args)
        {
            string opcion = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Agenda de contactos\n");
                ImprimeMenu();
                switch (opcion)
                {
                    case "1":
                        control.VerContactos();
                        break;
                    case "2":
                        control.AgregarContacto();
                        break;
                    case "3":
                        control.BorrarUltimo();
                        break;
                    case "4":
                        control.BuscarPorNombre();
                        break;
                    case "5":
                        ControlAgenda.AcercaDe();
                        break;
                    case "6":
                        break;
                }
                opcion = Console.ReadLine();
            } while (opcion != "6");
        }

        static void ImprimeMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Ver Contactos");
            sb.AppendLine("2. Agregar Contacto");
            sb.AppendLine("3. Borrar ultimo contacto");
            sb.AppendLine("4. Buscar contacto por nombre");
            sb.AppendLine("5. Acerca de");
            sb.AppendLine("6. Salir");
            sb.Append("Seleccione opcion: ");
            Console.WriteLine(sb.ToString());
        }
    }
}
