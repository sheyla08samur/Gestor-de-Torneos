namespace Liga;

public class Persona
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Origen { get; set; }
    public string? Email { get; set; }

    public Persona(int id, string? nombre, string? origen, string? email)
    {
        Id = id;
        Nombre = nombre;
        Origen = origen;
        Email = email;
    }
    public Persona() { }
    public override string ToString()
    {
        return $"ID: {Id}, Nombre: {Nombre}, Origen: {Origen}, Email: {Email}";
    }
}
