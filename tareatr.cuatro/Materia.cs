namespace tareatr.cuatro;

public class Materia
{
    public Materia(string nombre)
    {
        Nombre = nombre;
    }

    public Guid Id { get; init; } = Guid.NewGuid();
    public string Nombre { get; set; } = default!;
}