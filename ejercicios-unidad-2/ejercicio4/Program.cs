using System;
namespace primer_programa
{
    class Program
    {
    static void Main(string[] args)
    {
      float facturado,comision,total;
      const float porcentaje = 0.05f; // 5% de comisión
      const int sueldo = 15000;
      Console.WriteLine("Ingresar total facturado");
      facturado = float.Parse(Console.ReadLine());
      comision= facturado * porcentaje;
      total = sueldo + comision;
      Console.WriteLine("La comisión es de: " + comision + " y el total a cobrar es de: " + total);
    }
    }
}