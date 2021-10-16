using UCLFlix.Database;
using UCLFlix.Classes;
using System.Linq;
using System.Collections.Generic;
using System;

namespace UCLFlix.Repositories
{
    public class UsuarioRepository
    {
        
        private static string database = "usuario";

        public static List<Usuario> findAll(){
            List<Usuario> usuarios = DatabaseController.GetDatabase<Usuario>(database);
            return usuarios.Count != 0 ? usuarios : null; 
        }

        public static Usuario findUsuarioByUsername(string username){
            List<Usuario> usuarios = DatabaseController.GetDatabase<Usuario>(database);
            List<Usuario> retorno = (from user in usuarios where user.Username.Equals(username) select user).ToList();
            return retorno.Count != 0 ? retorno[0] : null; 
        }

        public static Usuario findUsuarioByUsername(string username, string password){
            List<Usuario> usuarios = DatabaseController.GetDatabase<Usuario>(database);
            List<Usuario> retorno = (from user in usuarios where user.Username.Equals(username) && user.Password.Equals(password) select user).ToList();
            return retorno.Count != 0 ? retorno[0] : null; 
        }

        public static bool addNewUser(Usuario usuario){
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

        public static void SaveAllUsuarios(List<Usuario> usuarios){
            DatabaseController.SaveDatabase<Usuario>(usuarios, database);
        }

    }
}