using System.Threading;
using UCLFlix.Controllers;
using UCLFlix.Views;
using UCLFlix.Utils;


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