using System;
using System.Globalization;

namespace TwelfthPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotAlun;
            double Nota1, Nota2, Nota3, MediaFinal;

            TotAlun = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            for (int i = 0; i<TotAlun; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                Nota1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                Nota2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                Nota3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                MediaFinal = Nota1 + Nota2 + Nota3;
                if(MediaFinal < 60.00)
                {
                    Console.WriteLine(MediaFinal.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("AVISO! Abaixo da média!");
                }
                else
                {
                    Console.WriteLine(MediaFinal.ToString("F2", CultureInfo.InvariantCulture));
                }
            }
            Console.ReadLine();
        }
    }
}
