public class Eleccion
{
    public string Tipo { get; set; }
    public int Año { get; set; }

    public void MostrarDetalles()
    {
        Console.WriteLine($"Tipo: {Tipo}, Año: {Año}");
    }
}