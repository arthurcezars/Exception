using System;
using UCLFlix.Enums;

namespace UCLFlix.Classes
{
    [Serializable]
    public class Filme : Programa
    {
        public Filme(string nome, string descricao, Genero genero) 
            : base(nome, descricao, genero, DateTime.Today.Year)
        {
        }

        public Filme(string nome, string descricao, Genero genero, int ano) 
            : base(nome, descricao, genero, ano)
        {
            
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + Genero + Environment.NewLine;
            retorno += "Nome: " + Nome + Environment.NewLine;
            retorno += "Descrição: " + Descricao + Environment.NewLine;
            retorno += "Ano: " + Ano + Environment.NewLine;
            retorno += "Likes: " + Like + "Dislikes: " + Deslike;
            return retorno;
        }
    }
}