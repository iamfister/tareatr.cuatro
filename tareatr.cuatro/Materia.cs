namespace tareatr.cuatro;

public class Materia
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Nombre { get; set; } = default!;
}