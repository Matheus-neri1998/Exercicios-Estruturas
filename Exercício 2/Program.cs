using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {


        // var = Variável
        // do = Faça
        // while = Enquanto
        // if = Se

            int usuario;    // Variável usuário

            int senha;     // Variável senha


            do{

            Console.WriteLine("Digite o nome de usuário? ");
            usuario = int.Parse(Console.ReadLine());
            // Console.WriteLine ("");
            Console.WriteLine("Digite a sua senha ");
            senha = int.Parse(Console.ReadLine());

            if(usuario != senha) {
                 Console.WriteLine("Senha válida");
            }
            }while(usuario == senha);
            Console.WriteLine("Senha inválida");
            Console.WriteLine("");
            Console.WriteLine("Digite sua senha novamente");
            senha = int.Parse(Console.ReadLine());
        }
    }
}
