using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosLogicaProgramacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Verifica;
            do
            {
                menuListas();
                Console.WriteLine("Deseja continuar executando as listas de exercícios (S/N): \n");
                Verifica = Console.ReadLine().ToUpper();

            } while (Verifica == "S");



        }

        private static void menuListas()
        {
            Console.Clear();
            int op = 0;
            Console.WriteLine("*** Menu Principal ***");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("1 - Primeira lista de atividades ");
            Console.WriteLine("2 - Segunda lista de atividades");
            Console.WriteLine("3 - Terceira lista de atividades");
            Console.WriteLine("0 - Para finalizar");

            Console.WriteLine("Numero da lista: ");
            op = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------------------");

            switch (op)
            {
                case 0:
                   // Use o comando abaixo para interromper o programa
                    Environment.Exit(0);
                    break;
                case 1:   //Menu da primeira Lista de atividades
                    Lista1 lista1 = new Lista1();
                    Console.Clear();
                    int opLista1 = 0;
                    Console.WriteLine("*** Menu Principal - Lista 1***");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("1 - Primeira atividade ");
                    Console.WriteLine("2 - Segunda atividade");
                    Console.WriteLine("3 - Terceira  atividade");
                    Console.WriteLine("Digite o numero da atividade: ");
                    opLista1 = int.Parse(Console.ReadLine());

                    switch (opLista1)
                    {
                        
                        case 1:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe1();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe2();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe3();
                            break;
                        default:
                            Console.WriteLine("Tente outro item da lista");
                            break;

                    }
                    break;
                case 2:

                    Lista2 lista2 = new Lista2();
                    Console.Clear();
                    int opLista2 = 0;
                    Console.WriteLine("*** Menu Principal - Lista 2 ***");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("1 - Primeira atividade ");
                    Console.WriteLine("2 - Segunda atividade");
                    Console.WriteLine("3 - Terceira  atividade");
                    Console.WriteLine("Digite o numero da atividade: ");
                    opLista2 = int.Parse(Console.ReadLine());

                    switch (opLista2)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.Exe1();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.Exe2();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.Exe3();
                            break;
                        default:
                            Console.WriteLine("Tente outro item da lista");
                            break;

                    }


                    break;
                case 3:




                    break;







                default:
                    Console.WriteLine("Tente novamente!!!!");
                    break;
                

            }
        }
    }
}


