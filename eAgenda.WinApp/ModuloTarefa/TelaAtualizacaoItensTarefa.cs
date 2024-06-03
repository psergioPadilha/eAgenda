using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class TelaAtualizacaoItensTarefa : Form
    {
        private Tarefa tarefaSelecionada;

        public List<ItemTarefa> ItensPendentes
        {
            get
            {
                return checkedListBoxItensTarefa.CheckedItems.Cast<ItemTarefa>().Except(ItensConcluidos).ToList();
            } 
        }

        public List<ItemTarefa> ItensConcluidos
        {
            get
            {
                return checkedListBoxItensTarefa.CheckedItems.Cast<ItemTarefa>().ToList();
            }
        }

        public TelaAtualizacaoItensTarefa(Tarefa tarefaSelecionada)
        {
            InitializeComponent();

            this.tarefaSelecionada = tarefaSelecionada;
            lblTituloTarefa.Text = tarefaSelecionada.Titulo;
            CarregarItensSelecionados(tarefaSelecionada);
        }

        private void CarregarItensSelecionados(Tarefa tarefaSelecionada)
        {
            int i = 0;

            foreach (ItemTarefa item in tarefaSelecionada.Itens)
            {
                checkedListBoxItensTarefa.Items.Add(item);

                if (item.Concluido)
                    checkedListBoxItensTarefa.SetItemChecked(0, true);

                i++;
            }
        }
    }
}
