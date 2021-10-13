using System;
using UCLFlix.Views;
using UCLFlix.Database;
using System.Collections.Generic;

namespace UCLFlix
{
    [Serializable]
    class Usuario {
        public string nome;
        public int idade;

        public Usuario(string nome, int idade){
            this.nome = nome;
            this.idade = idade;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
