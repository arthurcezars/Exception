using UCLFlix.Enums;

namespace UCLFlix.Classes.Usuario
{
    public class Usuario
    {
        public string Nome { get; private set; }
        public Genero GeneroFavorito { get; private set; }

        public Usuario(string nome, Genero genero)
        {
            Nome = nome;
            GeneroFavorito = genero;
        }
    }
}