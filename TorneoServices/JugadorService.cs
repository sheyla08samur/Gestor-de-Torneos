using Spectre.Console;
using Liga.Models;
using Liga.Helpers;
namespace Liga.Services;

// Registrar Jugador
public static class RegistrarJugador
{
    public static void RegistrarNuevoJugador(List<Jugador> jugadores)
    {
        Console.Clear();
        AnsiConsole.Write(new Spectre.Console.Rule("[bold blue]Agregar Jugador[/]").Centered());
        AnsiConsole.MarkupLine("[bold]Ingrese los detalles del jugador:[/]");
        // Asignar ID secuencial
        //int nuevoId = Jugador.Count > 0 ? jugadores.Max(t => t.Id) + 1 : 1;
        int nuevoId = AnsiConsole.Ask<int>("[bold]ID del jugador: [/]");
        string nombre = ValidarString.ValString("[bold]Nombre del jugador: [/]");
        int edad = AnsiConsole.Ask<int>("[bold]Edad del jugador[/]");    //VALIDAR
        string origen = ValidarString.ValString("[bold]Nacionalidad del jugador: [/]");
        string email = AnsiConsole.Ask<string>("[bold]Email del jugador: [/]");    //VALIDAR
        int dorsal = AnsiConsole.Ask<int>("[bold]Dorsal del jugador: [/]");
        string posicion = ValidarString.ValString("[bold]Posición del jugador: [/]");
        string piernaDominante = ValidarString.ValString("[bold]Pierna dominante del jugador: [/]");
        bool disponibilidad = AnsiConsole.Ask<bool>("[bold]¿Está disponible el jugador? (true/false): [/]");

        Jugador jugador = new Jugador
        {
            Id = nuevoId,
            Nombre = nombre,
            Edad = edad,
            Origen = origen,
            Email = email,
            Dorsal = dorsal,
            Posicion = posicion,
            PiernaDominante = piernaDominante,
            Disponibilidad = disponibilidad
        };
        jugadores.Add(jugador);
        AnimacionCarga.MostrarAnimacionCarga("Guardando jugador...");
        AnsiConsole.MarkupLine("[bold greem] Jugador guardado correctamente[/]");

    }
}


// Buscar Jugador
public static class BuscarJugador
{
    public static void BuscarJugadorPorId(List<Jugador> jugadores)
    {
        Console.Clear();
        AnsiConsole.Write(new Spectre.Console.Rule("[bold blue]🔍 Buscar Jugador 🔍[/]").Centered());
        AnsiConsole.MarkupLine("[bold]Ingrese el ID del jugador: [/]");
        int id = AnsiConsole.Ask<int>("[bold]> [/]");
        AnimacionCarga.MostrarAnimacionCarga("Buscando jugador...");
        Jugador? jugador = jugadores.FirstOrDefault(t => t.Id == id);
        if (jugador != null)
        {
            AnsiConsole.MarkupLine($"[bold green]Jugador encontrado:[/] {jugador}");
        }
        else
        {
            AnsiConsole.MarkupLine($"[green]Jugador no encontrado:[/] {jugador}");
        }
    }
}

