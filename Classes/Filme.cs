using System;
using System.Collections.Generic;
using UCLFlix.Enums;

namespace UCLFlix.Classes
{
    [Serializable]
    public class Filme : Programa
    {   
        public Filme(string nome, Genero genero, int ano) 
            : base(nome, genero, ano)
        {   
        }

        public Filme(string nome, Genero genero, int ano, double nota) 
            : base(nome, genero, ano, nota)
        {   
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + Genero + Environment.NewLine;
            retorno += "Nome: " + Nome + Environment.NewLine;
            retorno += "Ano: " + Ano + Environment.NewLine;
            retorno += "Nota: " + Nota;
            return retorno;
        }
    }
}