using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloCompromisso;
using eAgenda.WinApp.ModuloContato;
using eAgenda.WinApp.ModuloTarefa;

namespace eAgenda.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;

        RepositorioContato repositorioContatos;
        RepositorioCompromisso repositorioCompromissos;
        RepositorioTarefa repositorioTarefa;

        public static TelaPrincipalForm Instancia { get; private set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();
            lblTipoCadastro.Text = string.Empty;

            repositorioContatos = new RepositorioContato();
            repositorioCompromissos = new RepositorioCompromisso();
            repositorioTarefa = new RepositorioTarefa();

            //Cadastro para facilitar nos testes
            CadastrarRegistroParaTeste();

            Instancia = this;
        }

        public void AtualizarRodape(string texto)
        {
            statusLabelPrincipal.Text = texto;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(controlador is IControladorFiltravel controladorFiltravel)
                controladorFiltravel.Filtrar();
        }

        private void btnAdicionarItens_Click(object sender, EventArgs e)
        {
            if(controlador is IcontroladorSubItem controladorSubItem)
                controladorSubItem.AdicionarItens();
        }

        private void btnConcluirItens_Click(object sender, EventArgs e)
        {
            if(controlador is IcontroladorSubItem controladorSubItem)
                controladorSubItem.AtualizarItens();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void tarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #region Itens de Menu
        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContatos(repositorioContatos);

            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

            ConfigurarTelaPrincipal(controlador);
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCompromisso(repositorioCompromissos, repositorioContatos);
            ConfigurarTelaPrincipal(controlador);
        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTarefa(repositorioTarefa);
            ConfigurarTelaPrincipal(controlador);
        }
        #endregion

        #region Configuração da tela principal
        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            lblTipoCadastro.Text = "Cadastro de " + controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }
        #endregion

        #region Configura toolBox
        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;
            btnFiltrar.Enabled = controladorSelecionado is IControladorFiltravel;
            btnAdicionarItens.Enabled = controladorSelecionado is IcontroladorSubItem;
            btnConcluirItens.Enabled = controladorSelecionado is IcontroladorSubItem;

            ConfigurarToolTips(controladorSelecionado);
        }
        #endregion

        #region Configura os tool tips
        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;

            if (controladorSelecionado is IControladorFiltravel controladorFiltravel)
                btnFiltrar.ToolTipText = controladorFiltravel.ToolTipFiltrar;

            if (controladorSelecionado is IcontroladorSubItem controladorSubItem)
            {
                btnAdicionarItens.ToolTipText = controladorSubItem.ToolTipAdicionarItens;
                btnConcluirItens.ToolTipText = controladorSubItem.ToolTipConcluirItens;
            }
        }
        #endregion

        #region Configura a listagem
        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemContato = controladorSelecionado.ObterListagem();
            listagemContato.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemContato);
        }
        #endregion

        #region Cadastra registros para teste
        private void CadastrarRegistroParaTeste()
        {
            //cadastra registro de contato para teste
            Contato contato = new Contato("CARLOS EDUARDO DA SILVA", "49996815377", "dudu@gmail.com", "AMERICA DISTRIBUIÇÃO SA", "VENDEDOR");
            repositorioContatos.Cadastrar(contato);

            //cadastra registro de contato para teste
            Contato contato1 = new Contato("MARIA EDUARDA DA COSTA", "48999412287", "dudacosta@gmail.com", "UNIMED LITORAL SA", "COMPRADORA");
            repositorioContatos.Cadastrar(contato1);

            //cadastra registro de contato para teste
            Contato contato2 = new Contato("HÉRICA SCEIDT", "47998539190", "hericaherica@hotmail.com.br", "TRANSPORTES GLOBO LTDA", "SÓCIA PROPRIETÁRIA");
            repositorioContatos.Cadastrar(contato2);

            //cadastra registro de compromisso para teste
            DateTime data = DateTime.Today.AddDays(-3);
            TimeSpan horaInicio = new TimeSpan(09, 00, 00);
            TimeSpan horaTermino = new TimeSpan(10, 00, 00);
            Compromisso compromisso = new Compromisso("REUNIÃO", data, horaInicio, horaTermino, contato, "BANCO DO BRASIL", "PRESENCIAL");
            repositorioCompromissos.Cadastrar(compromisso);

            //cadastra registro de compromisso para teste
            DateTime data1 = DateTime.Today.AddDays(-8);
            TimeSpan horaInicio1 = new TimeSpan(13, 30, 00);
            TimeSpan horaTermino1 = new TimeSpan(17, 00, 00);
            Compromisso compromisso1 = new Compromisso("REUNIÃO", data1, horaInicio1, horaTermino1, contato1, "MEET", "REMOTO");
            repositorioCompromissos.Cadastrar(compromisso1);

            //cadastra registro de compromisso para teste
            DateTime data2 = DateTime.Today.AddDays(+13);
            TimeSpan horaInicio2 = new TimeSpan(09, 00, 00);
            TimeSpan horaTermino2 = new TimeSpan(10, 00, 00);
            Compromisso compromisso2 = new Compromisso("REUNIÃO", data2, horaInicio2, horaTermino2, contato2, "FEIRA DE EXPOSIÇÃO", "PRESENCIAL");
            repositorioCompromissos.Cadastrar(compromisso2);

            //cadastra registro de compromisso para teste
            DateTime data3 = DateTime.Today;
            TimeSpan horaInicio3 = new TimeSpan(22, 45, 00);
            TimeSpan horaTermino3 = new TimeSpan(23, 59, 00);
            Compromisso compromisso3 = new Compromisso("REUNIÃO", data3, horaInicio3, horaTermino3, contato1, "EMPRESA", "PRESENCIAL");
            repositorioCompromissos.Cadastrar(compromisso3);

            //Cadastra registro de tarefas para teste
            List<Tarefa> tarefas = new List<Tarefa>()
            {
                new Tarefa("Rever vídeos da academia", PrioridadeEnum.Normal),
                new Tarefa("Desenvolver Módulo Tarefa", PrioridadeEnum.Alta),
                new Tarefa("Desenvolver Módulo Item Tarefa", PrioridadeEnum.Alta),
                new Tarefa("Refatorar códigos e-Agenda", PrioridadeEnum.Normal),
                new Tarefa("Entregar trabalho e-Agenda", PrioridadeEnum.Alta),
                new Tarefa("Estudar Padrões de Projeto", PrioridadeEnum.Baixa),
                new Tarefa("Estudar programação C#", PrioridadeEnum.Alta)
            };
            repositorioTarefa.CadastrarVarios(tarefas);
        }
        #endregion

    }
}
