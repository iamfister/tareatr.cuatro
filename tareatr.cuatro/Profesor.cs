namespace tareatr.cuatro;

public class Profesor : Persona
{
    private string Institucion { get; set; }
    private string Carrera { get; set; }
    private int AnioExperiencia { get; set; }
    
    public Profesor(
        string institucion,
        string carrera,
        int anioExperiencia,
        int edad,
        string nombre,
        string apellidoPaterno,
        string? apellidoMaterno = null) : base(edad,
        nombre,
        apellidoPaterno,
        apellidoMaterno)
    {
        Institucion = institucion;
        Carrera = carrera;
        AnioExperiencia = anioExperiencia;
    }

    public void PerfilEducativo()
    {
        Console.WriteLine(
            $"{DetallePersona()}\nInstitucion: {Institucion} \nCarrera: {Carrera} \nAnios De Experiencia: {AnioExperiencia}");
    }
    
    public void GenerarNotas(ICollection<Materia> materias, Estudiante estudiante)
    {
        foreach (var item in materias)
        {
            estudiante.AgregarNota(item.Id, new Random().Next(0, 10));
        }
    }
}