using System;
using System.Collections.Generic;
using UCLFlix.Enums;

namespace UCLFlix.Classes
{
    public class Serie : Programa
    {
        public int Temporadas { get; protected set; }

        public Serie(string nome, Genero genero, int temporadas) 
            : base(nome, genero, DateTime.Today.Year)
        {
            Temporadas = temporadas;
        }

        public Serie(string nome, Genero genero, int temporadas, int ano) 
            : base(nome, genero, ano)
        {
            Temporadas = temporadas;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + Genero + Environment.NewLine;
            retorno += "Nome: " + Nome + Environment.NewLine;
            retorno += "Ano: " + Ano + Environment.NewLine;
            retorno += "Temporadas: " + Temporadas + Environment.NewLine;
            retorno += "Likes: " + Like + "Dislikes: " + Deslike;
            return retorno;
        }
    }
}