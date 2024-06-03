using System;
using System.Collections.Generic;
using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloDespesas
{
    public class Despesa : EntidadeBase
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataDespesa { get; set; }
        public string FormaPagamento { get; set; }
        public List<Categoria> Categoria { get; set; }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            throw new NotImplementedException();
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
