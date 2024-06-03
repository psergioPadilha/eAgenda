namespace eAgenda.WinApp.ModuloCompromisso
{
    partial class ListagemCompromissoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listCompromissos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listCompromissos
            // 
            this.listCompromissos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCompromissos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCompromissos.FormattingEnabled = true;
            this.listCompromissos.ItemHeight = 25;
            this.listCompromissos.Location = new System.Drawing.Point(0, 0);
            this.listCompromissos.Name = "listCompromissos";
            this.listCompromissos.Size = new System.Drawing.Size(434, 331);
            this.listCompromissos.TabIndex = 0;
            // 
            // TabelaCompromissoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listCompromissos);
            this.Name = "TabelaCompromissoControl";
            this.Size = new System.Drawing.Size(434, 331);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listCompromissos;
    }
}
