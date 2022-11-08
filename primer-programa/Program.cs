// See https://aka.ms/new-console-template for more information
using System;
namespace primer_programa
{
    class Program
    {
    // programa principal (función principal)
    static void Main(string[] args)
    {
      int km,vel;
      Console.WriteLine("Ingresar km existentes  entre ambas ciudades");

      km = int.Parse(Console.ReadLine());
      Console.WriteLine("Ingresar velocidad promedio");
      vel = int.Parse(Console.ReadLine());
      float tiempo;
      tiempo = km/vel;
      Console.WriteLine("El tiempo de viaje es de: " + tiempo + " horas");
    }
    }
}

