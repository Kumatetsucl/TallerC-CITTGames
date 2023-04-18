using System.Diagnostics;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();

        Console.WriteLine("ingrese la cantidad de vida del personaje: ");
        int _usuario = int.Parse(Console.ReadLine()); /*vida inicial de nuestro personaje proporcionada por 
                                                       //"Console.WriteLine("ingrese la cantidad de vida del personaje");"*/
        int _enemigo = 500; // Vida inicial del enemigo

        while (_usuario <= 0 || _enemigo <= 0)
        {
            int _numeroRandom = rand.Next(1, 10);
            if (_numeroRandom % 2 == 0)
            {
                Console.WriteLine("HIT: " + _numeroRandom);
                _usuario -= _numeroRandom;
                Console.WriteLine("Tirando Dados..." + "\n");
            }
            else if (_numeroRandom == 1)
            {
                Console.WriteLine("Sanacion!: " + 2);
                _usuario += 2;
                Console.WriteLine("Tirando Dados..." + "\n");
            }
            else
            {
                Console.WriteLine("Tu personaje rodó como chanchito, el enemigo Falló");
                Thread.Sleep(200);
                Console.WriteLine("Tirando Dados..." + "\n");
            }
            _enemigo -= 5;// Resta 5 puntos de vida al enemigo
            Console.WriteLine("Vida del personaje: " + _usuario);
            Console.WriteLine("Vida del enemigo: " + _enemigo + "\n");
            Thread.Sleep(1000);
        }

        if (_usuario <= 0)
        {
            Console.WriteLine("Tu personaje murió F en el Chat");
        }
        else if (_enemigo <= 0)
        {
            Console.WriteLine("Ganaste la Batalla! Enemigo Derrotado!");
        }
    }
}



/*
  // == igual  
  // <= menor que 
  // >= mayor que
  // != diferente
  // -= restar una cantidad
  // += sumar una cantidad
  // ++ para sumar de 1
  // -- para restar de 1

while (condicion == condicion)
 {
    //acá va lo que uno quiera que pase dentro del while
}
*/