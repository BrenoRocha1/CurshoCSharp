using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Carros {
        public static void Executar() {

            Carro carro1 = new Carro();

            carro1.Modelo = "marea bi-turbo 2.4";
            carro1.KMs = 23;

            //carro 2

            Carro carro2 = new Carro();

            carro2.Modelo = "Corsa 2006";
            carro2.KMs = 123;
        }
    }
}
