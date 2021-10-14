using System;
using System.Threading;
using UCLFlix.Classes;
using UCLFlix.Enums;
using UCLFlix.Repositories;
using UCLFlix.Utils;


namespace UCLFlix.Controllers
{   
    public class CadastroController
    {
        private static UsuarioRepository userDB = new UsuarioRepository();
        
        public static void Cadastrar(){
            Usuario usuario = new Usuario();
            while(true){
                Console.Clear();

                Console.Write("Informe o seu usuario: ");
                usuario.Username = Console.ReadLine();

                Usuario findUser = userDB.findUsuarioByUsername(usuario.Username);

                if(findUser == null){

                    Console.Clear();
                    Console.Write("Informe a sua senha: ");
                    usuario.Password = Console.ReadLine();

                    // Loop de Validação do Genero escolhido no cadastro.
                    while (true){
                        Console.Clear();
                        foreach (int i in Enum.GetValues(typeof(Genero))){
                            Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
                        }
                        Console.Write("Escolha o numero do genero: ");
                        int opx = int.Parse(Console.ReadLine());
                        if( opx >= 1 && opx <= 13 ){
                            usuario.Genero = (Genero) opx;
                            break;
                        }else{
                            Logger.Warn("Genero informado invalido.");
                            Thread.Sleep(1500);
                        }
                    }
                    
                    Console.Clear();
                    Console.Write("Informe o seu nome: ");
                    usuario.Name = Console.ReadLine();

                    userDB.addNewUser(usuario);

                    Logger.Info($"Usuario {usuario.Name} cadastrado com Sucesso!");
                    Thread.Sleep(1500);
                    break;
                }else{
                    Logger.Warn("Usuario ja cadastrado no sistema.");
                    Logger.Warn("Tente um novo usuario.");
                    Thread.Sleep(1500);
                }

            }
        }

    }
}