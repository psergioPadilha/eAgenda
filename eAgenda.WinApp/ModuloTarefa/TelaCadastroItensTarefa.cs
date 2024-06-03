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
    public partial class TelaCadastroItensTarefa : Form
    {
        private Tarefa tarefa;
        public Tarefa Tarefa
        {
            get
            {
                return tarefa; 
            }
            set
            {
                tarefa = value;
            }
        }

        public List<ItemTarefa> ItensAdicionados
        {
            get
            {
                return listItensTarefa.Items.Cast<ItemTarefa>().ToList();
            } 
        }

        public TelaCadastroItensTarefa(Tarefa tarefaSelecionada)
        {
            InitializeComponent();

            Tarefa = tarefaSelecionada;
            lblTituloTarefa.Text = tarefaSelecionada.Titulo;

            foreach(ItemTarefa item in tarefaSelecionada.Itens)
                listItensTarefa.Items.Add(item);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            List<string> titulos = ItensAdicionados.Select(x => x.Titulo).ToList();

            if (titulos.Contains(txtTitulo.Text))
            {
                MessageBox.Show("Este item jáfoi adicionado na tarefa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitulo.Text = string.Empty;
                txtTitulo.Focus();

                return;
            }
            else if (txtTitulo.Text.Length == 0)
            {
                MessageBox.Show("Por favor digite um título para adicionar um item de tarefa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitulo.Focus();

                return;
            }

            ItemTarefa itemTarefa = new ItemTarefa(txtTitulo.Text);

            listItensTarefa.Items.Add(itemTarefa);

            txtTitulo.Text = string.Empty;
            txtTitulo.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = string.Empty;
            txtTitulo.Focus();
        }
    }
}
