using System.ComponentModel;
using System.Diagnostics;
using Spectre.Console;
using Liga.Models;
using Liga.Helpers;
namespace Liga.Utils;

public static class MenuHandler
{
    public static void MostrarMenuHandler()
    {
        while (true)
        {
            AnsiConsole.Clear();
            AnsiConsole.Write(
                new FigletText("¡ GESTOR DEPORTIVO !")
                .Centered()
                .Color(Color.Blue));
            AnsiConsole.Write(new Rule("[bold yellow]\n🏆 Crea, organiza y gestiona tus torneos como un profesional ⚽[/]").Centered());

            AnsiConsole.MarkupLine("[bold blue] Menu Principal[/]");
            AnsiConsole.MarkupLine("[bold]Elije la opción que deseas gestionar:\n[/]");

            var m_handler = new Table();
            m_handler.Border = TableBorder.Rounded;

            m_handler.AddColumn("#");
            m_handler.AddColumn("Opción");
            m_handler.AddRow("1", "Crear Torneo");
            m_handler.AddRow("2", "Registro Equipos");
            m_handler.AddRow("3", "Registro Jugadores");
            m_handler.AddRow("4", "Transferencia (Compra, Prestamo)");
            m_handler.AddRow("5", "Estadisticas");
            m_handler.AddRow("6", "Salir");

            AnsiConsole.Write(m_handler);

            int opc = AnsiConsole.Ask<int>("[bold blue]Ingrese la opción deseada: [/]");
            switch (opc)
            {
                case 1:
                    // Creación de Torneos
                    AnimacionCarga.MostrarAnimacionCarga("Ejpera un momento...");
                    AnsiConsole.Clear();
                    MenuTorneos.MostrarMenuAccionTorneos();
                    break;

                case 2:
                    // Registro de Equipos
                    AnimacionCarga.MostrarAnimacionCarga("Aguanta el burro");
                    AnsiConsole.Clear();
                    MenuEquipos.MostrarMenuAccionEquipos();
                    
                    break;
                case 3:
                    // Registro de Jugadores
                    //AnimacionCarga.MostrarAnimacionCarga();
                    AnsiConsole.Clear();
                    MenuIngresarEquipo.MostrarMenuIngresarEquipo();
                    break;

                case 4:
                    // Transferencia de Jugadores
                    //AnimacionCarga.MostrarAnimacionCarga();
                    AnsiConsole.Clear();
                    MenuTransferencia.MostrarMenuTransferencia();
                    break;
                case 5:
                    // Estadísticas
                    //AnimacionCarga.MostrarAnimacionCarga();
                    AnsiConsole.Clear();
                    MenuEstadisticas.MostrarMenuEstadisticas();
                    break;
                case 6:
                    // Salir del programa
                    //AnimacionCarga.MostrarAnimacionCarga();
                    AnsiConsole.Clear();
                    AnsiConsole.MarkupLine("[bold red]¡Gracias por usar el Gestor Deportivo![/]");
                    Environment.Exit(0);
                    break;

                default:
                    AnsiConsole.MarkupLine("[bold red]Opción no válida. Por favor, intente de nuevo.[/]");
                    Thread.Sleep(2000);
                    MostrarMenuHandler();
                    break;
            }
        }
    }
}