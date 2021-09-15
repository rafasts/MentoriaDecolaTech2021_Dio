using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.MentoriaDecolaTech2021.Dominio.Classes
{
    public class Cliente
    {
        public Cliente(string nome, string cpf, string rg, Endereco endereco)
        {
            Nome = nome.ValidaStringVazia();
            CPF = cpf.ValidaStringVazia();
            RG = rg.ValidaStringVazia();
            Endereco = endereco ?? throw new Exception("Endereço deve ser informado.");
        }

        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public Endereco Endereco { get; private set; }
    }
}
