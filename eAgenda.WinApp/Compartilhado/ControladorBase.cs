using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgenda.WinApp.ModuloContato;

namespace eAgenda.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string TipoCadastro { get; }

        public abstract string ToolTipAdicionar { get; }
        public abstract string ToolTipEditar { get; }
        public abstract string ToolTipExcluir { get; }

        public abstract UserControl ObterListagem();

        internal abstract void Adicionar();

        internal abstract void Editar();

        internal abstract void Excluir();
    }
}
