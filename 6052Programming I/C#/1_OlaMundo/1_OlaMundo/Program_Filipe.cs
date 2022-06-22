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

            string aux;
            int aux2, aux_saida2;
            char ConsoleKey = '0';
            DateTime utcDate = DateTime.UtcNow;

            //enquanto eu não inserir o caracter 's' não continua a perguntar a hora
            aux_saida2 = DateTime.Now.Hour;
            Console.WriteLine("Para sair prima a tecla 's'\n");
            while(ConsoleKey != 's')
            {
                //imprimir a hora actual
                Console.WriteLine(utcDate);


                //enviar mensagem para o ecra a pedir valor
                Console.WriteLine("Inserir a hora, numero inteiro");



                // vamos ler qual a hora(numero inteiro)
                aux = Console.ReadLine();
                aux2 = Convert.ToInt16(aux);

                //Console.WriteLine(aux);
                //Console.WriteLine(aux2);

                //se for entre as 9 e as 13 vou fazer a instrução que está em baixo
                if (aux2 >= 9 && aux2 < 13)
                {
                    Console.WriteLine("Bom dia!");
                }


                else if (aux2 > 14 && aux2 <= 18)
                {
                    Console.WriteLine("Boa tarde!");
                }

                else if (aux2 >= 13 && aux2 <= 14)
                {
                    Console.WriteLine("Hora de almoço!");
                }

            }
 

            Console.ReadKey();
        }

              
            
    }
}
