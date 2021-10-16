﻿using UCLFlix.Controllers;
using UCLFlix.Classes;
using System.Collections.Generic;
using UCLFlix.Views;
using System;

namespace UCLFlix
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            InicializerController.InicializarDadosBancoProgramas();
            InicializerController.InicializarDadosBancoUsuarios();

            while(true){
                bool sair = false;
                
                int opx = Inicial.EscolhaEntrada();
                
                switch (opx){
                    
                    case 1:
                        List<DistEucl> eucl = LogicaRecomendacaoController.DistanciaEuclidiana(LoginController.Entrar());

                        if (eucl.Count > 0)
                        {
                            App.ListarProgramasRecomendados(eucl[0]);
                        }
                        else
                        {
                            App.ListarProgramas();
                        }

                        Console.ReadKey();
                    break;

                    case 2:
                        CadastroController.Cadastrar();
                    break;

                    case 0:
                        Inicial.Sair();
                        sair = true;
                    break;
                }
                
                if(sair) break;
            }

        }
    }
}