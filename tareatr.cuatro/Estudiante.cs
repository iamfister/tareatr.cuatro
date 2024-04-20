namespace tareatr.cuatro;

public class Estudiante : Persona
{
    private decimal Promedio { get; set; }
    private ICollection<Nota> _notas { get; set; }
    
    public ICollection<Nota> Notas
    {
        get => _notas;
        private set => _notas = value;
    }
    
    public Estudiante(
        int edad,
        string nombre,
        string apellidoPaterno,
        string? apellidoMaterno = null) : base(edad,
        nombre,
        apellidoPaterno,
        apellidoMaterno)
    {
        Notas = new List<Nota>();
    }

    public void AgregarNota(Guid materiaId, decimal puntaje)
    {
        Notas.Add(new Nota(materiaId, Id, puntaje));
    }

    public void CalcularPromedio()
    {
        if (Notas.Count == 0)
        {
            return;
        }
        
        Promedio = Notas.Sum(p => p.Puntaje) / Notas.Count;
    }
    
    public void Detalle()
    {
        Console.WriteLine($"{DetallePersona()}\nPromedio: {Promedio}");
    }
}