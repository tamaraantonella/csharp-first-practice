using System;
namespace primer_programa
{
    class Program
    {
    static void Main(string[] args)
    {
      //3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es.
      //  Hacer un programa para ingresar números
      //El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.
      int ingreso, acumulador=0, contador=0;
      Console.WriteLine("Ingrese un numero");
      ingreso = int.Parse(Console.ReadLine());
      while(ingreso != 0){
        int respuesta = primo(ingreso);
          if(respuesta == 1){
            Console.WriteLine("El numero {0} es primo", ingreso);
            contador++;
            acumulador += ingreso;
          } else {
            Console.WriteLine("El numero {0} no es primo", ingreso);
          }
        ingresarNros(ref ingreso);
      }
      Console.WriteLine("El promedio de los numeros primos es {0}", acumulador/contador);
    }
    static void ingresarNros(ref int ingreso) {
      Console.WriteLine("Ingrese un numero");
      ingreso = int.Parse(Console.ReadLine());
     }
    static int primo(int numero) {
      int contador = 0;
      for (int i = 1; i <= numero; i++)
      {
        if (numero % i == 0)
        {
          contador++;
        }
      }
      if (contador == 2)
      {
        return 1;
      }
      else
      {
        return 0;
      }
     }
  }
}