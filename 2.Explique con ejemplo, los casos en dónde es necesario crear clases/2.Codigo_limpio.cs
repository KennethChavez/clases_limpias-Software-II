public class Candidato
{
    public string Nombre { get; set; }
    public string Partido { get; set; }
    public int Edad { get; set; }
}

Candidato candidato = new Candidato { Nombre = "Ana Martínez", Partido = "Partido X", Edad = 45 };