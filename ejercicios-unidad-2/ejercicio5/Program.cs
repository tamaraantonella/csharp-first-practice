using System;
namespace primer_programa
{
    class Program
    {
    static void Main(string[] args)
    {
      //5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno
      //y luego calcule y emita por pantalla el promedio final.
      float nota1, nota2, nota3, promedio;
      Console.WriteLine("Ingrese la nota del primer parcial");
      nota1=float.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese la nota del segundo parcial");
      nota2=float.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese la nota del tercer parcial");
      nota3=float.Parse(Console.ReadLine());
      promedio = (nota1 + nota2 + nota3) / 3;
      Console.WriteLine("El promedio de las notas es: " + promedio.ToString("0.00"));

    }
    }
}