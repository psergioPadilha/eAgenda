using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;

namespace eAgenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase, IcontroladorSubItem
    {
        private TabelaTarefaControl listTarefas;
        private RepositorioTarefa repositorioTarefa;

        public override string TipoCadastro { get { return "Tarefas"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar Tarefa"; } }

        public override string ToolTipEditar { get { return "Editar Tarefa"; } }

        public override string ToolTipExcluir { get { return "Excluir Tarefa"; } }

        public string ToolTipAdicionarItens { get { return "Adicionar Itens Tarefa "; } }

        public string ToolTipConcluirItens { get { return "Concluir Itens Tarefa "; } }

        public ControladorTarefa(RepositorioTarefa repositorioTarefa)
        {
            this.repositorioTarefa = repositorioTarefa;
        }

        #region Obtem listagem de tarefas
        public override UserControl ObterListagem()
        {
            if(listTarefas == null)
                listTarefas = new TabelaTarefaControl();
            CarregarTarefas();

            return listTarefas;
        }
        #endregion

        #region Adiciona registro
        internal override void Adicionar()
        {
            TelaTarefaForm telaTarefaForm = new TelaTarefaForm();
            DialogResult resultado = telaTarefaForm.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Tarefa novaTarefa = telaTarefaForm.Tarefa;
            repositorioTarefa.Cadastrar(novaTarefa);

            CarregarTarefas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novaTarefa.Titulo}\" foi criado com sucesso!");
        }
        #endregion

        #region Edita registro
        internal override void Editar()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm();

            int idSelecionado = listTarefas.ObterIdSelecionado();

            Tarefa tarefaSelecionada = repositorioTarefa.SelecionarPorId(idSelecionado);

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return;
            }

            telaTarefa.Tarefa = tarefaSelecionada;

            DialogResult resultado = telaTarefa.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Tarefa tarefaEditada = telaTarefa.Tarefa;

            repositorioTarefa.Editar(tarefaSelecionada.Id, tarefaEditada);

            CarregarTarefas();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{tarefaEditada.Titulo}\" foi editado com sucesso!");
        }
        #endregion

        #region Exclui registro
        internal override void Excluir()
        {
            int idSelecionado = listTarefas.ObterIdSelecionado();

            Tarefa tarefaSelecionada = repositorioTarefa.SelecionarPorId(idSelecionado);

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{tarefaSelecionada.Titulo}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioTarefa.Excluir(tarefaSelecionada.Id);

            CarregarTarefas();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{tarefaSelecionada.Titulo}\" foi excluído com sucesso!");
        }
        #endregion

        #region Adiciona itens de tarefa
        public void AdicionarItens()
        {
            int idSelecionado = listTarefas.ObterIdSelecionado();

            Tarefa tarefaSelecionada = repositorioTarefa.SelecionarPorId(idSelecionado);

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            TelaCadastroItensTarefa tela = new TelaCadastroItensTarefa(tarefaSelecionada);

            DialogResult resultado = tela.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            List<ItemTarefa> itens = tela.ItensAdicionados;

            repositorioTarefa.AdicionarItens(tarefaSelecionada, itens);

            CarregarTarefas();
        }
        #endregion

        public void AtualizarItens()
        {
            int idSelecionado = listTarefas.ObterIdSelecionado();

            Tarefa tarefaSelecionada = repositorioTarefa.SelecionarPorId(idSelecionado);

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            TelaAtualizacaoItensTarefa tela = new TelaAtualizacaoItensTarefa(tarefaSelecionada);

            DialogResult resultado = tela.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            List<ItemTarefa> itensPendentes = tela.ItensPendentes;
            List<ItemTarefa> itensconcluidos = tela.ItensConcluidos;

            repositorioTarefa.AtualizarItens(tarefaSelecionada, itensPendentes, itensconcluidos);

            CarregarTarefas();
        }

        #region Carrega tarefa
        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();
            listTarefas.AtualizarRegistros(tarefas);
        }
        #endregion
    }
}
