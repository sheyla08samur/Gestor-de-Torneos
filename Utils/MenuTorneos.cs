using Spectre.Console;
using Liga.Helpers;
using Liga.Models;
namespace Liga.Utils;
public static class MenuTorneos
{
    public static void MostrarMenuAccionTorneos()
    {
        AnsiConsole.Write(new Spectre.Console.Rule("[bold blue]🏆 Menú de Torneos 🏆[/]").Centered());
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
        int opcTorneos = AnsiConsole.Ask<int>("[bold]> [/]");
            switch (opcTorneos)
            {
                case 1:
                    // Agregar Torneo
                    AnimacionCarga.MostrarAnimacionCarga("Awantaaa...");
                    AnsiConsole.Clear();
                    AgregarTorneo.AgregarNuevoTorneo(Program.torneos);
                    Console.ReadKey();
                    break;
                case 2:
                    // Buscar Torneo
                    AnimacionCarga.MostrarAnimacionCarga("Ejpera, ejpera...");
                    AnsiConsole.Clear();
                    BuscarTorneo.BuscarTorneoPorId(Program.torneos);
                    Console.ReadKey();
                    break;
                case 3:
                    //Eliminar Torneo
                    AnimacionCarga.MostrarAnimacionCarga("Dame un toque...");
                    AnsiConsole.Clear();
                    EliminarTorneo.EliminarTorneoPorId(Program.torneos);
                    Console.ReadKey();
                    break;
                case 4:
                    // Actualizar Torneo
                    AnimacionCarga.MostrarAnimacionCarga("Calma publo...");
                    AnsiConsole.Clear();
                    ActualizarTorneo.ActualizarTorneoPorId(Program.torneos);
                    Console.ReadKey();
                    break;
                case 5:
                // Regresar al Menú Principal
                default:
                    AnsiConsole.MarkupLine("[bold red]Opción inválida. Intente nuevamente.[/]");
                    Console.ReadKey();
                    break;
            }
        
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