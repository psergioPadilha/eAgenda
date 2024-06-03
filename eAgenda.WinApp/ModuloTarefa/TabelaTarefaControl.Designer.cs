namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TabelaTarefaControl
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
            this.listTarefas = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listTarefas
            // 
            this.listTarefas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTarefas.HideSelection = false;
            this.listTarefas.Location = new System.Drawing.Point(0, 0);
            this.listTarefas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listTarefas.Name = "listTarefas";
            this.listTarefas.Size = new System.Drawing.Size(965, 488);
            this.listTarefas.TabIndex = 0;
            this.listTarefas.UseCompatibleStateImageBehavior = false;
            // 
            // TabelaTarefaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listTarefas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TabelaTarefaControl";
            this.Size = new System.Drawing.Size(965, 488);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listTarefas;
    }
}
