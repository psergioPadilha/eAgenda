namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TelaAtualizacaoItensTarefa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAtualizacaoItensTarefa));
            this.lblTarefa = new System.Windows.Forms.Label();
            this.checkedListBoxItensTarefa = new System.Windows.Forms.CheckedListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTituloTarefa = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTarefa
            // 
            this.lblTarefa.AutoSize = true;
            this.lblTarefa.Location = new System.Drawing.Point(12, 21);
            this.lblTarefa.Name = "lblTarefa";
            this.lblTarefa.Size = new System.Drawing.Size(68, 22);
            this.lblTarefa.TabIndex = 0;
            this.lblTarefa.Text = "Tarefa:";
            // 
            // checkedListBoxItensTarefa
            // 
            this.checkedListBoxItensTarefa.FormattingEnabled = true;
            this.checkedListBoxItensTarefa.Location = new System.Drawing.Point(12, 58);
            this.checkedListBoxItensTarefa.Name = "checkedListBoxItensTarefa";
            this.checkedListBoxItensTarefa.Size = new System.Drawing.Size(353, 234);
            this.checkedListBoxItensTarefa.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(273, 311);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 32);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblTituloTarefa
            // 
            this.lblTituloTarefa.AutoSize = true;
            this.lblTituloTarefa.Location = new System.Drawing.Point(86, 21);
            this.lblTituloTarefa.Name = "lblTituloTarefa";
            this.lblTituloTarefa.Size = new System.Drawing.Size(123, 22);
            this.lblTituloTarefa.TabIndex = 0;
            this.lblTituloTarefa.Text = "[Título Tarefa]";
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(175, 311);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(92, 32);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // TelaAtualizacaoItensTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 357);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.checkedListBoxItensTarefa);
            this.Controls.Add(this.lblTituloTarefa);
            this.Controls.Add(this.lblTarefa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaAtualizacaoItensTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "e-Agenda - Atualização de Itens de Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTarefa;
        private System.Windows.Forms.CheckedListBox checkedListBoxItensTarefa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTituloTarefa;
        private System.Windows.Forms.Button btnSalvar;
    }
}