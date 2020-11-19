using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
           string name;
           int idade;
           double salario;
           char estadocivil;

           do
           {
               Console.WriteLine("Digite o seu nome");
               name = Console.ReadLine();
           } while (name == "" || name == " ");

           do
           {
               Console.WriteLine("Digite a sua idade");
               idade = int.Parse(Console.ReadLine());
           }while(idade <=0 || idade > 150);

           do
           {
               Console.WriteLine("Digite o seu salário");
               salario = double.Parse(Console.ReadLine());
           }while(!(salario > 0));

           do
           {
               Console.WriteLine("Qual o seu estado civil? 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));");
               string estado = Console.ReadLine(); //Recebe a string estado
               estadocivil = estado.ToCharArray()[0]; //Conversão
           }while(estadocivil != 's' && estadocivil != 'c' && estadocivil != 'v' && estadocivil != 'd');
        }
    }
}
