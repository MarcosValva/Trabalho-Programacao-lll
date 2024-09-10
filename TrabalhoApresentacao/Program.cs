using System;
using TrabalhoApresentacao.uteis; //importa namespace onde as classes AluguelCarro e Bhaskara estão localizadas

class Program
{
    static void Main()
    {
        int opcao = 0;

        do
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1) Aluguel de carro");
            Console.WriteLine("2) Calcular Bhaskara");
            Console.WriteLine("0) Sair");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 0:
                    Console.WriteLine("Fim do Programa");
                    //pausa até o usuário pressionar uma tecla e, em seguida, sai do programa
                    Console.WriteLine("Pressione qualquer tecla para sair...");
                    Console.ReadKey();
                    return;  //encerra o programa

                case 1:
                    Console.WriteLine("Bem-vindo ao sistema de aluguel de carros!");
                    //cria uma instância da classe AluguelCarro
                    AluguelCarro aluguelCarro = new AluguelCarro();

                    //coleta informações do usuário
                    Console.Write("Nome do cliente: ");
                    string cliente = Console.ReadLine();

                    //coleta informação do carro
                    Console.Write("Modelo do carro: ");
                    string modelo = Console.ReadLine();

                    //coleta informação dos dias que vai querer ficar com o carro
                    Console.Write("Número de dias de aluguel: ");
                    int dias = int.Parse(Console.ReadLine());

                    //calcula o total do aluguel
                    double total = aluguelCarro.CalcularCusto(dias);

                    //exibe o resultado
                    Console.WriteLine($"Cliente: {cliente}");
                    Console.WriteLine($"Modelo do carro: {modelo}");
                    Console.WriteLine($"Número de dias: {dias}");
                    Console.WriteLine($"Total a pagar: R${total:F2}");

                    //mantém a tela aberta
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal...");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Bem-vindo ao calculador de Bhaskara!");

                    //coleta os coeficientes da equação
                    Console.Write("Digite o valor de a: ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("Digite o valor de b: ");
                    double b = double.Parse(Console.ReadLine());

                    Console.Write("Digite o valor de c: ");
                    double c = double.Parse(Console.ReadLine());

                    //calcula as raízes
                    (bool sucesso, double raiz1, double raiz2) = Bhaskara.CalcularRaizes(a, b, c);

                    //exibe o resultado
                    if (sucesso)
                    {
                        Console.WriteLine($"Raiz 1: {raiz1:F2}");
                        Console.WriteLine($"Raiz 2: {raiz2:F2}");
                    }
                    else
                    {
                        Console.WriteLine("A equação não tem raízes reais.");
                    }
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal...");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        } while (opcao != 0);
    }
}