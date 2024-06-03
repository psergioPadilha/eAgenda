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
    public partial class TelaTarefaForm : Form
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
                txtBoxId.Text = value.Id.ToString();
                txtBoxTitulo.Text = value.Titulo;
                cmbBoxPrioridade.SelectedItem = value.Prioridade;
            }
        }

        public TelaTarefaForm()
        {
            InitializeComponent();

            lblId.Enabled = false;
            CarregarPrioridades();
        }

        #region Eventos de menu
        private void bttLimpar_Click(object sender, EventArgs e)
        {
            txtBoxId.Text = string.Empty;
            txtBoxTitulo.Text = string.Empty;
            cmbBoxPrioridade.SelectedItem = PrioridadeEnum.Baixa;
            txtBoxTitulo.Focus();
        }

        private void bttSalvar_Click(object sender, EventArgs e)
        {
            string titulo = txtBoxTitulo.Text;
            PrioridadeEnum prioridade = (PrioridadeEnum)cmbBoxPrioridade.SelectedItem;

            tarefa = new Tarefa(titulo, prioridade);

            List<string> erros = tarefa.Validar();

            if(erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
        #endregion


        #region Carrega as prioridades no comboBoxPrioridades
        private void CarregarPrioridades()
        {
            Array valoresEnum = Enum.GetValues(typeof(PrioridadeEnum));

            foreach (var valor in valoresEnum)
                cmbBoxPrioridade.Items.Add(valor);

            cmbBoxPrioridade.SelectedItem = PrioridadeEnum.Baixa;
        }
        #endregion
    }
}
