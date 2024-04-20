namespace tareatr.cuatro;

public class Nota
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public Guid MateriaId { get; set; }
    public Guid EstudianteId { get; set; }
    public decimal Puntaje { get; set; }
}