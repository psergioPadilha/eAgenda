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
    public partial class TelaCompromissoForm : Form
    {
        private Compromisso compromisso;

        public Compromisso Compromisso 
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtAssunto.Text = value.Assunto.ToString();
                dateTimePickerDataCompromisso.Text = value.DataCompromisso.ToShortDateString();
                dateTimePickerHoraInicio.Text = value.HoraInicio.ToString();
                dateTimePickerHoraFim.Text = value.HoraTermino.ToString();
                
                checkBoxContato.Enabled = false;
                checkBoxContato.Checked = true;
                comboBoxContato.Items.Add(value.Contato.Nome);

                if (value.Modo == "PRESENCIAL")
                    radioButtonPresencial.Checked = true;
                else
                    radioButtonRemoto.Checked = true;

                txtLocal.Text = value.Local;
            }
            get 
            { 
                return compromisso; 
            } 
        }

        public TelaCompromissoForm()
        {
            InitializeComponent();
            txtId.Enabled = false;
        }

        public void CarregarContatos(List<Contato> listContatos)
        {
            comboBoxContato.Items.Clear();
            foreach (Contato contato in listContatos)
                comboBoxContato.Items.Add(contato.Nome);
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtAssunto.Clear();
            dateTimePickerDataCompromisso.Text = DateTime.Now.ToString();
            dateTimePickerHoraInicio.Text = string.Empty;
            dateTimePickerHoraFim.Text = string.Empty;
            checkBoxContato.Checked = false;
            radioButtonPresencial.Checked = true;
            radioButtonRemoto.Checked = false;
            txtLocal.Text= string.Empty;
            txtAssunto.Focus();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string assunto = txtAssunto.Text;
            DateTime data = dateTimePickerDataCompromisso.Value;
            TimeSpan horaInicial = dateTimePickerHoraInicio.Value.TimeOfDay;
            TimeSpan horaFinal = dateTimePickerHoraFim.Value.TimeOfDay;
            Contato contato = (Contato)comboBoxContato.SelectedItem;
            string local = txtLocal.Text;
            string modo;

            if (radioButtonPresencial.Checked)
                modo = "PRESENCIAL";
            else
                modo = "REMOTO";

            compromisso = new Compromisso(assunto, data, horaInicial, horaFinal, contato, local, modo);
        }

        private void txtPresencial_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxContato_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxContato.Checked)
                comboBoxContato.Enabled = true;
            else
            {
                comboBoxContato.SelectedItem = null;
                comboBoxContato.Enabled = false;
            }
        }

        private void radioButtonPresencial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblAssunto_Click(object sender, EventArgs e)
        {

        }

        private void txtRemoto_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonRemoto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxContato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
