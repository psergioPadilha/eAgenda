using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase, IControladorFiltravel
    {
        private TabelaCompromissoControl tabelaCompromisso;
        
        private RepositorioCompromisso repositorioCompromisso;
        private RepositorioContato repositorioContato;

        #region Método construtor de classe
        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso, RepositorioContato repositorioContato)
        {
            this.repositorioCompromisso = repositorioCompromisso;
            this.repositorioContato = repositorioContato;
        }
        #endregion

        #region Declarações
        public override string TipoCadastro { get { return "Compromissos"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar Compromisso"; } }

        public override string ToolTipEditar { get { return "Editar Compromisso"; } }

        public override string ToolTipExcluir { get { return "Excluir Compromisso"; } }

        public string ToolTipFiltrar { get { return "Filtrar Compromissos"; } }
        #endregion

        #region Adicionar
        internal override void Adicionar()
        {
            TelaCompromissoForm telaCompromissoForm = new TelaCompromissoForm();

            List<Contato> contatosCadastrados  = repositorioContato.SelecionarTodos();
            telaCompromissoForm.CarregarContatos(contatosCadastrados);

            DialogResult resultado = telaCompromissoForm.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Compromisso novoCompromisso = telaCompromissoForm.Compromisso;
            repositorioCompromisso.Cadastrar(novoCompromisso);

            CarregarCompromissos();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoCompromisso.Local}\" foi criado com sucesso!");
        }
        #endregion

        #region Editar
        internal override void Editar()
        {
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();

            List<Contato> contatosCadastrados = repositorioContato.SelecionarTodos();

            telaCompromisso.CarregarContatos(contatosCadastrados);

            int idSelecionado = tabelaCompromisso.ObterRegistroSelecionado();

            Compromisso compromissoSelecionado = repositorioCompromisso.SelecionarPorId(idSelecionado);

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            telaCompromisso.Compromisso = compromissoSelecionado;

            DialogResult resultado = telaCompromisso.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Compromisso compromissoEditado = telaCompromisso.Compromisso;

            repositorioCompromisso.Editar(compromissoSelecionado.Id, compromissoEditado);

            CarregarCompromissos();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{compromissoEditado.Assunto}\" foi editado com sucesso!");
        }
        #endregion

        #region Excluir
        internal override void Excluir()
        {
            int idSelecionado = tabelaCompromisso.ObterRegistroSelecionado();

            Compromisso compromissoSelecionado = repositorioCompromisso.SelecionarPorId(idSelecionado);

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{compromissoSelecionado.Assunto}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado != DialogResult.Yes)
                return;

            repositorioCompromisso.Excluir(compromissoSelecionado.Id);

            CarregarCompromissos();

            TelaPrincipalForm
               .Instancia
               .AtualizarRodape($"O registro \"{compromissoSelecionado.Assunto}\" foi excluído com sucesso!");
        }
        #endregion

        #region Obtem lista de registros
        public override UserControl ObterListagem()
        {
            if (tabelaCompromisso == null)
                tabelaCompromisso = new TabelaCompromissoControl();

            CarregarCompromissos();

            return tabelaCompromisso;
        }
        #endregion

        #region Carrega registros na lista
        public void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();
            tabelaCompromisso.AtualizarRegistros(compromissos);
        }
        #endregion

        #region Filtra consultas de compromisso
        public void Filtrar()
        {
            TelaFiltroCompromissosForm telaFiltroCompromissos = new TelaFiltroCompromissosForm();
            DialogResult resultado = telaFiltroCompromissos.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            TipoFiltroCompromissoEnum filtroSelecionado = telaFiltroCompromissos.FiltroSelecionado;

            List<Compromisso> compromissosSelecionados;

            if (filtroSelecionado == TipoFiltroCompromissoEnum.Hoje)
                compromissosSelecionados = repositorioCompromisso.SelecionarCompromissoHoje();

            else if (filtroSelecionado == TipoFiltroCompromissoEnum.Passados)
                compromissosSelecionados = repositorioCompromisso.SlecionarCompromissosPassados();

            else if (filtroSelecionado == TipoFiltroCompromissoEnum.Futuros)
                compromissosSelecionados = repositorioCompromisso.SelecionarCompromissosFuturos();

            else if (filtroSelecionado == TipoFiltroCompromissoEnum.Periodo)
            {
                DateTime dataInicio = telaFiltroCompromissos.InicioPeriodo;
                DateTime dataTermino = telaFiltroCompromissos.TerminoPeriodo;

                compromissosSelecionados = repositorioCompromisso.SelecionarCompromissosPorPeriodo(dataInicio, dataTermino);
            }

            else
                compromissosSelecionados = repositorioCompromisso.SelecionarTodos();

            tabelaCompromisso.AtualizarRegistros(compromissosSelecionados);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {compromissosSelecionados.Count} registros...");
        }
        #endregion
    }
}
