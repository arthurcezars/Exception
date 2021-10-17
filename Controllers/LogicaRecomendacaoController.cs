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
            // Busca todos os usuarios do sistema para analise de similaridade.
            List<Usuario> usuarios = UsuarioRepository.findAll();
            
            // Retorna os 2 programas com melhor avaliação do usuario logado.
            List<Programa> listasPrimeiros = usuarioLogado.ListaAvaliados.OrderByDescending(filme => filme.Nota).Take(2).ToList(); 
            
            // Cria uma lista das Distancias, para adicionar todos os usuarios que tem similaridade com o usuario logado.
            List<DistEucl> listaDistancias = new List<DistEucl>(); 

            foreach (var user in usuarios)
            {
                // Nao verificar o proprio usuario logado.
                if(usuarioLogado.Username.Equals(user.Username)) continue;

                // Verifica se o usuario que sera comparado avaliou os mesmo filmes 2 melhores filmes do usuario logado.
                List<int> pos = new List<int> { getIndex(user.ListaAvaliados, listasPrimeiros[0].Nome) , getIndex(user.ListaAvaliados, listasPrimeiros[1].Nome) };
                if (pos[0] != -1 && pos[1] != -1)
                {
                    // Assim pegando os programas e suas avaliações para colocar na formula da disntancia Euclidiana
                    List<Programa> posUser = new List<Programa> { user.ListaAvaliados[pos[0]], user.ListaAvaliados[pos[1]] };
                    Double eucl = FormDistanciaEuclidiana(listasPrimeiros[0].Nota, listasPrimeiros[1].Nota, posUser[0].Nota, posUser[1].Nota);
                    
                    // E adicionando o usuario, e o valor da formula.
                    listaDistancias.Add( new DistEucl(user, eucl) );
                }
            }
            
            // Aqui retornamos as menores distancias, que seria as melhores similaridade com aquele usuario logado.
            return listaDistancias.OrderBy(u => u.Distance).ToList();
            
        }

        private static double FormDistanciaEuclidiana(double Avl1User1, double Avl2User1, double Avl1User2, double Avl2User2)
        {
            return Math.Sqrt((Math.Pow(Avl1User1 - Avl2User1, 2) + Math.Pow(Avl1User2 - Avl2User2, 2)));
        }
    }
}