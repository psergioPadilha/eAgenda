using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinApp.Compartilhado
{
    public static class DataGridViewExtensions
    {
        #region Configuração para deixar as linhas da tabela com cores alternadas
        public static void ConfigurarGridZebrado(this DataGridView grid)
        {
            Font font = new Font("Segoe UI", 9.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            
            DataGridViewCellStyle linhaEcura = new DataGridViewCellStyle
            {
                BackColor = Color.LightGray,
                Font = font,
                ForeColor = Color.Black,
                SelectionBackColor = Color.LightYellow,
                SelectionForeColor = Color.Black
            };

            grid.AlternatingRowsDefaultCellStyle = linhaEcura;

            DataGridViewCellStyle linhaClara = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                Font = font,
                ForeColor = Color.Black,
                SelectionBackColor = Color.LightYellow,
                SelectionForeColor = Color.Black
            };

            grid.RowsDefaultCellStyle = linhaClara;
        }
        #endregion

        #region Configuração do grid da tabela
        public static void ConfiguraGrid(this DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.BorderStyle = BorderStyle.None;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.MultiSelect = false;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoGenerateColumns = false;
            grid.AllowUserToResizeRows = false;
            grid.RowHeadersVisible = false;
        }
        #endregion

        #region Capta a linha que está sendo selecionada dentro do grid da tabela
        public static int SelecionarId(this DataGridView grid)
        {
            if (grid.SelectedRows.Count == 0)
                return -1;

            object valorSelecionado = grid.SelectedRows[0].Cells[0].Value;

            if(valorSelecionado == null)
                return -1;

            return (int)valorSelecionado;
        }
        #endregion
    }
}
