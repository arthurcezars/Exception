using System;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using UCLFlix.Database;
using UCLFlix.Controllers;
using UCLFlix.Classes;
using UCLFlix.Enums;
using UCLFlix.Repositories;
using UCLFlix.Views;
using UCLFlix.Utils;


namespace UCLFlix
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            while(true){
                bool sair = false;
                
                int opx = Inicial.EscolhaEntrada();
                
                switch (opx){
                    
                    case 1:
                        Logger.Info("Em Construção");
                        Thread.Sleep(1500);
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
