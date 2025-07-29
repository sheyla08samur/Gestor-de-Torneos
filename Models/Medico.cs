namespace Liga.Models;
public class Medico : Persona
{
    public string? Especializacion { get; set; }
    public Medico(int id, string? nombre, string? origen, string? email, string? especializacion)
    {
        Id = id;
        Nombre = nombre;
        Origen = origen;
        Email = email;
        Especializacion = especializacion;
    }
    public Medico() { }
    public override string ToString()
    {
        return $"Médico: {Nombre} -  Especialización: {Especializacion} \n" +
       $"Origen: {Origen}, Email: {Email}";
    }
}