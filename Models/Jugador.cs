namespace Liga.Models;

public class Jugador : Persona
{
    public int Dorsal { get; set; }
    public string? Posicion { get; set; }
    public string? PiernaDominante { get; set; }
    public bool Disponibilidad { get; set; }

    public Jugador(int id, string? nombre, int edad, string? origen, string? email, int dorsal, string? posicion, string? piernadominante, bool disponibilidad)
    {
        Id = id;
        Nombre = nombre;
        Edad = edad;
        Origen = origen;
        Email = email;
        Dorsal = dorsal;
        Posicion = posicion;
        PiernaDominante = piernadominante;
        Disponibilidad = disponibilidad;
    }
    public Jugador() { }
    public override string ToString()
    {
        return $"Jugador: {Nombre} ({Dorsal}) - {Posicion} \n" +
       $"Edad: {Edad}\nOrigen: {Origen}\nEmail: {Email}\nPierna Dominante: {PiernaDominante}\nDisponibilidad: {(Disponibilidad ? "Diaponible" : "No Disponible")}";
    }
}


/*
Jugador
|-> Nombre
|-> Nacionalidad
|-> Edad
|-> Dorsal
|-> Posición
|-> Pierna Dominante
|-> Disponibilidad
*/