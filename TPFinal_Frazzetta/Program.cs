namespace TPFinal_Frazzetta;
class Program
{
    static void Main(string[] args)
    {
    //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero.
    //A partir de dichos datos informar:
    // a. El mayor de los números pares.
    // b. La cantidad de números impares.
    // c. El menor de los números primos.
    // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.
    int num=0, mayorPares=0, cantImpares = 0, menorPrimos=0;
    bool[] firsRound = { true, true };
    ingresarDato(ref num);
    while (num != 0) {
        if (num % 2 == 0  && firsRound[0]) {
            mayorPares = num;
            firsRound[0] = false;
        } else if (num % 2 == 0 && num > mayorPares && !firsRound[0]) {
            mayorPares = num;
        } else if (num % 2 != 0) {
            cantImpares++;
        }
        if (primo(num) && firsRound[1]) {
            menorPrimos = num;
            firsRound[1] = false;
        } else if(primo(num) && num < menorPrimos && !firsRound[1]) {
            menorPrimos = num;
        }
        ingresarDato(ref num);

    }
    if(mayorPares == 0) {
        Console.WriteLine("No se ingresaron numeros pares");
    } else {
        Console.WriteLine("El mayor de los numeros pares es: " + mayorPares);
    }
    Console.WriteLine("La cantidad de números impares es: " + cantImpares);
    if(menorPrimos == 0) {
        Console.WriteLine("No se ingresaron números primos");
    } else {
        Console.WriteLine("El menor de los números primos es: " + menorPrimos);
    }
  }
  static void ingresarDato(ref int num) {
    Console.WriteLine("Ingrese un numero");
    num = int.Parse(Console.ReadLine());
   }
  static bool primo(int numero) {
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
        return true;
      }
      else
      {
        return false;
      }
     }
}
