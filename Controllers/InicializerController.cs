using System.Collections.Generic;
using UCLFlix.Classes;
using UCLFlix.Repositories;
using UCLFlix.Utils;
using UCLFlix.Enums;
using System.Threading;

namespace UCLFlix.Controllers
{
    public class InicializerController
    {

        public static void InicializarDadosBancoProgramas(){
            List<Programa> programas = ProgramasRepository.findAll();
            if(programas.Count == 0){
                Logger.Debug("Seed Database...");
                Thread.Sleep(1500);
                startSeed();
                ProgramasRepository.SaveAllProgramas(Programa.repositorioProgramas);
            }
        }

        public static void startSeed(){
            Programa.repositorioProgramas.AddProgramas(
                new Filme(nome:"O Poderoso Chefão", genero:Genero.Drama, ano:1972),
                new Filme(nome:"Parasita", genero:Genero.Suspence, ano:2019),
                new Filme(nome:"Cidade de Deus", genero:Genero.Acao, ano:2002),
                new Filme(nome:"Bastardos Inglórios", genero:Genero.Acao, ano:2009),
                new Filme(nome:"O Auto Da Compadecida", genero:Genero.Comedia, ano:2000)
            );

            Programa.repositorioProgramas.AddProgramas(
                new Serie(nome:"Round 6", genero:Genero.Drama, temporadas:1, ano:2021),
                new Serie(nome:"Sex Education", genero:Genero.Drama, temporadas:3, ano:2019),
                new Serie(nome:"The Witcher", genero:Genero.Fantasia, temporadas:1, ano:2019),
                new Serie(nome:"The Purge", genero:Genero.Acao, temporadas:2, ano:2018),
                new Serie(nome:"Brooklyn Nine-Nine", genero:Genero.Comedia, temporadas:8, ano:2013)
            );
        }
    }
}