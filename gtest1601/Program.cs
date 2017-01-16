using System;

namespace FirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // määritellään muuttuja
            string nimi = "Matti Mainio";
            string nimi2 = "Matti Mainio00000";
            // tulostetaan muuttujan arvo konsolille
            Console.WriteLine("Nimi on " + nimi);
            Console.WriteLine("Nimi on " + nimi2);
            // pidetään sovelluksen ajoikkuna näytöllä. Sulkeutuu, kun enter-painiketta on painettu
            Console.ReadLine();
        }
    }
}