namespace Liga.models;
public class Jugador : Persona
{
    public int Dorsal { get; set; }
    public string? Posicion { get; set; }

    public Jugador(int id, string? nombre, string? origen, string? email, int dorsal, string? posicion)
    {
        Id = id;
        Nombre = nombre;
        Origen = origen;
        Email = email;
        Dorsal = dorsal;
        Posicion = posicion;
    }
    public Jugador() { }
    public override string ToString()
    {
        return $"Jugador: {Nombre} ({Dorsal}) - {Posicion} \n" +
       $"Origen: {Origen}, Email: {Email}";
    }
}