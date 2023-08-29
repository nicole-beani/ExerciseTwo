using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTwo
{
    internal class Prodotto
    {
        public string Nome { get; set; }
        
        

        public double _prezzo;
        public double Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }
        public double _quantità;
        public double Quantità
        {
            get { return _quantità; }
            set { _quantità = value; }
        }
        public double GetCalcoloTotale()
        {
            return (_prezzo + _quantità);
        }
        public void GetCalcoloTotaleProc()
        {
            Console.WriteLine(GetCalcoloTotale());
        }
    }
}

