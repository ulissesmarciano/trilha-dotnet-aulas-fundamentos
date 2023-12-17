using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models //Aqui eu utilizo o nome, que pode ser modificado, para exportar a clase para um programa.
{
    //IMPLEMENTANDO A CLASSE
    public class Pessoa //Toda classe é considerada uma abstração de um objeto real para o mundo virtual.
    {
        //Adicionando as propriedades da clase. Lembrando que tudo o que for declarado é sempre em um contexto útil.
        public string Nome { get; set; }
        public int Idade { get; set; }

        //Implementação de um método. 
        public void Apresentar() 
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}