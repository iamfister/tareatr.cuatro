namespace tareatr.cuatro;

public class PersonalAdministrativo : Persona
{
    public string Cargo { get; private set; }
    public string Departamento { get; private set; }
    
    public PersonalAdministrativo(
        string cargo,
        string departamento,
        int edad,
        string nombre,
        string apellidoPaterno, 
        string? apellidoMaterno = null) : base(
        edad,
        nombre,
        apellidoPaterno,
        apellidoMaterno)
    {
        Cargo = cargo;
        Departamento = departamento;
    }

    public ICollection<Materia> GenerarMaterias()
    {
        List<Materia> materias = new List<Materia>();
        for (int i = 0; i < 5; i++)
        {
            materias.Add(new Materia($"Materia {i}"));
        }

        return materias;
    }
    
    public void PerfilAdministrativo()
    {
        Console.WriteLine(
            $"{DetallePersona()}\nCargo: {Cargo} \nDepartamento: {Departamento}");
    }
}