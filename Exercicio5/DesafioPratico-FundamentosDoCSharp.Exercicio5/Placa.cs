namespace DesafioPratico_FundamentosDoCSharp.Exercicio5
{
    public static class Placa
    {
        public static bool Verificar(string placa)
        {
            var letras = placa.Substring(0, 3);
            foreach(char l in letras)
            {
                if (!Char.IsLetter(l))
                    return false;
            }
            var numeros = placa.Substring(3, 4);
            foreach(char n in numeros)
            {
                if (!Char.IsNumber(n))
                    return false;
            }
            return true;
        }
    }
}
