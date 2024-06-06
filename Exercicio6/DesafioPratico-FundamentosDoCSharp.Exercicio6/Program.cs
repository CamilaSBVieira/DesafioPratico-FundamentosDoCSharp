using DesafioPratico_FundamentosDoCSharp.Exercicio6;

Console.WriteLine("---- Programa que exibe a data em 4 formatos diferentes ----\n");

int opcao;
do
{
    Console.WriteLine("1 - Exibir data no formato completo");
    Console.WriteLine("2 - Exibir apenas data");
    Console.WriteLine("3 - Exibir apenas hora");
    Console.WriteLine("4 - Exibir data com mês por extenso");
    Console.WriteLine("0 - Sair");
    Console.Write("Digite a opção desejada: ");
    opcao = int.Parse(Console.ReadLine()!);
    Console.WriteLine("");

    switch (opcao) {
        case 1:
            Console.WriteLine(Data.FormatoCompleto());
            break;
        case 2:
            Console.WriteLine(Data.ApenasData());
            break;
        case 3:
            Console.WriteLine(Data.ApenasHora());
            break;
        case 4:
            Console.WriteLine(Data.MesPorExtenso());
            break;
        case 0:
            return;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine("");
} while (opcao != 0);

