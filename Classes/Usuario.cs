using System;
using UCLFlix.Enums;

namespace UCLFlix.Classes
{
    [Serializable]
    public class Usuario
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Genero Genero { get; set; } 

        public Usuario(string nome, string usuario, string senha, Genero genero){
            Name = nome;
            Username = usuario;
            Password = senha;
            Genero = genero;
        }

        public Usuario(){
            
        }


    }
}