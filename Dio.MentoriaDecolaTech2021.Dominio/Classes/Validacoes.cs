using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.MentoriaDecolaTech2021.Dominio.Classes
{
    public static class Validacoes
    {
        public static string ValidaStringVazia(this string texto)
        {
            return string.IsNullOrWhiteSpace(texto) ?
                             throw new Exception("Propriedade deve estar preenchida.")
                             : texto;
        }
    }
}
