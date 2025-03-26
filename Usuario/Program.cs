using Interface;
using Servicio;
using Strategy;

namespace Usuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StrategyConversor strategyConversor = new StrategyConversor(new Mayúsculas());

            while (true)
            {
                Console.WriteLine("==Convertir== ");
                Console.WriteLine("===MENU==");

                Console.WriteLine("Ingrese el texto ");
                string texto = Console.ReadLine()!;

                Console.WriteLine("\n1 Mayusculas");
                Console.WriteLine("\n2 Formato_titulo");
                Console.WriteLine("\n3 Minuscula");


                int opcion = int.Parse(Console.ReadLine()!);

                switch (opcion)
                {
                    case 1:
                       strategyConversor.CambiarStrategy(new Mayúsculas());
                        strategyConversor.ConvertirTexto(texto);

                        break;

                    case 2:
                         strategyConversor.CambiarStrategy(new Formato_título());
                         strategyConversor.ConvertirTexto(texto);

                        break;

                    case 3:
                        strategyConversor.CambiarStrategy(new Minúsculas());
                        strategyConversor.ConvertirTexto(texto);
                        break;
                }

            }
        }

    }
    
}
