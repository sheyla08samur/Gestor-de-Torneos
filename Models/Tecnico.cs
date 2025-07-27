namespace Liga.models;
public class Tecnico : Persona
{
    public string? Cargo { get; set; }
    public Tecnico(int id, string? nombre, string? origen, string? email, string? cargo)
    {
        Id = id;
        Nombre = nombre;
        Origen = origen;
        Email = email;
        Cargo = cargo;
    }
    public Tecnico() { }
    public override string ToString()
    {
        return $"Id: {Id}, Nombre: {Nombre}, Origen: {Origen}, Email {Email}, Cargo: {Cargo}";
    }
}