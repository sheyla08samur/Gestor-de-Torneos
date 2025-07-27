using Spectre.Console;
namespace Liga;

public static class MenuEstadisticas
{
    public static void MostrarMenuEstadisticas()
    {
        AnsiConsole.MarkupLine("[bold blue]Elija lo que desea eliminar:[/]");
        var m_estadisticas = new Table();
        m_estadisticas.Border = TableBorder.Rounded;

        m_estadisticas.AddColumn("[bold]#[/]");
        m_estadisticas.AddColumn("[bold]Opción[/]");
        m_estadisticas.AddRow("1", "Jugadores Con Más Asistencias Torneo");
        m_estadisticas.AddRow("2", "Equipos Con Más Goles");
        m_estadisticas.AddRow("3", "Jugadores Más Caros Por Equipo ");
        m_estadisticas.AddRow("4", "Jugadores Menor Al Promedio De Edad Por Equipo");
        m_estadisticas.AddRow("5", "Regresar Al Menu Principal");

        AnsiConsole.Write(m_estadisticas);
    }
}

/*
Menú de Estadisticas
-------------------------
4.1. Jugadores Con Más Asistencias Torneo
4.2. Equipos Con Más Goles
4.3. Jugadores Más Caros Por Equipo
4.4. Jugadores Menor Al Promedio De Edad Por Equipo
4.5. Regresar Al Menu Principal
*/