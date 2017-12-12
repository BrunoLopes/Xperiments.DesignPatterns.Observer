using System;
using System.Collections.Generic;
using Xperiments.DesignPatterns.Observer.Models;

namespace Xperiments.DesignPatterns.Observer
{

    public class EnviadorEmail : IAcaoAposGerarNotaFiscal
    {   
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("E-mail enviado");
        }

    }

}