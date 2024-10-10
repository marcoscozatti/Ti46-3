using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosLogicaProgramacao
{
    internal class Lista1
    {
        internal void Exe1()
        {
            //1) Escreva um programa que mostre na tela a mensagem "Olá, Mundo!"
            Console.WriteLine("Exercício 1");
            Console.WriteLine("---------------");
            Console.WriteLine("Ola mundo!");
            Console.WriteLine("---------------");

            Console.WriteLine("Fim do exercício 1");
            Console.WriteLine("-------------------------------------------------------------");
        }

        internal void Exe2()
        {
            /*2) Faça um programa que leia o nome de uma pessoa e mostre uma mensagem 
             * de boasvindas para ela:
                 Ex:
                 Qual é o seu nome? João da Silva
                 Olá João da Silva, é um prazer te conhecer!
            */
            Console.WriteLine("Exercício 2");

            Console.WriteLine("---------------");
            Console.WriteLine("Entre com o nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Olá " + nome + ", é um prazer te conhecer!");
            Console.WriteLine("---------------");


            Console.WriteLine("Fim do exercício 2");
            Console.WriteLine("-------------------------------------------------------------");
        }

        internal void Exe3()
        {
            /*
             * 3) Crie um programa que leia o nome e o salário de um funcionário, mostrando no
                final uma mensagem.
                Ex:
                Nome do Funcionário: Maria do Carmo
                Salário: 1850,45
                O funcionário Maria do Carmo tem um salário de R$1850,45 em Junho.
             * 
             */
            Console.WriteLine("Exercício 3");

            Console.WriteLine("---------------");
            Console.WriteLine("Nome do Funcionário e saário: ");
            string nome = Console.ReadLine();
            decimal sal = decimal.Parse(Console.ReadLine());
            Console.WriteLine("O funcionário(a) " + nome + " tem o salário de " + sal + " em Novembro");
            Console.WriteLine("---------------");


            Console.WriteLine("Fim do exercício 3");
            Console.WriteLine("-------------------------------------------------------------");
        }
    }
}
