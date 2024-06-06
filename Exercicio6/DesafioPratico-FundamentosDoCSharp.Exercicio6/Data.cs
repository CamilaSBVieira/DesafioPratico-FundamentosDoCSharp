using System.Globalization;

namespace DesafioPratico_FundamentosDoCSharp.Exercicio6
{
    public static class Data
    {
        private static readonly CultureInfo _culture = CultureInfo.CurrentCulture;
        public static string FormatoCompleto()
        {
            return DateTime.UtcNow.ToString("F", _culture);
        }
        public static string ApenasData()
        {
            return DateTime.UtcNow.ToString("d", _culture);
        }
        public static string ApenasHora()
        {
            return DateTime.UtcNow.ToString("t", _culture);
        }
        public static string MesPorExtenso()
        {
            return DateTime.UtcNow.ToString("m", _culture);
        }
    }
}
