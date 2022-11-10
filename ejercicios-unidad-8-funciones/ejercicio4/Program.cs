using System;
namespace primer_programa
{
    class Program
    {
    static void Main(string[] args)
    {
      //4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero”
      // que reciba un número por valor y una variable por referencia.
      //Que analice el número y escriba variable recibida por referencia con:
      //a. 1 si el número es positivo.
      // b. -1 si el número es negativo.
      // c. 0 si el número es cero.
      int variable=0, numero;
      Console.WriteLine("Ingrese un numero");
      numero = int.Parse(Console.ReadLine());
      positivoNegativoCero(numero, ref variable);
      Console.WriteLine("El numero {0} es variable a {1}", numero, variable);

    }
    static void positivoNegativoCero(int numero, ref int variable) {
      if(numero > 0)
        variable=1;
      else if(numero < 0)
        variable=-1;
      else
        variable=0;
    }
  }
}