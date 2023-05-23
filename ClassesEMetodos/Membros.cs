using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {

            Pessoa pessoa1 = new Pessoa();

                pessoa1.nome = "Cleiton Peres";
            pessoa1.Idade = 23;

            //pessoa 2

            Pessoa pessoa2 = new Pessoa();

            pessoa2.nome = "Rodolfo";
            pessoa2.Idade = 43;

           // Console.WriteLine($"{pessoa1}{pessoa1.Idade}{pessoa1.nome}");
           // Console.WriteLine($"{pessoa2}{pessoa2.Idade}{pessoa2.nome}");
        }
    }
}