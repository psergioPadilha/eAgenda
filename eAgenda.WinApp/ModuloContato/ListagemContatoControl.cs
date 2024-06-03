using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgenda.WinApp.ModuloCompromisso;
using eAgenda.WinApp.ModuloContato;

namespace eAgenda.WinApp.ModuloContato
{
    public partial class ListagemContatoControl : UserControl
    {
        public ListagemContatoControl()
        {
            InitializeComponent();
        }

        public void AtualizarLista(List<Contato> contatos)
        {
            listContatos.Items.Clear();

            foreach (Contato contato in contatos)
                listContatos.Items.Add(contato);
        }

        public Contato ObterRegistroSelecionado()
        {
            if (listContatos.SelectedItem == null)
                return null;

            return (Contato)listContatos.SelectedItem;
        }
    }
}