namespace Liga;

public class Torneo
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public List<Equipo> Equipos { get; set; } = new List<Equipo>();

    public Torneo(int id, string? nombre, DateTime fechaInicio, DateTime fechaFin)
    {
        Id = id;
        Nombre = nombre;
        FechaInicio = fechaInicio;
        FechaFin = fechaFin;
    }
    public Torneo() { }
    public override string ToString()
    {
        return $"Torneo: {Nombre}, Fecha Inicio: {FechaInicio.ToShortDateString()}, Fecha Fin: {FechaFin.ToShortDateString()}, Equipos: {Equipos.Count}";
    }
}
