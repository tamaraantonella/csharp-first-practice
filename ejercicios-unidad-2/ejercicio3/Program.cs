using System;
namespace primer_programa
{
    class Program
    {
    // programa principal (función principal)
    static void Main(string[] args)
    {
      float km,vel,tiempo;
      Console.WriteLine("Ingresar km existentes  entre ambas ciudades");
      km = float.Parse(Console.ReadLine());
      Console.WriteLine("Ingresar velocidad promedio");
      vel = float.Parse(Console.ReadLine());
      tiempo = km/vel;
      //formateo tiempo para que me muestre asi el resultado y no con muchos decimales
      Console.WriteLine("El tiempo de viaje es de: " + tiempo.ToString("0.00") + " horas");
    }
    }
}

