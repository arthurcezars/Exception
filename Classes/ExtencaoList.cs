using System.Collections.Generic;

namespace UCLFlix.Classes
{
    public static class ExtencaoList
    {
        public static void AdicionarProgramas<T>(this List<T> repositorio, params T[] programas)
        {
            foreach (var programa in programas)
            {
                repositorio.Add(programa);
            }
        }
    }
}