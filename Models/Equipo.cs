namespace Liga.models;

public class Equipo
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Origen { get; set; }
    public List<Jugador> Jugadores { get; set; } = new List<Jugador>();
    public List<Tecnico> Tecnicos { get; set; } = new List<Tecnico>();
    public List<Medico> Medicos { get; set; } = new List<Medico>();
    public Equipo(int id, string? nombre, string? origen)
    {
        Id = id;
        Nombre = nombre;
        Origen = origen;
    }
    public Equipo() { }
    public override string ToString()
    {
        return $"Equipo: {Nombre}, Origen: {Origen}, Jugadores: {Jugadores.Count}, Tecnicos:{Tecnicos.Count}, Medicos: {Medicos.Count}";
    }
}