// Editar Jugador
public static class EditarJugador
{
    public static void EditarJugadorPorId(List<Jugador> jugadores)
    {
        Console.Clear();
        AnsiConsole.Write(new Spectre.Console.Rule("[bold blue]✏️ Editar Jugador ✏️[/]").Centered());
        AnsiConsole.MarkupLine("[bold blue]Elija lo que desea editar[/]");
        var m_EditJug = new Table();
        m_EditJug.Border = TableBorder.Rounded;

        m_EditJug.AddColumn("[bold]#[/]");
        m_EditJug.AddColumn("[bold]Opción[/]");

        m_EditJug.AddRow("1", "Nombre");
        m_EditJug.AddRow("2", "Edad");
        m_EditJug.AddRow("3", "Nacionalidad");
        m_EditJug.AddRow("4", "Email");
        m_EditJug.AddRow("5", "Dorsal");
        m_EditJug.AddRow("6", "posicion");
        m_EditJug.AddRow("7", "Pierna Dominante");
        m_EditJug.AddRow("8", "Disponibilidad");

        AnsiConsole.Write(m_EditJug);
        int opcEditJug = AnsiConsole.Ask<int>("[bold]> [/]");
        Console.Clear();
        AnsiConsole.Write(new Spectre.Console.Rule("[bold blue]✏️ Editar Jugador ✏️[/]").Centered());
        AnsiConsole.MarkupLine("[bold]Ingrese el ID del Jugador del cual desea editar la informacion: [/]");
        int id = AnsiConsole.Ask<int>("[bold]> [/]");
        Jugador? jugador = jugadores.FirstOrDefault(t => t.Id == id);
        if (jugador == null)
        {
            AnsiConsole.MarkupLine("[red]Jugador no encontrado.[/]");
            return;
        }
        while (opcEditJug > 0 || opcEditJug <= 8)
        {
            switch (opcEditJug)
            {
                case 1:
                    //Editar Nombre
                    AnsiConsole.MarkupLine("[bold]Ingrese el nuevo nombre del jugador[/]");
                    AnsiConsole.MarkupLine($"[bold]Jugador Encontrado:[/] {jugador.Nombre}");
                    string nuevoNombre = ValidarString.ValString("[bold]> [/]");
                    jugador.Nombre = nuevoNombre;
                    AnsiConsole.MarkupLine($"[bold green] Nombre actualizado a[/] {jugador.Nombre}");
                    break;
                case 2:
                    //Editar Edad
                    AnsiConsole.MarkupLine("[bold]Ingrese la nueva edad del jugador[/]");
                    AnsiConsole.MarkupLine($"[bold]Jugador Encontrado:[/] {jugador.Nombre}");
                    int nuevaEdad = AnsiConsole.Ask<int>("[bold]> [/]");
                    jugador.Edad = nuevaEdad;
                    AnsiConsole.MarkupLine($"[bold green] Edad actualizada a[/] {jugador.Edad}");
                    break;

                case 3:
                    //Editar Nacionalidad
                    AnsiConsole.MarkupLine("[bold]Ingrese la nacionalidad del jugador[/]");
                    AnsiConsole.MarkupLine($"[bold]Jugador Encontrado:[/] {jugador.Nombre}");
                    string nuevoOrigen = ValidarString.ValString("[bold]> [/]");
                    jugador.Origen = nuevoOrigen;
                    AnsiConsole.MarkupLine($"[bold green] Origen actualizado a[/] {jugador.Origen}");
                    break;
                case 4:
                    //Editar Email
                    AnsiConsole.MarkupLine("[bold]Ingrese el nuevo email del jugador[/]");
                    AnsiConsole.MarkupLine($"[bold]Jugador Encontrado:[/] {jugador.Nombre}");
                    string nuevoEmail = AnsiConsole.Ask<string>("[bold]> [/]");
                    jugador.Email = nuevoEmail;
                    AnsiConsole.MarkupLine($"[bold green] Email actualizado a[/] {jugador.Email}");
                    break;
                case 5:
                    //Editar Dorsal
                    AnsiConsole.MarkupLine("[bold]Ingrese la nueva dorsal del jugador[/]");
                    AnsiConsole.MarkupLine($"[bold]Jugador Encontrado:[/] {jugador.Nombre}");
                    int nuevaDorsal = AnsiConsole.Ask<int>("[bold]> [/]");
                    jugador.Dorsal = nuevaDorsal;
                    AnsiConsole.MarkupLine($"[bold green] Dorsal actualizada a[/] {jugador.Dorsal}");
                    break;
                case 6:
                    //Editar Posicion
                    AnsiConsole.MarkupLine("[bold]Ingrese la nueva posicion del jugador[/]");
                    AnsiConsole.MarkupLine($"[bold]Jugador Encontrado:[/] {jugador.Nombre}");
                    string nuevaPosicion = ValidarString.ValString("[bold]> [/]");
                    jugador.Posicion = nuevaPosicion;
                    AnsiConsole.MarkupLine($"[bold green] Posicion actualizada a[/] {jugador.Posicion}");
                    break;
                case 7:
                    //Editar Pierna Dominante
                    AnsiConsole.MarkupLine("[bold]Ingrese la pierna dominante del jugador[/]");
                    AnsiConsole.MarkupLine($"[bold]Jugador Encontrado:[/] {jugador.Nombre}");
                    string nuevaPiernaDominante = ValidarString.ValString("[bold]> [/]");
                    jugador.PiernaDominante = nuevaPiernaDominante;
                    AnsiConsole.MarkupLine($"[bold green] Edad actualizado a[/] {jugador.PiernaDominante}");
                    break;
                case 8:
                    //Editar Disponibilidad
                    AnsiConsole.MarkupLine("[bold]Ingrese la nueva disponibilidad del jugador[/]");
                    AnsiConsole.MarkupLine($"[bold]Jugador Encontrado:[/] {jugador.Nombre}");
                    bool nuevaDisponibilidad = AnsiConsole.Ask<bool>("[bold]> [/]");
                    jugador.Disponibilidad = nuevaDisponibilidad;
                    AnsiConsole.MarkupLine($"[bold green] Edad actualizado a[/] {jugador.Disponibilidad}");
                    break;
                default:
                    AnsiConsole.MarkupLine("[red]Opción no válida. Por favor, elija una opción entre 1 y 8.[/]");
                    break;
            }
        }


    }
}








// Eliminar Jugador









// Regresar al Menú Principal