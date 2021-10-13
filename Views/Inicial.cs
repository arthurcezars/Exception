using System;
using UCLFlix.Utils;

namespace UCLFlix.Views
{
    public class Inicial
    {
        public static void Entrar(){
            Console.WriteLine("###############################");
            Console.WriteLine("########## BEM VINDO ##########");
            Console.WriteLine("###############################");
            Console.WriteLine("1 - Entrar");
            Console.WriteLine("2 - Cadastrar");
            Console.WriteLine("3 - Recuperar Senha");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("###############################");
        }

        public static int EscolhaEntrada(){
            Entrar();
            int opx = int.Parse(Console.ReadLine());
            if(opx >= 0 && opx <=3){
                return opx;
            }else{
                Console.Clear();
                Logger.Warn("Opção invalida ...\n");
                return EscolhaEntrada();
            }
        }

        public static void Saindo(){
            Console.Clear();
            Console.WriteLine("###################################################");
            Console.WriteLine("########## OBRIGADO POR UTILIZAR UCLFlix ##########");
            Console.WriteLine("###################################################");
        }
    }
}