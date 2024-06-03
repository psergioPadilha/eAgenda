using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.Compartilhado
{
    public static class StringExtensions
    {
        public static string ToTitleCase(this string texto)
        {
            string[] palavra = texto.Split(' ');

            for (int i = 0; i < palavra.Length; i ++)
            {
                string palavraMaiuscula = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(palavra[i].ToLower());
                palavra[i] = palavraMaiuscula;
            }
            return string.Join(" ", palavra);
        }
    }
}
