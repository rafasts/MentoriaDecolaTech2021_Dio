using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.MentoriaDecolaTech2021.Dominio.Classes
{
    public class Deposito : Lancamento
    {
        public Deposito(decimal valor, DateTime data, ContaBancaria conta) : base(valor, data, conta)
        {

        }
    }
}
