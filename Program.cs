/*
Autor: Sheyla Samur Rojas
Fecha: 07/24/25
Descripción: Este programa es para practicar C# realizando un gestor de Torneos con equipos, jugadores, partidos, cuerpo tecnico y cuerpo medico.
*/
using Liga.models;

namespace Liga;

internal class Program
{
    public static List<Torneo> torneos = new List<Torneo>(); 

    private static void Main(string[] args)
    {
        MenuHandler.MostrarMenuHandler();
    }
}