using Spectre.Console;
namespace liga;
public static class AnimacionCarga
{
    public static void MostrarAnimacionCarga(string mensaje)
    {
        AnsiConsole.Clear();
        AnsiConsole.Progress()
            .Start(ctx =>
            {
                var task = ctx.AddTask(mensaje);
                while (!ctx.IsFinished)
                {
                    task.Increment(5);
                    Thread.Sleep(100);
                }
            });
    }
}