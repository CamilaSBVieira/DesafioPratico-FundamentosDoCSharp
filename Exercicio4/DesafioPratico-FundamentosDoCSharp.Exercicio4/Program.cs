using DesafioPratico_FundamentosDoCSharp.Exercicio4;

Console.WriteLine("---- Programa que recebe uma ou mais palavras e retorna o número total de caracteres (excluindo espaços) ----");

Console.Write("Digite uma ou mais palavras: ");
var texto = Console.ReadLine();

var quantidade = Caracter.Contar(texto!);
Console.WriteLine($"Quantidade de caracteres: {quantidade}");