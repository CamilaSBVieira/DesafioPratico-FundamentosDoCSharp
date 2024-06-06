using DesafioPratico_FundamentosDoCSharp.Exercicio5;

Console.WriteLine("---- Programa que recebe uma placa e retorna Verdadeiro ou Falso de acordo com a validade da placa ----");

Console.Write("Digite a placa a ser verificada: ");
var placa = Console.ReadLine();

var eValida = Placa.Verificar(placa!);
Console.WriteLine(eValida ? "Verdadeiro" : "Falso");
