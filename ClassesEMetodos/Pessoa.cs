using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Pessoa {

        /* Estamos colocando o tipo public porque
         quero q esse atributo(nome, idade) fique visivel para a minha classe
        
        Ctrl-shift-: = comenta o codigo todo
         
         */
        public string nome;
        public int Idade;

        public string Apresentar() {
            return string.Format($"Olá, Me chamo {nome} e tenho {Idade} ");
        }

        public void ApresentarNoConsole() {
            //aqui vou mostrar no console o metodo q eu criei q é o Apresentar
            Console.WriteLine(Apresentar());
        }
        
    }
}
