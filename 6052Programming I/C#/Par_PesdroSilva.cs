using System;

namespace Par
{
    class Program
    {
        static void Main(string[] args)
        {

            // Opção 1: Verifica se o valor introduzido é um número inteiro e devolve se este é par ou ímpar. No caso de
            // não ser introduzido um número inteiro, volta a pedir ao utilizador que introduza um novo valor.

            var valor = "";

            // Enquanto o valor introduzido não for um número inteiro
            while (!int.TryParse(valor, out _)){

                // Pedir o número a verificar
                Console.WriteLine("Qual o número que deseja saber se é par ou ímpar? ");

                // Ler da consola o valor introduzido
                valor = Console.ReadLine();

                // Opção para o utilizador sair
                if (valor == ":q") break;

                // Se o valor introduzido for um número inteiro
                if (int.TryParse(valor, out int aux)){

                    // Se o resto da divisão do número por 2 for igual a 0, o número é par. Caso contrário, o número é impar
                    String result = (aux % 2 == 0) ? "O seu número é par!" : "O seu número é ímpar!";

                    // Escrever o resultado na consola
                    Console.WriteLine(result);
                }

                // Caso contrário, informa o utilizador que deve introduzir um número inteiro
                else{
                    Console.WriteLine("Deve introduzir um número inteiro!\n");
                }
            }

            // Opção 2: Verifica se o valor introduzido é um número inteiro e devolve se é par ou ímpar. No caso de não ser
            // introduzido um número inteiro, devolve uma mensagem de erro e sai do programa.

            //int numero;
            //// Pedir o número a verificar
            //Console.WriteLine("Qual o número que deseja saber se é par ou ímpar? ");

            //try
            //{

            //    // Tentar guardar o input na variável
            //    numero = Convert.ToInt32(Console.ReadLine());

            //    // Se o resto da divisão do número por 2 for igual a 0, o número é par. Caso contrário, o número é impar
            //    String result = (numero % 2 == 0) ? "O seu número é par!" : "O seu número é ímpar!";

            //    // Escrever o resultado na consola
            //    Console.WriteLine(result);

            //}
            //catch (Exception e)
            //{
            //    // No caso do input não ser um número inteiro, informar o utilizador que deve colocar um número inteiro
            //    Console.WriteLine("Deve introduzir um número inteiro!");
            //}
        }
    }
}
