using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefa : RepositorioBase<Tarefa>
    {
        public void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itens)
        {
            foreach(ItemTarefa item in itens)
                tarefaSelecionada.AdicionarItem(item);
        }

        internal void AtualizarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itensPendentes, List<ItemTarefa> itensConcluidos)
        {
            foreach (ItemTarefa i in itensPendentes)
                tarefaSelecionada.Marcarpendente(i);

            foreach (ItemTarefa i in itensConcluidos)
                tarefaSelecionada.ConcluirItem(i);
        }
    }
}
