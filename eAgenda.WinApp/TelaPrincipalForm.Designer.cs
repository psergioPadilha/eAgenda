namespace eAgenda.WinApp
{
    partial class TelaPrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contatosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compromissosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarefasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelPrincipal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblTipoCadastro = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlRegistros = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnFiltrar = new System.Windows.Forms.ToolStripButton();
            this.btnAdicionarItens = new System.Windows.Forms.ToolStripButton();
            this.btnConcluirItens = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1083, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosMenu
            // 
            this.cadastrosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contatosMenuItem,
            this.compromissosMenuItem,
            this.tarefasMenuItem});
            this.cadastrosMenu.Name = "cadastrosMenu";
            this.cadastrosMenu.Size = new System.Drawing.Size(109, 29);
            this.cadastrosMenu.Text = "Cadastros";
            // 
            // contatosMenuItem
            // 
            this.contatosMenuItem.Name = "contatosMenuItem";
            this.contatosMenuItem.Size = new System.Drawing.Size(222, 30);
            this.contatosMenuItem.Text = "Contatos";
            this.contatosMenuItem.Click += new System.EventHandler(this.contatosMenuItem_Click);
            // 
            // compromissosMenuItem
            // 
            this.compromissosMenuItem.Name = "compromissosMenuItem";
            this.compromissosMenuItem.Size = new System.Drawing.Size(222, 30);
            this.compromissosMenuItem.Text = "Compromissos";
            this.compromissosMenuItem.Click += new System.EventHandler(this.compromissosMenuItem_Click);
            // 
            // tarefasMenuItem
            // 
            this.tarefasMenuItem.Name = "tarefasMenuItem";
            this.tarefasMenuItem.Size = new System.Drawing.Size(222, 30);
            this.tarefasMenuItem.Text = "Tarefas";
            this.tarefasMenuItem.Click += new System.EventHandler(this.tarefasMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelPrincipal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 543);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1083, 31);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelPrincipal
            // 
            this.statusLabelPrincipal.Name = "statusLabelPrincipal";
            this.statusLabelPrincipal.Size = new System.Drawing.Size(225, 25);
            this.statusLabelPrincipal.Text = "Visualizando 0 registro(s)";
            this.statusLabelPrincipal.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdicionar,
            this.btnEditar,
            this.btnExcluir,
            this.btnFiltrar,
            this.lblTipoCadastro,
            this.btnAdicionarItens,
            this.btnConcluirItens,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1083, 65);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblTipoCadastro
            // 
            this.lblTipoCadastro.Enabled = false;
            this.lblTipoCadastro.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCadastro.Name = "lblTipoCadastro";
            this.lblTipoCadastro.Size = new System.Drawing.Size(0, 62);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 65);
            // 
            // pnlRegistros
            // 
            this.pnlRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistros.Location = new System.Drawing.Point(0, 98);
            this.pnlRegistros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRegistros.Name = "pnlRegistros";
            this.pnlRegistros.Size = new System.Drawing.Size(1083, 445);
            this.pnlRegistros.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.Image = global::eAgenda.WinApp.Properties.Resources.add_blue;
            this.btnAdicionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Padding = new System.Windows.Forms.Padding(5);
            this.btnAdicionar.Size = new System.Drawing.Size(62, 62);
            this.btnAdicionar.ToolTipText = "Adicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::eAgenda.WinApp.Properties.Resources.edit_blue;
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditar.Size = new System.Drawing.Size(62, 62);
            this.btnEditar.ToolTipText = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::eAgenda.WinApp.Properties.Resources.delete_blue_circle;
            this.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Size = new System.Drawing.Size(62, 62);
            this.btnExcluir.ToolTipText = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFiltrar.Enabled = false;
            this.btnFiltrar.Image = global::eAgenda.WinApp.Properties.Resources.filter;
            this.btnFiltrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Padding = new System.Windows.Forms.Padding(5);
            this.btnFiltrar.Size = new System.Drawing.Size(62, 62);
            this.btnFiltrar.ToolTipText = "Filtro";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnAdicionarItens
            // 
            this.btnAdicionarItens.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdicionarItens.Enabled = false;
            this.btnAdicionarItens.Image = global::eAgenda.WinApp.Properties.Resources.add;
            this.btnAdicionarItens.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdicionarItens.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionarItens.Name = "btnAdicionarItens";
            this.btnAdicionarItens.Padding = new System.Windows.Forms.Padding(5);
            this.btnAdicionarItens.Size = new System.Drawing.Size(62, 62);
            this.btnAdicionarItens.ToolTipText = "Adicionar Itens Tarefa";
            this.btnAdicionarItens.Click += new System.EventHandler(this.btnAdicionarItens_Click);
            // 
            // btnConcluirItens
            // 
            this.btnConcluirItens.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConcluirItens.Enabled = false;
            this.btnConcluirItens.Image = global::eAgenda.WinApp.Properties.Resources.dell;
            this.btnConcluirItens.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnConcluirItens.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConcluirItens.Name = "btnConcluirItens";
            this.btnConcluirItens.Padding = new System.Windows.Forms.Padding(5);
            this.btnConcluirItens.Size = new System.Drawing.Size(62, 62);
            this.btnConcluirItens.ToolTipText = "Adicionar Itens Tarefa";
            this.btnConcluirItens.Click += new System.EventHandler(this.btnConcluirItens_Click);
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 574);
            this.Controls.Add(this.pnlRegistros);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Agenda";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosMenu;
        private System.Windows.Forms.ToolStripMenuItem contatosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compromissosMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelPrincipal;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdicionar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.Panel pnlRegistros;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblTipoCadastro;
        private System.Windows.Forms.ToolStripButton btnFiltrar;
        private System.Windows.Forms.ToolStripMenuItem tarefasMenuItem;
        private System.Windows.Forms.ToolStripButton btnAdicionarItens;
        private System.Windows.Forms.ToolStripButton btnConcluirItens;
    }
}

