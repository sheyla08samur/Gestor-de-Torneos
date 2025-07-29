using Spectre.Console;
using Liga.Helpers;
using Liga.Models;
namespace Liga.Utils;

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

        int opcAccionEquipos = AnsiConsole.Ask<int>("[bold]> [/]");
        switch (opcAccionEquipos)
        {
            case 1:
                // Registrar Equipo
                AnimacionCarga.MostrarAnimacionCarga("Un momento...");
                AnsiConsole.Clear();
                break;
            case 2:
                // Registrar Cuerpo Técnico
                AnimacionCarga.MostrarAnimacionCarga("Un momento...");
                AnsiConsole.Clear();
                break;
            case 3:
                // Registrar Cuerpo Médico
                AnimacionCarga.MostrarAnimacionCarga("Un momento...");
                AnsiConsole.Clear();
                break;
            case 4:
                //Inscripción Torneo
                AnimacionCarga.MostrarAnimacionCarga("Un momento...");
                AnsiConsole.Clear();
                break;
            case 5:
                // Notificaciín de De Transferencia
                AnimacionCarga.MostrarAnimacionCarga("Un momento...");
                AnsiConsole.Clear();
                break;
            case 6:
                // Salir de Torneo
                AnimacionCarga.MostrarAnimacionCarga("Un momento...");
                AnsiConsole.Clear();
                break;
            case 7:
                //Regresar al Menú Principal
                break;
            default:
                // Error
                break;
        }
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