using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTwo
{
    internal class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public double _età;
        public double Età
        {
            get { return _età; }
            set { _età = value; }
        }


        public string FullName
        {
            get
            {
                return Nome + " " + Cognome;
            }
        }



        public string GetFullName()
        {
            return Nome + " " + Cognome;
        }

        public void GetDettagli()
        {
            Console.WriteLine(Nome + " " + Cognome + " " + Età);
        }

        public Persona() { }

        public Persona(string n, string c)
        {
            Nome = n;
            Cognome = c;
        }

        public Persona(string _nome,
                            string _cognome,
                            double età
                            ) : this(_nome, _cognome)
        {
            Età = età;

        }
    }
}
