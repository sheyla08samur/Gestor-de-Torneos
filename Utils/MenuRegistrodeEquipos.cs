using Spectre.Console;
namespace Liga;

public static class MenuEquipos
{
    public static void MostrarMenuAccionEquipos()
    {
        AnsiConsole.MarkupLine("[bold blue]Elija la acción que desea realizar:[/]");
        var m_accEquipos = new Table();
        m_accEquipos.Border = TableBorder.Rounded;

        m_accEquipos.AddColumn("[bold]#[/]");
        m_accEquipos.AddColumn("[bold]Opción[/]");

        m_accEquipos.AddRow("1", "Registrar Equipo");
        m_accEquipos.AddRow("2", "Registrar Cuerpo Técnico");
        m_accEquipos.AddRow("3", "Registrar Cuerpo Médico");
        m_accEquipos.AddRow("4", "Inscripción Torneo");
        m_accEquipos.AddRow("5", "Notificación De Transferencia");
        m_accEquipos.AddRow("5", "Salir De Torneo");
        m_accEquipos.AddRow("5", "Regresar al Menú Principal");


        AnsiConsole.Write(m_accEquipos);
    }
}

/*
-----------------
- menu 1      -
-----------------
1.1. Registrar Equipo
1.2. Registrar Cuerpo Técnico
1.3. Registrar Cuerpo Médico
1.4. Inscripción Torneo
1.5. Notificaciín de De Transferencia
1.6. Salir de Torneo
1.7. Regresar al Menú Principal
*/