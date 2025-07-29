using Spectre.Console;
using Liga.Services;
using Liga.Helpers;
using Liga.Models;
namespace Liga.Utils;

public static class MenuIngresarEquipo
{
    public static void MostrarMenuIngresarEquipo()
    {
        AnsiConsole.MarkupLine("[bold blue]Elija lo que desea ingresar:[/]");
        var m_ingEq = new Table();
        m_ingEq.Border = TableBorder.Rounded;

        m_ingEq.AddColumn("[bold]#[/]");
        m_ingEq.AddColumn("[bold]Opción[/]");

        m_ingEq.AddRow("1", "Registrar Jugador");
        m_ingEq.AddRow("2", "Buscar Jugador");
        m_ingEq.AddRow("3", "Editar Jugador");
        m_ingEq.AddRow("4", "Eliminar Jugador");
        m_ingEq.AddRow("5", "Regresar al Menú Principal");

        AnsiConsole.Write(m_ingEq);

        int opcAccionJugadores = AnsiConsole.Ask<int>("[bold]> [/]");
        switch (opcAccionJugadores)
        {
            case 1:
                // Registrar Jugador
                AnimacionCarga.MostrarAnimacionCarga("Un momento...");
                AnsiConsole.Clear();
                RegistrarJugador.RegistrarNuevoJugador(Program.jugadores);
                break;
            case 2:
                // Buscar Jugador
                AnimacionCarga.MostrarAnimacionCarga("Un momento...");
                AnsiConsole.Clear();
                BuscarJugador.BuscarJugadorPorId(Program.jugadores);
                break;
            case 3:
                // Editar Jugador
                AnimacionCarga.MostrarAnimacionCarga("Un momento...");
                AnsiConsole.Clear();
                EditarJugador.EditarJugadorPorId(Program.jugadores);
                break;
            case 4:
                // Eliminar Jugador
                AnimacionCarga.MostrarAnimacionCarga("Un momento...");
                AnsiConsole.Clear();
                BuscarJugador.BuscarJugadorPorId(Program.jugadores);
                break;
            case 5:
                // Regresar al Menú Principal
                break;
            default:
                // Error
                break;
        }
    }
}

/*
-----------------
- menu 1.2      -
-----------------
2.1. Registrar Jugador
2.2. Buscar Jugador
2.3. Editar Jugador
2.4. Eliminar Jugador
2.5. Regresar al Menú Principal
*/
