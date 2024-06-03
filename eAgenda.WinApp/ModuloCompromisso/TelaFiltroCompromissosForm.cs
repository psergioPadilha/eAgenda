using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TelaFiltroCompromissosForm : Form
    {
        public TipoFiltroCompromissoEnum FiltroSelecionado { get; private set; }

        public DateTime InicioPeriodo
        {
            get
            {
                return dateTimePickerDataInicio.Value;
            }
        }

        public DateTime TerminoPeriodo
        {
            get
            {
                return dateTimePickerFinal.Value;
            }
        }

        public TelaFiltroCompromissosForm()
        {
            InitializeComponent();
        }

        private void radioButtonPassados_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            if (radioButtonTodos.Checked)
                FiltroSelecionado = TipoFiltroCompromissoEnum.Todos;

            else if (radioButtonHoje.Checked)
                FiltroSelecionado = TipoFiltroCompromissoEnum.Hoje;

            else if (radioButtonPassados.Checked)
                FiltroSelecionado = TipoFiltroCompromissoEnum.Passados;

            else if (radioButtonFuturos.Checked)
                FiltroSelecionado = TipoFiltroCompromissoEnum.Futuros;

            else if (radioButtonPeriodo.Checked)
                FiltroSelecionado = TipoFiltroCompromissoEnum.Periodo;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonCompromissoEmUmPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPeriodo.Checked)
            {
                dateTimePickerDataInicio.Enabled = true;
                dateTimePickerFinal.Enabled = true;
            }
            else
            {
                dateTimePickerDataInicio.Enabled = false;
                dateTimePickerFinal.Enabled = false;
            }
        }

        private void dateTimePickerDataInicio_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
