public class DocumentoIdentidad
{
    public string Numero { get; private set; }
    public DocumentoIdentidad(string numero)
    {
        if (/* validar formato de documento */)
        {
            Numero = numero;
        }
        else
        {
            throw new ArgumentException("Formato de documento no válido");
        }
    }
}

public class Elector
{
    public string Nombre { get; set; }
    public DocumentoIdentidad Documento { get; set; }
}