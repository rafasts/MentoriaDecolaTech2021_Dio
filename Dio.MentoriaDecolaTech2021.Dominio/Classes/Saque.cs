using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.MentoriaDecolaTech2021.Dominio.Classes
{
    public class Saque : Lancamento
    {
        public Saque(decimal valor, DateTime data, ContaBancaria conta) : base(valor, data, conta)
        {

        }
    }
}
