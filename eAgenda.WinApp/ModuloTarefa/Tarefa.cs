using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase
    {
        public string Titulo { get; set; }
        public PrioridadeEnum Prioridade { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime DataConclusao { get; set; }

        public List<ItemTarefa> Itens { get; set; }
        public decimal PercentualConcluido
        {
            get
            {
                if(Itens.Count == 0)
                    return 0;

                int quantidadeConcluida = Itens.Count(i => i.Concluido);

                decimal percentualBase = (quantidadeConcluida / (decimal)Itens.Count) * 100;

                return Math.Round(percentualBase, 2);
            }
        }

        public Tarefa(string titulo, PrioridadeEnum prioridade)
        {
            Titulo = titulo;
            Prioridade = prioridade;
            DataCriacao = DateTime.Now;
            DataConclusao = DateTime.MinValue;

            Itens = new List<ItemTarefa>();
        }

        public bool AdicionarItem(ItemTarefa itemTarefa)
        {
            if(Itens.Exists(i => i.Titulo == itemTarefa.Titulo))
                return false;

            itemTarefa.Tarefa = this;
            Itens.Add(itemTarefa);

            DataConclusao = DateTime.MinValue;

            return true;
        }

        public void ConcluirItem(ItemTarefa item)
        {
            ItemTarefa itemTarefa = Itens.Find(i => i.Titulo == item.Titulo);
            
            if (itemTarefa == null)
                return;

            itemTarefa.Concluir();

            if (Itens.All(i => i.Concluido))
                DataConclusao = DateTime.Now;
        }

        public void Marcarpendente(ItemTarefa item)
        {
            ItemTarefa itemTarefa = Itens.Find(i => i.Titulo == item.Titulo);

            if (itemTarefa == null)
                return;

            itemTarefa.Marcarpendente();
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tarefa novaTarefa = (Tarefa)novoRegistro;

            Titulo = novaTarefa.Titulo;
            Prioridade = novaTarefa.Prioridade;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrEmpty(Titulo.Trim()))
                erros.Add("O campo \"TÍTULO\" é obrigatório!");

            return erros;
        }
    }
}
