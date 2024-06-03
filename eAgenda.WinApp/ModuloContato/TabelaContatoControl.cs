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

namespace eAgenda.WinApp.ModuloContato
{
    public partial class TabelaContatoControl : UserControl
    {
        public TabelaContatoControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(obterColunas());
            grid.ConfiguraGrid();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Contato> contatos)
        {
            grid.Rows.Clear();
            foreach (Contato contato in contatos)
                grid.Rows.Add
                (
                    contato.Id,
                    contato.Nome.ToTitleCase(),
                    contato.Telefone,
                    contato.Email,
                    contato.Empresa.ToTitleCase(),
                    contato.Cargo.ToTitleCase()
                );
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private static DataGridViewColumn[] obterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn{ DataPropertyName = "id", HeaderText = "ID" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Contato", HeaderText = "CONTATO" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Telefone", HeaderText = "TELEFONE" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Email", HeaderText = "EMAIL" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Empresa", HeaderText = "EMPRESA" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Cargo", HeaderText = "CARGO" }
            };
        }
    }
}
