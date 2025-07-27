using Spectre.Console;
namespace liga;
public static class AnimacionCarga
{
    public static void MostrarAnimacionCarga()
    {
        AnsiConsole.Clear();
        AnsiConsole.Progress()
            .Start(ctx =>
            {
                var task = ctx.AddTask("Cargando datos");
                while (!ctx.IsFinished)
                {
                    task.Increment(5);
                    Thread.Sleep(100);
                }
            });
    }
}

public static class AnimacionEdicion
{
    public static void MostrarAnimacionEdicion()
    {
        AnsiConsole.Clear();
        AnsiConsole.Progress()
            .Start(ctx =>
            {
                var task = ctx.AddTask("Editando datos");
                while (!ctx.IsFinished)
                {
                    task.Increment(5);
                    Thread.Sleep(100);
                }
            });
    }
}

public static class AnimacionEliminar
{
    public static void MostrarAnimacionEliminar()
    {
        AnsiConsole.Clear();
        AnsiConsole.Progress()
            .Start(ctx =>
            {
                var task = ctx.AddTask("Eliminando datos");
                while (!ctx.IsFinished)
                {
                    task.Increment(5);
                    Thread.Sleep(100);
                }
            });
    }
}

public static class AnimacionSalir
{
    public static void MostrarAnimacionSalir()
    {
        AnsiConsole.Clear();
        AnsiConsole.Progress()
            .Start(ctx =>
            {
                var task = ctx.AddTask("Saliendo...");
                while (!ctx.IsFinished)
                {
                    task.Increment(5);
                    Thread.Sleep(100);
                }
            });
    }
}