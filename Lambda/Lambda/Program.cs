using System;


using Lambda;

class Program
{
    static void Main(string[] args)
    {
        // 1. Crear una lista de estudiantes con al menos 5 elementos
        List<Estudiante> estudiantes = new List<Estudiante>
            {
                new Estudiante { Nombre = "Karolina", Edad = 19, Nota = 8.5 },
                new Estudiante { Nombre = "Ian", Edad = 20, Nota = 9.0 },
                new Estudiante { Nombre = "Alex", Edad = 19, Nota = 7.8 },
                new Estudiante { Nombre = "Michelle", Edad = 18, Nota = 9.2 },
                new Estudiante { Nombre = "Mélida", Edad = 18, Nota = 8.0 }
            };

         //Usar expresiones lambda para realizaar las siguientes operaciones:

        // 1. Filtrar los estudiantes cuya edad es mayor a 18 años
        var mayoresDe18 = estudiantes.Where(e => e.Edad > 18).ToList();
        Console.WriteLine("Estudiantes mayores de 18 años:");
        foreach (var estudiante in mayoresDe18)
        {
            Console.WriteLine($"Nombre: {estudiante.Nombre}, Edad: {estudiante.Edad}, Nota: {estudiante.Nota}");
        }

        // 2. Obtener el estudiante con la nota más alta
        var mejorEstudiante = estudiantes.OrderByDescending(e => e.Nota).FirstOrDefault();
        if (mejorEstudiante != null)
        {
            Console.WriteLine($"\nEstudiante con la nota más alta: {mejorEstudiante.Nombre} con nota {mejorEstudiante.Nota}");
        }

        // 3. Ordenar la lista de estudiantes por nombre en orden ascendente
        var estudiantesOrdenados = estudiantes.OrderBy(e => e.Nombre).ToList();
        Console.WriteLine("\nEstudiantes ordenados por nombre:");
        foreach (var estudiante in estudiantesOrdenados)
        {
            Console.WriteLine($"Nombre: {estudiante.Nombre}, Edad: {estudiante.Edad}, Nota: {estudiante.Nota}");
        }

        // 4. Calcular el promedio de notas de los estudiantes
        var promedioNotas = estudiantes.Average(e => e.Nota);
        Console.WriteLine($"\nPromedio de notas de los estudiantes: {promedioNotas}");
    }
}
