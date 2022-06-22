using System;

namespace maxNum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Definição das variáveis a uilizar no programa
            int num1 = 0, num2 = 0;
            bool validaNum1, validaNum2, validaLocal, validaGlobal;

            do
            {
                // validação do primeiro número, se não for número o programa volta a pedir um número
                do
                {
                    Console.WriteLine("Insira o primeiro número para fazer a comparação!");
                    var aux = Console.ReadLine();
                    validaNum1 = Int32.TryParse(aux, out num1);

                    if (validaNum1 == false)
                    {
                        Console.WriteLine("O {0} não é um número", aux);
                    }
                } while (validaNum1 == false);



                // validação do segundo número, que tal como o primeiro se não for número o programa volta a pedir um número
                do
                {
                    Console.WriteLine("Insira o segundo número para fazer a comparação!");
                    var aux2 = Console.ReadLine();
                    validaNum2 = Int32.TryParse(aux2, out num2);

                    if (validaNum2 == false)
                    {
                        Console.WriteLine("O {0} não é um número", aux2);
                    }
                } while (validaNum2 == false);

               // Comparação dos dois números pedidos

                Console.WriteLine("O número maior é = " + Math.Max(num1, num2));

                // Aqui perguntamos ao utilizador se quer continuar a comparar números

                Console.WriteLine("Quer continuar?s/n");

                do
                {
                    string cont = Console.ReadLine();

                    switch (cont)
                    {
                        case "s":                      // se a resposta for sim "s", o programa faz um loop e recomeça
                            validaLocal = true;
                            validaGlobal = false;
                            break;

                            // Se a resposta for não o programa termina com uma mensagem de despedida 
                            //e é perguntado se queremos fechar a janela do terminal
                        default:
                            Console.WriteLine("Até uma próxima!\n Se quiser fechar a consola pressione Esc!");
                            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                                System.Environment.Exit(1);
                            validaLocal = false;
                            validaGlobal = false;
                            break;
                    }

                } while (validaLocal == false);

               

            } while (validaGlobal == false);

            Console.ReadKey();

        }     
    }
}
