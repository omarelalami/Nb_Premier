using System;

namespace Nb_premier
{
    class Program
    {
        static void Main(string[] args)
        { int N,cmt=0;
           

            do
            {
                Console.Write("Donner un Nombre Entier: ");
                N = int.Parse(Console.ReadLine());
            }
            while (N < 0);
            
        
                for (int i = 0; i < N / 2; i++)
                    if (N % 2 == 0)
                        cmt++;
                
                if (cmt > 2)
                    Console.WriteLine("Ce nombre n'est pas premier");
                else
                    Console.WriteLine("Ce nombre est  premier");
            Console.ReadKey();
          }
    }
}
