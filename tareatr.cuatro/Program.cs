using tareatr.cuatro;

Console.WriteLine("Personal Administrativo: ");

var personalAdministrativo = new PersonalAdministrativo(
    "Aux Administrativo",
    "Sistemas Computacionales",
    30,
    "Sofia Maria",
    "Martinez",
    "Perez");

personalAdministrativo.PerfilAdministrativo();

Console.WriteLine("Profesor: ");

var profesor = new Profesor(
    "TEC Campeche",
    "Ing. Sistemas Computacionales",
    5,
    30,
    "Alejandra Kaede",
    "Perez",
    "Perez");

profesor.PerfilEducativo();

Console.WriteLine("Estudiante: ");

var estudiante = new Estudiante(28, "Cristian Yair","Gutierrez");

profesor.GenerarNotas(personalAdministrativo.GenerarMaterias(), estudiante);

estudiante.CalcularPromedio();
estudiante.Detalle();
