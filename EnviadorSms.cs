using System;
using System.Collections.Generic;
using Xperiments.DesignPatterns.Observer.Models;

namespace Xperiments.DesignPatterns.Observer
{

    public class EnviadorSms : IAcaoAposGerarNotaFiscal
    {   
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("SMS enviado com sucesso.");
        }

    }

}