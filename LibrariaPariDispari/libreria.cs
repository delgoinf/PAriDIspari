using System;

namespace LibrariaPariDispari
{
    public class libreria
    {
        public class paridispariinterval
        {
            public static uint Leggiintero()
            {
                Console.Write("inserisci un numero intero e positivo: ");
                uint a = uint.Parse(Console.ReadLine());
                return a;
            }
            public static void PariDispari(uint a, uint b)
            {
                int contatoreP = 0, contatoreD = 0;
                uint max = Math.Max(a, b);
                uint min = Math.Min(a, b);
                for (uint i = min; i <= max; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"{i}pari;");
                        contatoreP++;
                    }
                    else
                    {
                        Console.WriteLine($"{i}dipari;");
                        contatoreD++;
                    }
                }
                Console.WriteLine($"i numeri sono pari{contatoreP}dispari{contatoreD}");
            }
        }
    }
}
