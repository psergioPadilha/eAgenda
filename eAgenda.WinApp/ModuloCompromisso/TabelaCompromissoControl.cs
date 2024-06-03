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
using eAgenda.WinApp.ModuloContato;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TabelaCompromissoControl : UserControl
    {
        public TabelaCompromissoControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(obterColunas());
            grid.ConfiguraGrid();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            grid.Rows.Clear();
            foreach (Compromisso compromisso in compromissos)
                grid.Rows.Add
                (
                    compromisso.Id,
                    compromisso.Assunto.ToTitleCase(),
                    compromisso.DataCompromisso,
                    compromisso.HoraInicio,
                    compromisso.HoraTermino,
                    compromisso.Contato.Nome.ToTitleCase(),
                    compromisso.Local.ToTitleCase(),
                    compromisso.Modo.ToTitleCase()
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
                new DataGridViewTextBoxColumn{ DataPropertyName = "Assunto", HeaderText = "ASSUNTO" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "HoraInicio", HeaderText = "INÍCIO" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "HoraTermino", HeaderText = "TÉRMINO" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Contato", HeaderText = "CONTATO" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Local", HeaderText = "LOCAL" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Modo", HeaderText = "MODO" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Data", HeaderText = "DATA" }
                        };
        }
    }
}
