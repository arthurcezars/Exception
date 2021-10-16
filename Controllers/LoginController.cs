using System;
using System.Threading;
using UCLFlix.Classes;
using UCLFlix.Repositories;
using UCLFlix.Utils;

namespace UCLFlix.Controllers
{
    public class LoginController
    {
        public static Usuario Entrar()
        {
            while (true)
            {
                Console.Clear();

                Console.Write("Informe o seu usuario: ");
                string username = Console.ReadLine();
                Console.Write("Informe a sua senha: ");
                string password = Console.ReadLine();

                Usuario findUser = UsuarioRepository.findUsuarioByUsername(username, password);

                if (findUser == null)
                {
                    Logger.Warn("Usario ou Senha invalidos!");
                    Logger.Warn("Tente novamente.");
                    Thread.Sleep(1500);
                }
                else
                {
                    Logger.Info("Usario logado com sucesso!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    return findUser;
                }
            }
        }
    }
}