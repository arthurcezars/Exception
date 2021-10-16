using UCLFlix.Database;
using UCLFlix.Repositories;
using System.Linq;
using UCLFlix.Classes;
using System.Collections.Generic;
using UCLFlix.Utils;
using System;

namespace UCLFlix.Controllers
{
    public class LogicaRecomendacaoController
    {
        public static int getIndex(List<Programa> lista, String nomeFilme)
        {
            int c = 0;
            foreach (var item in lista)
            {
                if(item.Nome.Equals(nomeFilme)) return c;
                c++;
            }
            return -1;
        }
        
        public static List<DistEucl> DistanciaEuclidiana(Usuario usuarioLogado)
        {
            List<Usuario> usuarios = UsuarioRepository.findAll();
            
            List<Programa> listasPrimeiros = usuarioLogado.ListaAvaliados.OrderByDescending(filme => filme.Nota).Take(2).ToList(); 
            System.Console.WriteLine($"Filmes Pegos: {listasPrimeiros[0].Nome} | {listasPrimeiros[1].Nome}");
            
            List<DistEucl> listaDistancias = new List<DistEucl>(); 

            foreach (var user in usuarios)
            {
                if(usuarioLogado.Username.Equals(user.Username)) continue;
                Console.WriteLine($"Comparando {usuarioLogado.Name} com {user.Name}");
                
                List<int> pos = new List<int> { getIndex(user.ListaAvaliados, listasPrimeiros[0].Nome) , getIndex(user.ListaAvaliados, listasPrimeiros[1].Nome) };
                System.Console.WriteLine(pos[0] != -1 && pos[1] != -1);

                if (pos[0] != -1 && pos[1] != -1)
                {
                    List<Programa> posUser = new List<Programa> { user.ListaAvaliados[pos[0]], user.ListaAvaliados[pos[1]] };
                    System.Console.WriteLine($"{user.Name} -- {posUser[0].Nome} | {posUser[1].Nome}");
                    Double eucl = FormDistanciaEuclidiana(listasPrimeiros[0].Nota, listasPrimeiros[1].Nota, posUser[0].Nota, posUser[1].Nota);
                    listaDistancias.Add( new DistEucl(user, eucl) );
                }
            }

            return listaDistancias.OrderBy(u => u.Distance).ToList();
            
        }

        private static double FormDistanciaEuclidiana(double Avl1User1, double Avl2User1, double Avl1User2, double Avl2User2)
        {
            return Math.Sqrt((Math.Pow(Avl1User1 - Avl2User1, 2) + Math.Pow(Avl1User2 - Avl2User2, 2)));
        }
    }
}