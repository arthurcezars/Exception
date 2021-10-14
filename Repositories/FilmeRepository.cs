using UCLFlix.Classes;
using UCLFlix.Database;
using System.Collections.Generic;

namespace UCLFlix.Repositories
{
    public class FilmeRepository
    {
        private string database = "filme";

        public List<Filme> findAll(){
            List<Filme> usuarios = DatabaseController.GetDatabase<Filme>(database);
            return usuarios.Count != 0 ? usuarios : null;
        }

        public bool addNewFilme(Filme filme){
            try
            {
                List<Filme> usuarios = DatabaseController.GetDatabase<Filme>(database);
                usuarios.Add(filme);
                DatabaseController.SaveDatabase<Filme>(usuarios, database);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

    }
}