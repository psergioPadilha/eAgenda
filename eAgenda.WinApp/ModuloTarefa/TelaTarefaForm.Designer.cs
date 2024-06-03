namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TelaTarefaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaTarefaForm));
            this.lblId = new System.Windows.Forms.Label();
            this.bttSalvar = new System.Windows.Forms.Button();
            this.cmbBoxPrioridade = new System.Windows.Forms.ComboBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.bttLimpar = new System.Windows.Forms.Button();
            this.lblPrioridade = new System.Windows.Forms.Label();
            this.txtBoxTitulo = new System.Windows.Forms.TextBox();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(77, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(32, 22);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            this.lblId.UseWaitCursor = true;
            // 
            // bttSalvar
            // 
            this.bttSalvar.AutoSize = true;
            this.bttSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bttSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSalvar.Location = new System.Drawing.Point(49, 125);
            this.bttSalvar.Name = "bttSalvar";
            this.bttSalvar.Size = new System.Drawing.Size(92, 32);
            this.bttSalvar.TabIndex = 2;
            this.bttSalvar.Text = "Salvar";
            this.bttSalvar.UseVisualStyleBackColor = true;
            this.bttSalvar.UseWaitCursor = true;
            this.bttSalvar.Click += new System.EventHandler(this.bttSalvar_Click);
            // 
            // cmbBoxPrioridade
            // 
            this.cmbBoxPrioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxPrioridade.FormattingEnabled = true;
            this.cmbBoxPrioridade.Location = new System.Drawing.Point(107, 80);
            this.cmbBoxPrioridade.Name = "cmbBoxPrioridade";
            this.cmbBoxPrioridade.Size = new System.Drawing.Size(230, 30);
            this.cmbBoxPrioridade.TabIndex = 1;
            this.cmbBoxPrioridade.UseWaitCursor = true;
            // 
            // txtBoxId
            // 
            this.txtBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxId.Location = new System.Drawing.Point(107, 12);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(100, 28);
            this.txtBoxId.TabIndex = 3;
            this.txtBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxId.UseWaitCursor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(49, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(60, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título:";
            this.lblTitulo.UseWaitCursor = true;
            // 
            // bttLimpar
            // 
            this.bttLimpar.AutoSize = true;
            this.bttLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLimpar.Location = new System.Drawing.Point(147, 125);
            this.bttLimpar.Name = "bttLimpar";
            this.bttLimpar.Size = new System.Drawing.Size(92, 32);
            this.bttLimpar.TabIndex = 3;
            this.bttLimpar.Text = "Limpar";
            this.bttLimpar.UseVisualStyleBackColor = true;
            this.bttLimpar.UseWaitCursor = true;
            this.bttLimpar.Click += new System.EventHandler(this.bttLimpar_Click);
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.AutoSize = true;
            this.lblPrioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridade.Location = new System.Drawing.Point(12, 84);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(97, 22);
            this.lblPrioridade.TabIndex = 0;
            this.lblPrioridade.Text = "Prioridade:";
            this.lblPrioridade.UseWaitCursor = true;
            // 
            // txtBoxTitulo
            // 
            this.txtBoxTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTitulo.Location = new System.Drawing.Point(107, 46);
            this.txtBoxTitulo.Name = "txtBoxTitulo";
            this.txtBoxTitulo.Size = new System.Drawing.Size(230, 28);
            this.txtBoxTitulo.TabIndex = 0;
            this.txtBoxTitulo.UseWaitCursor = true;
            // 
            // bttCancelar
            // 
            this.bttCancelar.AutoSize = true;
            this.bttCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancelar.Location = new System.Drawing.Point(245, 125);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(92, 32);
            this.bttCancelar.TabIndex = 4;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            this.bttCancelar.UseWaitCursor = true;
            // 
            // TelaTarefaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 173);
            this.Controls.Add(this.txtBoxTitulo);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.cmbBoxPrioridade);
            this.Controls.Add(this.bttCancelar);
            this.Controls.Add(this.bttLimpar);
            this.Controls.Add(this.bttSalvar);
            this.Controls.Add(this.lblPrioridade);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaTarefaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "e-Agenda - Cadastro de Tarefas";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button bttSalvar;
        private System.Windows.Forms.ComboBox cmbBoxPrioridade;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button bttLimpar;
        private System.Windows.Forms.Label lblPrioridade;
        private System.Windows.Forms.TextBox txtBoxTitulo;
        private System.Windows.Forms.Button bttCancelar;
    }
}