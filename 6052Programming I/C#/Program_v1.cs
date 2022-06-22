using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_NumeroPar
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            int aux2;
            string aux3;
            char aux4='0';

            do
            {
                //Pedir para inserir um numero
                //enviar mensagem para o visor a solicitar para inserir um numero
                Console.WriteLine("Insira um numero inteiro positivo qualquer:\n");

                //Ler o numero
                //lê a string de entrada
                aux = Console.ReadLine();
                aux2 = Convert.ToInt16(aux);

                //Verificar se o numero é valido
                //Verificar se é um numero par
                //if (aux2 >= 0 && aux2 % 2 == 0)
                if (aux2 % 2 == 0)
                {
                    //Caso seja, sair com uma mensagem de sucesso
                    Console.WriteLine("Boa! Conseguiste acertar! Queres tentar novamente? Sim (y) ou não (n)\n");
                    aux3 = Console.ReadLine();
                    aux4 = Convert.ToChar(aux3);
                }
                else
                {
                    //Caso não seja, fica dentro de um ciclo do while e pergunta se quer inserir outro numero (y/n)
                    Console.WriteLine("Caramba!? Queres tentar novamente? Sim (y) ou não (n)?\n");
                    aux3 = Console.ReadLine();
                    aux4 = Convert.ToChar(aux3);
                }
            }
            //Caso y- pede novamente para inserir um numero
            while (aux4 == 'y');

            //Caso n - sai do programa
            while (Console.ReadKey().Key != ConsoleKey.N)
            {
            }
        }
    }
}


/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!\n");

            string aux;
            int aux2;

            do
            {
                //enviar mensagem para o visor a solicitar valor da hora actual
                Console.WriteLine("Insira a hora actual em valor inteiro:\n");


                //ler qual a hora em string
                aux = Console.ReadLine();
                aux2 = Convert.ToInt16(aux);

                //Console.WriteLine(aux);
                //Console.WriteLine(aux2);


                //se for entre as 9 e as 13, fazer a instrução abaixo
                if (aux2 >= 9 && aux2 < 13)
                {
                    Console.WriteLine("Bom dia!\n");
                }
                //se for entre as 13 e as 18, fazer a instrução abaixo
                else if (aux2 >= 13 && aux2 < 18)
                {
                    Console.WriteLine("Boa tarde!\n");
                }
                //se não for qualquer uma das situações anteriores
                else
                {
                    Console.WriteLine("Boa noite!\n");
                }

                if (aux2 != DateTime.Now.Hour)
                {
                    Console.WriteLine("Estás a dormir, pá!\n");
                }

            } while (aux2 != DateTime.Now.Hour);

            Console.WriteLine("Finalmente acertaste na hora pá! Clica no S\n");

            while (Console.ReadKey().Key != ConsoleKey.S)
            {
            }
        }
    }
}*/
