using System;
using System.Collections.Generic;
using Xperiments.DesignPatterns.Observer.Models;

namespace Xperiments.DesignPatterns.Observer
{

    public interface IAcaoAposGerarNotaFiscal
    {   
        void Executa(NotaFiscal nf);

    }

}