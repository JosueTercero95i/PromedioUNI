using System;
using System.Collections.Generic;


public partial class Universidad
{
    private List<Alumno> ListaAlumnos;

    public Universidad()
    {
        ListaAlumnos = new List<Alumno>();
    }

    public void AgregarAlumno(Alumno alumno)
    {
        ListaAlumnos.Add(alumno);
    }

    public List<Alumno> ObtenerListaAlumnos()
    {
        return ListaAlumnos;
    }
}
public partial class Alumno
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    private string NumeroCarnet { get; set; }
    public Carreras Carrera { get; set; }
    public List<double> Calificaciones { get; set; }

    public Alumno(string nombre, int edad, Carreras carrera, string numeroCarnet)
    {
        Nombre = nombre;
        Edad = edad;
        Carrera = carrera;
        NumeroCarnet = numeroCarnet;
        Calificaciones = new List<double>();
    }

    public double CalcularPromedio()
    {
        if (Calificaciones.Count == 0)
        {
            return 0;
        }

        double SumaCalificaciones = 0;
        foreach (var Calificacion in Calificaciones)
        {
            SumaCalificaciones += Calificacion;
        }
        return SumaCalificaciones / Calificaciones.Count;
    }

    public string EstadoAprobacion()
    {
        double promedio = CalcularPromedio();
        if (promedio >= 60)
        {
            return "aprobado";
        }
        else
        {
            return "desaprobado";
        }
    }

    public void AgregarCalificacion(double calificacion)

    {
        Calificaciones.Add(calificacion);
    }


    public string ObtenerNumeroCarnet()
    {
        return NumeroCarnet;
    }

    public void AsignarNumeroCarnet(string numeroCarnet)
    {
        NumeroCarnet = numeroCarnet;
    }
}

public enum Carreras
{
    Ing_Sistemas,
    Ing_Computacion,
    Ing_Telecomunicaciones,
    Ing_Electronica
}


