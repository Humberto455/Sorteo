using System;

namespace Concurso
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, c;
            string[] participantes;
            Random aleatorio = new Random();// De esta manera podemos instanciar un numero aleatorio

            Console.WriteLine("\t\tCONCURSO AL AZAR!\n");
            Console.WriteLine("¿Cantidad de participantes?");
            r = int.Parse(Console.ReadLine());

            participantes = new string[r];

            c = 1;

            for (int i = 0; i < r; i++)
            {
                Console.WriteLine($"Ingresa el Nombre del participante: {c}");
                participantes[i] = Console.ReadLine();
                c++;
            }

            Console.WriteLine("\t\tLISTA DE PARTICIPANTES!\n");
            for (int q = 0; q < r; q++)
            {
                Console.WriteLine(participantes[q]);
            }

            Console.WriteLine("\t\tGANADOR!\n");
            Console.WriteLine($"El Ganador del concurso es: {participantes[aleatorio.Next(0, r)]}");

        }
    }
}
