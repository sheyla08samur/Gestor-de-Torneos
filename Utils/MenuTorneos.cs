using Spectre.Console;
namespace Liga.Utils;
public static class MenuTorneos
{
    public static void MostrarMenuAccionTorneos()
    {
        AnsiConsole.MarkupLine("[bold blue]Elija la acción que desea realizar:[/]");
        var m_accTorneos = new Table();
        m_accTorneos.Border = TableBorder.Rounded;

        m_accTorneos.AddColumn("[bold]#[/]");
        m_accTorneos.AddColumn("[bold]Opción[/]");

        m_accTorneos.AddRow("1", "Agregar Torneo");
        m_accTorneos.AddRow("2", "Buscar Torneo");
        m_accTorneos.AddRow("3", "Eliminar Torneo");
        m_accTorneos.AddRow("4", "Actualizar Torneo");
        m_accTorneos.AddRow("5", "Regresar al Menú Principal");

        AnsiConsole.Write(m_accTorneos);
        
        
    }
}

/*
-----------------
- menu 0       -
-----------------
0.1. Add Torneo
0.2. Buscar Torneo
0.3. Eliminar Torneo
0.4. Actualizar Toneo
0.5. Regresar al Menú Principal
*/