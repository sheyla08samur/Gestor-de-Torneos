
public static class ValidarString
{
    public static void ValString(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentException("El valor no puede ser nulo o vacio.");
        }
    }
}

// Validar fecha inicio (>a fecha actual)
public static class ValidarFechaInicio
{
    public static void ValFechaInicio(DateTime fechaInicio)
    {
        if (fechaInicio < DateTime.Now)
        {
            throw new ArgumentException("La fecha de inicio no puede ser anterior a la fecha actual.");
        }
    }
}

// Validar fecha fin (>a fecha actual)
//public static class ValFechaFin
//{
//    public static void ValFechaFin(DateTime fechaFin)
//    {
//        if (fechaFin < DateTime.Now)
//        {
//            throw new ArgumentException("La fecha de fin no puede ser anterior a la fecha actual.");
//        }
//        if (fechaFin < fechaInicio)
//        {
//            throw new ArgumentException("La fecha de fin no puede ser anterior a la fecha de inicio.");
//        }
//    }
//}

// Validar que sea int
public static class ValInt
{
    public static void ValIntInput(int input)
    {
        if (input <= 0)
        {
            throw new ArgumentException("El valor debe ser un número entero positivo.");
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
            throw new ArgumentException("El valor debe ser un número decimal positivo.");
        }
    }
}