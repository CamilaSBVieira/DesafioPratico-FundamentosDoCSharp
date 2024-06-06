namespace DesafioPratico_FundamentosDoCSharp.Exercicio4
{
    public static class Caracter
    {
        public static int Contar(string texto)
        {
            int quantidade = 0;
            foreach(char c in texto)
            {
                if (c != ' ')
                    quantidade++;
            }
            return quantidade;
        }
    }
}
