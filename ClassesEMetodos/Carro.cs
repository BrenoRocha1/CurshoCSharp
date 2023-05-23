using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Carro {
        public string Modelo;
        public int KMs;

        public string Apresentar() {
            return string.Format($"O modelo {Modelo} e tem {KMs} ");
        }

        public void ApresentarNoConsole() {
            //aqui vou mostrar no console o metodo q eu criei q é o Apresentar
            Console.WriteLine(Apresentar());
        }
    }
}
