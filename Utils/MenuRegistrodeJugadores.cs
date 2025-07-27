using Spectre.Console;
namespace Liga;

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
