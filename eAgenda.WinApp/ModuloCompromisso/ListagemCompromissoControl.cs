using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgenda.WinApp.ModuloContato;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class ListagemCompromissoControl : UserControl
    {
        public ListagemCompromissoControl()
        {
            InitializeComponent();
        }

        public void AtualizarLista(List<Compromisso> compromissos)
        {
            listCompromissos.Items.Clear();

            foreach (Compromisso compromisso in compromissos)
                listCompromissos.Items.Add(compromisso);
        }

        public Compromisso ObterRegistroSelecionado()
        {
            if (listCompromissos.SelectedItem == null)
                return null;

            return (Compromisso)listCompromissos.SelectedItem;
        }
    }
}
