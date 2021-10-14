using UCLFlix.Database;
using UCLFlix.Classes;
using System.Linq;
using System.Collections.Generic;

namespace UCLFlix.Repositories
{
    public class UsuarioRepository
    {
        
        private string database = "usuario";

        public List<Usuario> findAll(){
            List<Usuario> usuarios = DatabaseController.GetDatabase<Usuario>(database);
            return usuarios.Count != 0 ? usuarios : null; 
        }

        public Usuario findUsuarioByUsername(string username){
            List<Usuario> usuarios = DatabaseController.GetDatabase<Usuario>(database);
            List<Usuario> retorno = (from user in usuarios where user.Username == username select user).ToList();
            return retorno.Count != 0 ? retorno[0] : null; 
        }

        public bool addNewUser(Usuario usuario){
            try
            {
                List<Usuario> usuarios = DatabaseController.GetDatabase<Usuario>(database);
                usuarios.Add(usuario);
                DatabaseController.SaveDatabase<Usuario>(usuarios, database);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

    }
}