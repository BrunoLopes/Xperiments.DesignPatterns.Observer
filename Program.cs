using System;
using Xperiments.DesignPatterns.Observer.Models;
using System.Collections.Generic;

namespace Xperiments.DesignPatterns.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaFiscalBuilder builder = new NotaFiscalBuilder(new List<IAcaoAposGerarNotaFiscal> { new EnviadorEmail(), new EnviadorSms(), new NotaFiscalDAO()  } );
        
            //Fluent Interface ou  Method Chain
            builder
                .ParaEmpresa("MFY IT")
                .ComCNPJ("123.456.789/0001-01")
                .ComItem(new ItemNotaFiscal("item 1", 100.00 ))
                .ComItem(new ItemNotaFiscal("item 2", 150.30 ))
                .NaDataAtual()
                .ComObservacoes("Teste com object builder");

            // builder.AdicionaAcao(new EnviadorEmail());
            // builder.AdicionaAcao(new EnviadorSms());
            // builder.AdicionaAcao(new NotaFiscalDAO());

            NotaFiscal nf = builder.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.ValorImposto);


        }
    }
}
