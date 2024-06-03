using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;

        public Contato Contato
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNomeContato.Text = value.Nome;
                maskedTextTelefone.Text = value.Telefone.ToString();
                txtEmail.Text = value.Email;
                txtEmpresa.Text = value.Empresa;
                txtCargo.Text = value.Cargo;
            }
            get
            { 
                return contato; 
            } 
        }

        public TelaContatoForm()
        {
            InitializeComponent();
            txtId.Enabled = false;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNomeContato.Clear();
            maskedTextTelefone.Clear();
            txtEmail.Clear();
            txtEmpresa.Clear();
            txtCargo.Clear();
            txtNomeContato.Focus();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeContato.Text;
            string telefone = maskedTextTelefone.Text;
            string email = txtEmail.Text;
            string empresa = txtEmpresa.Text;
            string cargo = txtCargo.Text;

            contato = new Contato(nome, telefone, email, empresa, cargo);

            List<string> erros = contato.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
