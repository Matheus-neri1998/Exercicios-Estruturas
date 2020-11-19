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

               // Variável usuário

               // Variável senha


           

            Console.WriteLine("Digite o nome de usuário ");
            string usuario = Console. ReadLine();
            Console.WriteLine ("Digite uma nova senha ");
            string senha = Console.ReadLine();
            while (usuario == senha) {

            Console.WriteLine("Senha inválida. Tente novamente! ");
            Console.WriteLine("Digite uma nova senha ");
            usuario = Console.ReadLine();
           
            }

            Console.WriteLine ("Cadastro bem sucedido! ");

           
                
          
           
        }
    }
}
