using System.Collections.Generic;
using UCLFlix.Database;
using UCLFlix.Classes;

namespace UCLFlix.Repositories
{
    public static class ProgramasRepository
    {
        private static string database = "programas";

        public static List<Programa> findAll(){
            return DatabaseController.GetDatabase<Programa>(database);
        }

        public static void SaveAllProgramas(List<Programa> programas){
            DatabaseController.SaveDatabase<Programa>(programas, database);
        }

        public static void AddProgramas<T>(this List<T> repositorio, params T[] programas)
        {
            foreach (var programa in programas)
            {
                repositorio.Add(programa);
            }
        }
    }
}