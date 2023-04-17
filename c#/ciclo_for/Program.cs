using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciclo_for
{
    internal class Program
    {
        static void Main(String[] args)
        {
            String _usuario;
            /*Se crea una variable tipo string que la llamaremos _usuario donde le daremos 
             el valor de la palabra que el usuario ingrese para ser validada*/

            bool _autenticado = false;
            /*se crea una variable tipo booleano llamada _autenticado, le daremos valor de false hasta
             que se cambie si se cumple la condicion dentro del ciclo for*/

            for (int i =1; i<= 5; i++)
            { /*estructura for ( nombrar variable tipo Integer en este caso,
                la llamamos i de item y le dimos valor de 1; se declara la cantidad de veces que se
                recorre el ciclo con una cantidad igual o mayor a 5 ; cada vez que termine un ciclo for
                se irá sumando (+1) a la variable i)*/

                Console.WriteLine("Adivina la Palabra: "); //hace lo mismo que un print de python
                _usuario = Console.ReadLine();  //hace lo mismo que un Input de python 
                if (_usuario == "perro") { 
                    _autenticado = true;
                    break;
                }
            }
            if (_autenticado == true)
            {
                Console.WriteLine("Ganaste Maldito Gusano");
            }
            else {
                Console.WriteLine("Perdiste gg no team");
                Console.ReadKey();
            }
        }
    }
}