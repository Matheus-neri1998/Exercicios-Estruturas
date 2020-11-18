using System;

namespace Exercicios_Estruturas
{
    class Program
    {
        static void Main(string[] args)
        {

            int nota;


           do {
               Console.Write("Digite uma nota entre 0 e 10: ");
               nota = int.Parse(Console.ReadLine());

               if(nota <0 || nota > 10) {
                   Console.WriteLine("Número inválido");
               }

           }while(nota < 0 || nota > 10);

           Console.WriteLine("Número aceito");
               
           }            
             
        }
    }
