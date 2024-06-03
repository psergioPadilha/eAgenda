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
    public partial class TabelaTarefaControl : UserControl
    {
        public TabelaTarefaControl()
        {
            InitializeComponent();

            ConfigurarColunas();
            ConfigurarListView();
        }

        #region Atualiza os itens das lista
        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            listTarefas.Items.Clear();
            listTarefas.Groups.Clear();

            var tarefasAgrupadas = tarefas.GroupBy(tarefa => tarefa.Prioridade);

            foreach (var grupo in tarefasAgrupadas)
            {
                ListViewGroup listViewGroup = new ListViewGroup($"Priorodade {grupo.Key}", HorizontalAlignment.Left);

                listTarefas.Groups.Add(listViewGroup);

                foreach (Tarefa tarefa in grupo)
                {
                    ListViewItem item = new ListViewItem(tarefa.Id.ToString())
                    { 
                        Tag = tarefa,    
                    };

                    item.SubItems.Add(tarefa.Titulo);
                    item.SubItems.Add(tarefa.DataCriacao.ToShortDateString());
                    item.SubItems.Add(tarefa.PercentualConcluido + "%");

                    item.Group = listViewGroup;

                    listTarefas.Items.Add(item);
                }
            }
            listTarefas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        #endregion

        #region Obtem id selecionado
        public int ObterIdSelecionado()
        {
            if(listTarefas.SelectedItems.Count == 0)
                return -1;

            var tarefaSelecionada = (Tarefa)listTarefas.SelectedItems[0].Tag;

            return tarefaSelecionada.Id;
        }
        #endregion

        #region Configura as colunas da listView
        private void ConfigurarColunas()
        {
            ColumnHeader[] colunas = new ColumnHeader[]
                        {
                new ColumnHeader() { Text = "ID" },
                new ColumnHeader() { Text = "TÍTULO" },
                new ColumnHeader() { Text = "DATA" },
                new ColumnHeader() { Text = "% Concluído", TextAlign = HorizontalAlignment.Right}
                        };
            ConfigurarAparenciaColuna(colunas);
        }
        #endregion

        #region Configura a aparência da coluna
        private void ConfigurarAparenciaColuna(ColumnHeader[] colunas)
        {
            listTarefas.Columns.AddRange(colunas);
            listTarefas.Columns[0].Width = 80;
        }
        #endregion

        #region Configura a lista
        private void ConfigurarListView()
        {
            listTarefas.MultiSelect = false;
            listTarefas.FullRowSelect = true;
            listTarefas.GridLines = true;
            listTarefas.View = View.Details;
        }
        #endregion
    }
}
