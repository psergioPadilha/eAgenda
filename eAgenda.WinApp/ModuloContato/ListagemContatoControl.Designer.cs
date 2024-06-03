namespace eAgenda.WinApp.ModuloContato
{
    partial class ListagemContatoControl
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
            this.listContatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listContatos
            // 
            this.listContatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listContatos.FormattingEnabled = true;
            this.listContatos.ItemHeight = 25;
            this.listContatos.Location = new System.Drawing.Point(0, 0);
            this.listContatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listContatos.Name = "listContatos";
            this.listContatos.Size = new System.Drawing.Size(969, 616);
            this.listContatos.TabIndex = 0;
            // 
            // ListagemContatoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listContatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListagemContatoControl";
            this.Size = new System.Drawing.Size(969, 616);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listContatos;
    }
}
