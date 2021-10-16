﻿using UCLFlix.Controllers;
using UCLFlix.Repositories;
using UCLFlix.Classes;
using System.Collections.Generic;
using UCLFlix.Utils;

namespace UCLFlix
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            InicializerController.InicializarDadosBancoProgramas();
            InicializerController.InicializarDadosBancoUsuarios();

            List<Usuario> usuarios = UsuarioRepository.findAll();

            Usuario matue = usuarios[0];

            List<DistEucl> eucl = LogicaRecomendacaoController.DistanciaEuclidiana(matue);

            Table.PrintRow(eucl.Count.ToString());

            if(eucl.Count != 0){
                Table.PrintRow(eucl[0].User.Name);
            }
            

            // while(true){
            //     bool sair = false;
                
            //     int opx = Inicial.EscolhaEntrada();
                
            //     switch (opx){
                    
            //         case 1:
                        
            //         break;

            //         case 2:
            //             CadastroController.Cadastrar();
            //         break;

            //         case 0:
            //             Inicial.Sair();
            //             sair = true;
            //         break;
            //     }
                
            //     if(sair) break;
            // }

        }
    }
}