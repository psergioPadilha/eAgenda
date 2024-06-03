using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloCompromisso;

namespace eAgenda.WinApp.ModuloContato
{
    public class ControladorContatos : ControladorBase
    {
        private RepositorioContato repositorioContato;
        private TabelaContatoControl tabelaContato;

        #region Contrutor
        public ControladorContatos(RepositorioContato repositorio)
        {
            repositorioContato = repositorio;
        }
        #endregion

        #region Declarações
        public override string TipoCadastro { get { return "Contatos"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar Contato"; } }

        public override string ToolTipEditar { get { return "Editar Contato"; } }

        public override string ToolTipExcluir { get { return "Excluir Contato"; } }
        #endregion

        #region Adiciona registro
        internal override void Adicionar()
        {
            TelaContatoForm telaContatoForm = new TelaContatoForm();
            DialogResult resultado = telaContatoForm.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Contato novoContato = telaContatoForm.Contato;
            repositorioContato.Cadastrar(novoContato);

            CarregarContatos();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoContato.Nome}\" foi criado com sucesso!");
        }
        #endregion

        #region Edita registro selecionado
        internal override void Editar()
        {
            TelaContatoForm telaContato = new TelaContatoForm();
            
            int idSelecionado = tabelaContato.ObterRegistroSelecionado();

            Contato contatoSelecionado = repositorioContato.SelecionarPorId(idSelecionado);

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            telaContato.Contato = contatoSelecionado;

            DialogResult resultado = telaContato.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Contato contatoEditado = telaContato.Contato;

            repositorioContato.Editar(contatoSelecionado.Id, contatoEditado);

            CarregarContatos();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{contatoEditado.Nome}\" foi editado com sucesso!");
        }
        #endregion

        #region Excluir registro
        internal override void Excluir()
        {
            int idSelecionado = tabelaContato.ObterRegistroSelecionado();

            Contato contatoSelecionado = repositorioContato.SelecionarPorId(idSelecionado);

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{contatoSelecionado.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioContato.Excluir(contatoSelecionado.Id);

            CarregarContatos();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{contatoSelecionado.Nome}\" foi excluído com sucesso!");
        }
        #endregion

        #region Obtem Registro
        public override UserControl ObterListagem()
        {
            if (tabelaContato == null)
                tabelaContato = new TabelaContatoControl();
            
            CarregarContatos();

            return tabelaContato;
        }
        #endregion

        #region Carrega registros na lista
        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();
            tabelaContato.AtualizarRegistros(contatos);
        }
        #endregion

    }
}
