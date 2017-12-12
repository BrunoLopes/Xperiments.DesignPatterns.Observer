using System;
using System.Collections.Generic;
using Xperiments.DesignPatterns.Observer.Models;

namespace Xperiments.DesignPatterns.Observer
{

    public class NotaFiscalBuilder
    {   
        public NotaFiscalBuilder(IList<IAcaoAposGerarNotaFiscal> acoes)
        {
            this.todasAcoesASeremExecutadas = acoes;
        }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public double ValorTotal { get; set; }
        public double Impostos { get; set; }
        public IList<ItemNotaFiscal> Itens {get; set;} = new List<ItemNotaFiscal>();
        public string Observacoes { get; set; }

        private IList<IAcaoAposGerarNotaFiscal> todasAcoesASeremExecutadas = new List<IAcaoAposGerarNotaFiscal>();

        public DateTime DataEmissaoNotaFiscal { get; private set; }
        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCNPJ(string cnpj)
        {
            this.CNPJ = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacao)
        {
            this.Observacoes = observacao;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.DataEmissaoNotaFiscal = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemNotaFiscal item)
        {
            this.Itens.Add(item);
            this.ValorTotal += item.Valor;
            this.Impostos = this.ValorTotal * 0.05;
            return this;
        }

        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal( RazaoSocial, CNPJ, DataEmissaoNotaFiscal, ValorTotal, Impostos, Itens, Observacoes);

            foreach (var acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(nf);
            }
            return nf;

        }

        public void AdicionaAcao(IAcaoAposGerarNotaFiscal novaAcao)
        {
            this.todasAcoesASeremExecutadas.Add(novaAcao);
        }
    }

}