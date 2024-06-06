using DesafioPratico_FundamentosDoCSharp.Exercicio3;

Console.WriteLine("---- Programa que recebe dois números e imprime soma, subtração, multiplicação, divisão e média dos mesmos ----");

Console.Write("Digite o primeiro número: ");
double num1 = double.Parse(Console.ReadLine()!);

Console.Write("Digite o segundo número: ");
double num2 = double.Parse(Console.ReadLine()!);

var soma = Matematica.Soma(num1: num1, num2: num2);
var sub = Matematica.Subtracao(num1: num1, num2: num2);
var multiplicacao = Matematica.Multiplicacao(num1: num1, num2: num2);
var divisao = Matematica.Divisao(num1: num1, num2: num2);
var media = Matematica.Media(num1: num1, num2: num2);

Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Subtração: {sub}");
Console.WriteLine($"Multiplicação: {multiplicacao}");
Console.WriteLine($"Divisão: {divisao}");
Console.WriteLine($"Média: {media}");
