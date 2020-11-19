using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {


        // var = Variável
        // string = resposta
        // do = Faça
        // while = Enquanto
        // if = Se

               
            //    string username;
            //    string password;


           

                Console.WriteLine("Digite o seu nome de usuário");
                string username = Console.ReadLine();

                Console.WriteLine("Digite sua senha");
                string password = Console.ReadLine();

                while(username == password) {

                    Console.WriteLine("Senha inválida. Tente novamente. ");
                    Console.WriteLine("Digite sua nova senha. Obs: Ela deve ser diferente do seu nome de usuário ");
                    username = Console.ReadLine();
                }

                    Console.WriteLine("Cadastro feito. ");

           
                
          
           
        }
    }
}
