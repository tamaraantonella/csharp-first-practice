using System;
namespace primer_programa
{
    class Program
    {
    static void Main(string[] args)
    {
      //3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos).
      //El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo.
      // Mostrar el resultado en pantalla. Ejemplo:
      // CADENA FUENTE: “La mar estaba serena"
      // CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
      // CADENA RESULTADO: “Li mir estibi sereni"
      string cadena;
      char caracter1, caracter2;
      Console.WriteLine("Ingrese una cadena de caracteres");
      cadena = Console.ReadLine();
      char[] nuevaCadena = new char[cadena.Length];
      Console.WriteLine("Ingrese un caracter a reemplazar");
      caracter1 = char.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese el caracter que reemplazara");
      caracter2 = char.Parse(Console.ReadLine());
      for (int i = 0; i < cadena.Length; i++)
      {
        if (cadena[i] == caracter1) {
          nuevaCadena[i] = caracter2;
        } else{
          nuevaCadena[i] = cadena[i];
        }
      }
      for (int i = 0; i < nuevaCadena.Length; i++)
      {
        Console.Write(nuevaCadena[i]);
      }

    }
  }
}