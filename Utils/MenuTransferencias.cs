using Spectre.Console;
namespace Liga.Utils;
public class MenuTransferencia
{
    public static void MostrarMenuTransferencia()
    {
        AnsiConsole.MarkupLine("[bold blue]Elija lo que desea editar:[/]");
        var m_Transferencia = new Table();
        m_Transferencia.Border = TableBorder.Rounded;

        m_Transferencia.AddColumn("[bold]#[/]");
        m_Transferencia.AddColumns("[bold]Opción[/]");
        m_Transferencia.AddRow("1", "Comprar Jugador");
        m_Transferencia.AddRow("2", "Prestar Jugador");
        m_Transferencia.AddRow("3", "Regresar Al Menú Principal");

        AnsiConsole.Write(m_Transferencia);
    }
}

/*
Menú de Transferencias
-------------------------
3.1. Comprar Jugador
3.2. Prestar Jugador
3.3. Regresar al Menú Principal
*/