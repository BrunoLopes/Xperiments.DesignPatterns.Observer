using System;
using System.Collections.Generic;
using Xperiments.DesignPatterns.Observer.Models;

namespace Xperiments.DesignPatterns.Observer
{

    public class NotaFiscalDAO : IAcaoAposGerarNotaFiscal
    {   
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Nota fiscal salva no banco de dados.");
        }

    }

}