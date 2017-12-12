using System;
using System.Collections.Generic;

namespace Xperiments.DesignPatterns.Observer.Models
{
    public class ItemNotaFiscal
    {

        public ItemNotaFiscal(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
        public string Nome { get; set; }

        public double Valor { get; set; }

    }
}
