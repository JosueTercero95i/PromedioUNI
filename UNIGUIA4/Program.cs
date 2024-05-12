using System;

class Program
{
    static void Main(string[] args)
    {
        Universidad universidad = new Universidad();

        Alumno alumno1 = new Alumno("Adrian Arias", 17, Carreras.Ing_Electronica, "A123");
        alumno1.AgregarCalificacion(50);
        alumno1.AgregarCalificacion(0);
        alumno1.AgregarCalificacion(25);
        universidad.AgregarAlumno(alumno1);

        Console.WriteLine("Alumnos:");
        foreach (var alumno in universidad.ObtenerListaAlumnos())
        {
            string estado = alumno.EstadoAprobacion() == "aprobado" ? "Aprobado" : "Reprobado";
            Console.WriteLine($"Nombre: {alumno.Nombre}, Edad: {alumno.Edad}, Carrera: {alumno.Carrera}, Promedio: {alumno.CalcularPromedio()}, Estado: {estado}, Carnet: {alumno.ObtenerNumeroCarnet()}");
        }
    }
}
