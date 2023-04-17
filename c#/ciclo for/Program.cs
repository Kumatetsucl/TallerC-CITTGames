using System.Runtime.InteropServices;

namespace _cicloFor
{
    class program
    { 
        static void Main(string[] args)
        {
            string _usuario;
            bool autenticado = false;
            for (int i =1 ; i <= 5; i++) {
                Console.WriteLine("adivina la palabra: ");
                _usuario = Console.ReadLine();
                if (_usuario == "Hola") {
                    autenticado = true;
                    break;
                }
            }
            if (autenticado == true) {
                Console.WriteLine("Ganaste");
            }else {
                Console.WriteLine("perdiste");
                Console.ReadKey();
            }
        }
    }
}