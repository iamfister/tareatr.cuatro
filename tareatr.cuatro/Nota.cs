namespace tareatr.cuatro;

public class Nota
{
    public Nota(Guid materiaId, Guid estudianteId, decimal puntaje)
    {
        MateriaId = materiaId;
        EstudianteId = estudianteId;
        Puntaje = puntaje;
    }

    public Guid Id { get; init; } = Guid.NewGuid();
    public Guid MateriaId { get; set; }
    public Guid EstudianteId { get; set; }
    public decimal Puntaje { get; set; }
}