using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveiseConstantes {
        public static void Executar() {

            double raio = 1.3;

            const double pi = 3.14;

            double area = pi * raio * raio;

            Console.WriteLine($"A área total é de: {area}");

            string nome = "Breno";
            int idade = 17;
            double altura = 1.90;
            bool temGato = true;
            var sobrenome = "perez";
        }
    }
    }