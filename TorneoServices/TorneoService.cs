using Spectre.Console;
using System.Data;
using Liga.Helpers;
namespace Liga.Models;


// Agregar Torneo
public static class AgregarTorneo
{
    public static void AgregarNuevoTorneo(List<Torneo> torneos)
    {
        Console.Clear();
        AnsiConsole.Write(new Spectre.Console.Rule("[bold blue]🏆 Agregar Torneo 🏆[/]").Centered());
        AnsiConsole.MarkupLine("[bold]Ingrese los detalles del torneo:\n[/]");

        int nuevoId = AnsiConsole.Ask<int>("[bold]ID del torneo: [/]");
        string nombre = ValidarString.ValString("[bold]Nombre del torneo: [/]");
        DateTime fechaInicio = ValidarFecha.ValFechaInicio("[bold]Fecha de inicio [/](YYYY-MM-DD): ");
        DateTime fechaFin = ValidarFecha.ValFechaFin("[bold]Fecha de fin [/](YYYY-MM-DD): ", fechaInicio);

        Torneo torneo = new Torneo
        {
            Id = nuevoId,
            Nombre = nombre,
            FechaInicio = fechaInicio,
            FechaFin = fechaFin
        };
        torneos.Add(torneo);

        AnimacionCarga.MostrarAnimacionCarga("Guardando torneo...");
        AnsiConsole.MarkupLine("[bold green]Torneo guardado correctamente[/]");
    }
}

// Buscar Torneo
public static class BuscarTorneo
{
    public static void BuscsarTorneoPorId(List<Torneo> torneos)
    {
        Console.Clear();
        AnsiConsole.Write(new Spectre.Console.Rule("[bold blue]🔍 Buscar Torneo 🔍[/]").Centered());
        AnsiConsole.MarkupLine("[bold]Ingrese el ID del Torneo: [/]");
        int id = AnsiConsole.Ask<int>("[bold]> [/]");
        AnimacionCarga.MostrarAnimacionCarga("Buscando torneo...");
        Torneo? torneo = torneos.FirstOrDefault(t => t.Id == id);
        if (torneo != null)
        {
            AnsiConsole.MarkupLine($"[bold green]Torneo encontrado:[/] {torneo}");
        }
        else
        {
            AnsiConsole.MarkupLine("[red]Torneo no encontrado.[/]");
        }
    }
}

// Eliminar Torneo
public static class EliminarTorneo
{
    public static void EliminarTorneoPorId(List<Torneo> torneos)
    {
        Console.Clear();
        AnsiConsole.Write(new Spectre.Console.Rule("[bold blue]🗑 Eliminar Torneo 🗑[/]").Centered());
        AnsiConsole.MarkupLine("[bold]Ingrese el ID del Torneo a eliminar: [/]");
        int id = AnsiConsole.Ask<int>("[bold]> [/]");
        Torneo? torneo = torneos.FirstOrDefault(t => t.Id == id);
        if (torneo != null)
        {
            torneos.Remove(torneo);
            AnsiConsole.MarkupLine($"[bold green]Torneo eliminado:[/] {torneo.Nombre}");
        }
        else
        {
            AnsiConsole.MarkupLine("[bold red]Torneo no encontrado.[/]");
        }
    }
}

// Actualizar Toneo
public static class ActualizarTorneo
{
    public static void ActualizarTorneoPorId(List<Torneo> torneos)
    {
        Console.Clear();
        AnsiConsole.Write(new Spectre.Console.Rule("[bold blue]✏ Actualizar Torneo ✏[/]").Centered());
        AnsiConsole.MarkupLine("[bold]Ingrese el ID de Torneo a actualizar:[/]");
        int id = AnsiConsole.Ask<int>("[bold]> [/]");
        Torneo? torneo = torneos.FirstOrDefault(t => t.Id == id);
        //PUEDO CREARLE UN MENU AQUI PA DIVIDIR ESTO
        if (torneo != null && torneo is not null)
        {
            AnsiConsole.MarkupLine($"[bold]Torneo Encontrado: {torneo.Nombre}[/]0");
            string nuevoNombre = AnsiConsole.Ask<string>("[bold]Nuevo nombre del torneo[/]");
            DateTime nuevaFechaInicio = AnsiConsole.Ask<DateTime>("[bold]Nueva fecha de inicio [/](YYYY-MM-DD)");
            DateTime nuevaFechaFin = AnsiConsole.Ask<DateTime>("[bold]Nueva fecha de fin [/](YYYY-MM-DD)");
            torneo.Nombre = nuevoNombre;
            torneo.FechaInicio = nuevaFechaInicio;
            torneo.FechaFin = nuevaFechaFin;
            AnsiConsole.MarkupLine($"[bold green]Torneo actualizado: {torneo.Nombre}[/]");

        }
    }
}



// Regresar al Menú Principal