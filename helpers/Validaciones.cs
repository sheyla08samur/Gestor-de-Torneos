
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using Spectre.Console;

namespace Liga.Helpers;

public static class ValidarString
{
    public static string ValString(string input)
    {
        string nombre = AnsiConsole.Ask<string>(input);
    if (string.IsNullOrWhiteSpace(nombre))
    {
        AnsiConsole.MarkupLine("El valor no puede ser nulo o vacio.");
        return ValString(input);
    }
    foreach (char e in nombre)
    {
        if (char.IsDigit(e))
        {
            AnsiConsole.MarkupLine("El valor no puede contener números.");
            return ValString(input);
        }
    }
    return nombre;
    }
}

// Validar fecha inicio (>a fecha actual)
public static class ValidarFecha
{
    public static DateTime ValFechaInicio(string msg)
    {
        DateTime fechaInicio = AnsiConsole.Ask<DateTime>(msg);
        if (fechaInicio < DateTime.Now)
        {
            AnsiConsole.MarkupLine("[red]La fecha de inicio no puede ser anterior a la fecha actual.[/]");
            return ValFechaInicio(msg);
        }
        return fechaInicio;
    }

    public static DateTime ValFechaFin(string msg, DateTime fechaInicio)
    {
        DateTime fechaFin = AnsiConsole.Ask<DateTime>(msg);
        if (fechaFin < fechaInicio)
        {
            AnsiConsole.MarkupLine("[red]La fecha de fin no puede ser anterior a la fecha de inicio.[/]");
            return ValFechaFin(msg, fechaInicio);
        }
        return fechaFin;
    }
}

// Validar que sea int
public static class ValInt
{
    public static void ValIntInput(int input)
    {
        if (input <= 0)
        {
            AnsiConsole.MarkupLine("El valor debe ser un número entero positivo.");
        }
    }
}

// Validar que sea double
public static class ValidarDouble
{
    public static void ValDoubleInput(double input)
    {
        if (input <= 0)
        {
            AnsiConsole.MarkupLine("El valor debe ser un número decimal positivo.");
        }
    }
}

//public static class ValidarString
//{
//    public static string ValString(string input)
//    {
//        string nombre = AnsiConsole.Ask<string>(input);
//        if (!string.IsNullOrWhiteSpace(nombre))
//        {
//            return nombre;
//        }
//        AnsiConsole.MarkupLine("El valor no puede ser nulo o vacio.");
//        return string.Empty;
//
//    }
//}