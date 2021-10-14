using System;
using System.Threading;

using UCLFlix.Utils;

namespace UCLFlix.Views
{
    public class Inicial
    {
        public static void Menu(){
            Console.Clear();
            Console.WriteLine("###############################");
            Console.WriteLine("########## BEM VINDO ##########");
            Console.WriteLine("###############################");
            Console.WriteLine("1 - Entrar");
            Console.WriteLine("2 - Cadastrar");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("###############################");
        }
        
        public static int EscolhaEntrada(){
            Menu();
            int opx = int.Parse(Console.ReadLine());
            if(opx >= 0 && opx <=2){
                return opx;
            }else{
                Console.Clear();
                Logger.Warn("Opção invalida ...\n");
                Thread.Sleep(1500);
                return EscolhaEntrada();
            }
        }

        public static void Entrar(){

        }

        public static void Sair(){
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("###################################################");
            Console.WriteLine("########## OBRIGADO POR UTILIZAR UCLFlix ##########");
            Console.WriteLine("###################################################");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}