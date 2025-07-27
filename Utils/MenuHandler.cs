using System.ComponentModel;
using System.Diagnostics;
using liga;
using Spectre.Console;
namespace Liga;

public static class MenuHandler
{
    public static void MostrarMenuHandler()
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
                AnimacionCarga.MostrarAnimacionCarga();
                AnsiConsole.Clear();
                MenuTorneos.MostrarMenuAccionTorneos();
                int opcTorneos = AnsiConsole.Ask<int>("[bold]> [/]");

                switch (opcTorneos)
                {
                    case 1:
                        // Agregar Torneo
                        AnimacionCarga.MostrarAnimacionCarga();
                        AnsiConsole.Clear();
                        break;
                    case 2:
                        // Buscar Torneo
                        AnimacionCarga.MostrarAnimacionCarga();
                        AnsiConsole.Clear();
                        break;
                    case 3:
                        //Eliminar Torneo
                        AnimacionCarga.MostrarAnimacionCarga();
                        AnsiConsole.Clear();
                        break;
                    case 4:
                        // Actualizar Toneo
                        AnimacionCarga.MostrarAnimacionCarga();
                        AnsiConsole.Clear();
                        break;
                    case 5:
                    // Regresar al Menú Principal
                    default:
                        break;
                }
                break;

            case 2:
                // Registro de Equipos
                AnimacionCarga.MostrarAnimacionCarga();
                AnsiConsole.Clear();
                MenuEquipos.MostrarMenuAccionEquipos();
                int opcAccionEquipos = AnsiConsole.Ask<int>("[bold]> [/]");
                switch (opcAccionEquipos)
                {
                    case 1:
                        // Registrar Equipo
                        AnimacionCarga.MostrarAnimacionCarga();
                        AnsiConsole.Clear();
                        break;
                    case 2:
                        // Registrar Cuerpo Técnico
                        AnimacionCarga.MostrarAnimacionCarga();
                        AnsiConsole.Clear();
                        break;
                    case 3:
                        // Registrar Cuerpo Médico
                        AnimacionCarga.MostrarAnimacionCarga();
                        AnsiConsole.Clear();
                        break;
                    case 4:
                        //Inscripción Torneo
                        AnimacionCarga.MostrarAnimacionCarga();
                        AnsiConsole.Clear();
                        break;
                    case 5:
                        // Notificaciín de De Transferencia
                        AnimacionCarga.MostrarAnimacionCarga();
                        AnsiConsole.Clear();
                        break;
                    case 6:
                        // Salir de Torneo
                        AnimacionSalir.MostrarAnimacionSalir();
                        AnsiConsole.Clear();
                        break;
                    case 7:
                        //Regresar al Menú Principal
                        break;
                    default:
                        // Error
                        break;
                }
                break;
            case 3:
                // Registro de Jugadores
                AnimacionCarga.MostrarAnimacionCarga();
                AnsiConsole.Clear();
                MenuEstadisticas.MostrarMenuEstadisticas();
                int opcAccionJugadores = AnsiConsole.Ask<int>("[bold]> [/]");
                switch (opcAccionJugadores)
                {
                    case 1:
                        // Registrar Jugador
                        AnimacionCarga.MostrarAnimacionCarga();
                        AnsiConsole.Clear();
                        break;
                    case 2:
                        // Buscar Jugador
                        AnimacionCarga.MostrarAnimacionCarga();
                        AnsiConsole.Clear();
                        break;
                    case 3:
                        // Editar Jugador
                        AnimacionCarga.MostrarAnimacionCarga();
                        AnsiConsole.Clear();
                        break;
                    case 4:
                        // Eliminar Jugador
                        AnimacionCarga.MostrarAnimacionCarga();
                        AnsiConsole.Clear();
                        break;
                    case 5:
                        // Regresar al Menú Principal
                        break;
                    default:
                        // Error
                        break;
                }
                break;

            case 4:
                // Transferencia de Jugadores
                AnimacionCarga.MostrarAnimacionCarga();
                AnsiConsole.Clear();
                MenuTransferencia.MostrarMenuTransferencia();
                int opcTransferencia = AnsiConsole.Ask<int>("[bold]> [/]");
                switch (opcTransferencia)
                {
                    case 1:
                        // Comprar Jugador
                        AnimacionCarga.MostrarAnimacionCarga();
                        AnsiConsole.Clear();
                        break;
                    case 2:
                        // Prestar Jugador
                        AnimacionCarga.MostrarAnimacionCarga();
                        AnsiConsole.Clear();
                        break;
                    case 3:
                        //Regresar al Menú Principal
                        break;
                    default:
                        // Error
                        break;
                }
                break;
            case 5:
                // Estadísticas
                AnimacionCarga.MostrarAnimacionCarga();
                AnsiConsole.Clear();
                MenuEstadisticas.MostrarMenuEstadisticas();
                int opcEstadisticas = AnsiConsole.Ask<int>("[bold]> [/]");
                switch (opcEstadisticas)
                {
                    case 1:
                        // Jugadores Con Más Asistencias Torneo
                        AnimacionCarga.MostrarAnimacionCarga();
                        AnsiConsole.Clear();
                        break;
                    case 2:
                        // Equipos Con Más Goles
                        AnimacionCarga.MostrarAnimacionCarga();
                        AnsiConsole.Clear();
                        break;
                    case 3:
                        // Jugadores Más Caros Por Equipo
                        AnimacionCarga.MostrarAnimacionCarga();
                        AnsiConsole.Clear();
                        break;
                    case 4:
                        // Jugadores Menor Al Promedio De Edad Por Equipo
                        AnimacionCarga.MostrarAnimacionCarga();
                        AnsiConsole.Clear();
                        break;
                    case 5:
                        //Regresar al Menú Principal
                        break;
                    default:
                        // Error
                        break;
                }
                break;
            case 6:
                // Salir del programa
                AnimacionSalir.MostrarAnimacionSalir();
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