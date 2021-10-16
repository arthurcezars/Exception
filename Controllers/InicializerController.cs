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
            if(programas == null){
                Logger.Debug("Seed Database Programas...");
                Thread.Sleep(1500);
                ProgramasRepository.SaveAllProgramas( seedProgramas() );
            }
        }

        public static void InicializarDadosBancoUsuarios(){
            List<Usuario> usuarios = UsuarioRepository.findAll();
            if(usuarios == null){
                Logger.Debug("Seed Database Usuarios...");
                Thread.Sleep(1500);
                UsuarioRepository.SaveAllUsuarios( seedUsuarios() );
            }
        }

        public static List<Usuario> seedUsuarios(){
            List<Usuario> usuarios = new List<Usuario>();

            List<Programa> lm = new List<Programa>() { 
                new Filme(nome:"O Poderoso Chefão", genero:Genero.Drama, ano:1972, nota:4.5 ),  
                new Filme(nome:"John Wick - De Volta Ao Jogo", genero:Genero.Acao, ano:2014, nota:5.0), 
                new Serie(nome:"Alice in Borderland", genero:Genero.FiccaoCientifica, temporadas:1, ano:2020, nota:3.5) 
            };
            usuarios.Add( new Usuario("Matheus", "matheus", "123", Genero.Acao, lm) );

            List<Programa> la = new List<Programa>() { 
                new Filme(nome:"O Poderoso Chefão", genero:Genero.Drama, ano:1972, nota:4.5 ),  
                new Filme(nome:"Pulp Fiction - Tempo De Violência", genero:Genero.Acao, ano:1994, nota:2.0), 
                new Filme(nome:"John Wick - De Volta Ao Jogo", genero:Genero.Acao, ano:2014, nota:5.0) 
            };
            usuarios.Add( new Usuario("Arthur", "arthur", "123", Genero.Comedia, la) );

            List<Programa> lb = new List<Programa>() { 
                new Filme(nome:"O Poderoso Chefão", genero:Genero.Drama, ano:1972, nota:1.5 ),  
                new Filme(nome:"Pulp Fiction - Tempo De Violência", genero:Genero.Acao, ano:1994, nota:3.0), 
                new Serie(nome:"Impuros", genero:Genero.Acao, temporadas:2, ano:2018, nota:2.5) 
            };
            usuarios.Add( new Usuario("Breno", "breno", "123", Genero.Documentario, lb) );

            List<Programa> laq = new List<Programa>() { 
                new Filme(nome:"O Poderoso Chefão", genero:Genero.Drama, ano:1972, nota:2.0 ),  
                new Filme(nome:"Pulp Fiction - Tempo De Violência", genero:Genero.Acao, ano:1994, nota:5.0), 
                new Serie(nome:"Alice in Borderland", genero:Genero.FiccaoCientifica, temporadas:1, ano:2020, nota:0.5) 
            };
            usuarios.Add( new Usuario("Aquiles", "aquiles", "123", Genero.Terror, laq) );

            List<Programa> mtg = new List<Programa>() { 
                new Filme(nome:"O Poderoso Chefão", genero:Genero.Drama, ano:1972, nota:3.0 ),  
                new Filme(nome:"Pulp Fiction - Tempo De Violência", genero:Genero.Acao, ano:1994, nota:3.0), 
                new Serie(nome:"Alice in Borderland", genero:Genero.FiccaoCientifica, temporadas:1, ano:2020, nota:5.0) 
            };
            usuarios.Add( new Usuario("Mustang", "mustang", "123", Genero.Documentario, mtg) );

            return usuarios;
        }

        public static List<Programa> seedProgramas(){

            List<Programa> lista = new List<Programa>();
            
            lista.AddProgramas(
                new Filme(nome:"O Poderoso Chefão", genero:Genero.Drama, ano:1972),
                new Filme(nome:"Parasita", genero:Genero.Suspence, ano:2019),
                new Filme(nome:"Cidade de Deus", genero:Genero.Acao, ano:2002),
                new Filme(nome:"Bastardos Inglórios", genero:Genero.Acao, ano:2009),
                new Filme(nome:"O Auto Da Compadecida", genero:Genero.Comedia, ano:2000),
                new Filme(nome:"Pulp Fiction - Tempo De Violência", genero:Genero.Acao, ano:1994),
                new Filme(nome:"Batman: O Cavaleiro das Trevas", genero:Genero.Acao, ano:2008),
                new Filme(nome:"O Hobbit - Uma Jornada Inesperada", genero:Genero.Aventura, ano:2012),
                new Filme(nome:"John Wick - De Volta Ao Jogo", genero:Genero.Acao, ano:2014),
                new Filme(nome:"Gladiador", genero:Genero.Drama, ano:2000),
                new Filme(nome:"King Kong", genero:Genero.Acao, ano:2005),
                new Filme(nome:"Prenda-Me Se For Capaz", genero:Genero.Drama, ano:2002),
                new Filme(nome:"Os Miseráveis", genero:Genero.Musical, ano:2012),
                new Filme(nome:"Footloose - Ritmo Louco", genero:Genero.Musical, ano:1984),
                new Filme(nome:"Os Pássaros", genero:Genero.Terror, ano:1963),
                new Filme(nome:"Apertem Os Cintos... O Piloto Sumiu", genero:Genero.Comedia, ano:1980),
                new Filme(nome:"Curtindo A Vida Adoidado", genero:Genero.Comedia, ano:1986)
            );

            lista.AddProgramas(
                new Serie(nome:"Round 6", genero:Genero.Drama, temporadas:1, ano:2021),
                new Serie(nome:"Sex Education", genero:Genero.Drama, temporadas:3, ano:2019),
                new Serie(nome:"The Witcher", genero:Genero.Fantasia, temporadas:1, ano:2019),
                new Serie(nome:"The Purge", genero:Genero.Acao, temporadas:2, ano:2018),
                new Serie(nome:"Brooklyn Nine-Nine", genero:Genero.Comedia, temporadas:8, ano:2013),
                new Serie(nome:"Alice in Borderland", genero:Genero.FiccaoCientifica, temporadas:1, ano:2020),
                new Serie(nome:"Dark", genero:Genero.FiccaoCientifica, temporadas:3, ano:2017),
                new Serie(nome:"Impuros", genero:Genero.Acao, temporadas:2, ano:2018),
                new Serie(nome:"Peaky Blinders", genero:Genero.Drama, temporadas:5, ano:2013),
                new Serie(nome:"Grey's Anatomy / A Anatomia de Grey", genero:Genero.Drama, temporadas:18, ano:2005),
                new Serie(nome:"The Good Doctor: O Bom Doutor", genero:Genero.Drama, temporadas:4, ano:2017),
                new Serie(nome:"The 100", genero:Genero.FiccaoCientifica, temporadas:7, ano:2014),
                new Serie(nome:"Vincezo", genero:Genero.Romance, temporadas:1, ano:2021),
                new Serie(nome:"O Mundo Sombrio de Sabrina", genero:Genero.Drama, temporadas:4, ano:2018),
                new Serie(nome:"Lúcifer", genero:Genero.Fantasia, temporadas:6, ano:2016),
                new Serie(nome:"Suits / Homens de Terno", genero:Genero.Drama, temporadas:9, ano:2011)
            );

            return lista;
        }
    }
}