﻿using System;
namespace primer_programa
{
    class Program
    {
    static void Main(string[] args)
    {
      //2. Hacer un programa que solicite el ingreso de 10 números
      //y que muestre el mayor de ellos por pantalla.
      //Solo se debe emitir UN valor por pantalla.
      int mayor=0;
      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine("Ingrese un numero");
        int actual = int.Parse(Console.ReadLine());
        if(i==0)
          mayor = actual;
        if(actual > mayor)
          mayor = actual;
      }
      Console.WriteLine("El mayor es: " + mayor);
    }
    }
}