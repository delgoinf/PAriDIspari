using System;
using LibrariaPariDispari;

namespace paridispari
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = libreria.Leggiintero();
            uint n1 = libreria.leggiintero();
            paridispari.PariDispari(n, n1);

        }
    }
}