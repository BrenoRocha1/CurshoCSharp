using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class Cliente {
        public string Nome;
        public string Cpf;
        public string Sexo;
        public string Endereco;
        public int Idade;

        public Cliente(string nome, string cpf, string sexo, string endereco, int idade) {
            Nome = nome;
            Cpf = cpf;
            Sexo = sexo;
            Endereco = endereco;
        }
    }


    class Contrutores {



        public static void Executar() {

            var cliente1 = new Cliente(); //new cliente é um construtor
            cliente1.Nome = "Cleber";
            cliente1.Cpf = "322.124.043.32";
            cliente1.Sexo = "M";
            cliente1.Endereco = "Vila blablabla";
            cliente1.Idade = 92;


        }
    }
}
