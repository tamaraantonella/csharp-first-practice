using System;
namespace primer_programa
{
    class Program
    {
    static void Main(string[] args)
    {
      //3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
      int suma=0,acc=0;
      for (int i = 0; i < 20; i++)
      {
        Console.WriteLine("Ingrese la edad");
        int edad = int.Parse(Console.ReadLine());
        if (edad > 18)
        {
          acc++;
          suma += edad;
        }
      }
      Console.WriteLine("El promedio de edades es: " + suma/acc);
    }
    }
}