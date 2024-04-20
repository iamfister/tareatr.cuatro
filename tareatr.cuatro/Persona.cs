namespace tareatr.cuatro;

public abstract class Persona
{
    protected Guid Id { get; init; } = Guid.NewGuid();
    private string _nombre { get; set; } = default!;
    private string ApellidoPaterno { get; set; }
    private string? ApellidoMaterno { get; set; } = default!;
    private int _edad { get; set; }
    
    public int Edad
    {
        get => _edad;
        private set => _edad = value;
    }

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    protected Persona(int edad, string nombre, string apellidoPaterno, string? apellidoMaterno = null)
    {
        Nombre = nombre;
        Edad = edad;
        ApellidoPaterno = apellidoPaterno;
        ApellidoMaterno = apellidoMaterno;
    }

    protected string DetallePersona()
    {
        return $"Nombre Completo: {Nombre} {ApellidoPaterno} {ApellidoMaterno}\nEdad: {Edad}";
    }
}