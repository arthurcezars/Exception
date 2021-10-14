using System.Collections.Generic;
using UCLFlix.Classes;
using UCLFlix.Repositories;

namespace UCLFlix.Controllers
{
    public class InicializerController
    {
        public static FilmeRepository filmeDB = new FilmeRepository();

        public static void verificaDadosBanco(){

        }

        public static void startSeed(){
            List<Filme> filmes = new List<Filme>();


        }
    }
}