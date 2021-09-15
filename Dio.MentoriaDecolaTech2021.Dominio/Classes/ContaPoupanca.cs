﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.MentoriaDecolaTech2021.Dominio.Classes
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(Cliente cliente) : base(cliente)
        {
            // 0,30%
            PercentualRendimento = 0.003M;
        }

        public decimal PercentualRendimento { get; private set; }
    }
}
