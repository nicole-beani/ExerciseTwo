using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il nome :");
            string nome = Console.ReadLine();

            Console.WriteLine("Inserisci il cognome :");
            string cognome = Console.ReadLine();

            Console.WriteLine("Inserisci l'età :");
            double età = Convert.ToDouble(Console.ReadLine());

            Persona persona = new Persona(nome, cognome, età);
            persona.GetDettagli();

           


            Prodotto prodotto = new Prodotto();
            prodotto.Nome = "Mario";
            prodotto.Prezzo = 100;
            prodotto.Quantità = 7;
            prodotto.GetCalcoloTotaleProc();
            Console.ReadLine();
        }
    }
}
     
