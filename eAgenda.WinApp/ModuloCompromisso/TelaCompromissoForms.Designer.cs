namespace eAgenda.WinApp.ModuloCompromisso
{
    partial class TelaCompromissoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCompromissoForm));
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblDataCompromisso = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblTermino = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.dateTimePickerDataCompromisso = new System.Windows.Forms.DateTimePicker();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.checkBoxContato = new System.Windows.Forms.CheckBox();
            this.comboBoxContato = new System.Windows.Forms.ComboBox();
            this.radioButtonRemoto = new System.Windows.Forms.RadioButton();
            this.radioButtonPresencial = new System.Windows.Forms.RadioButton();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.dateTimePickerHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHoraFim = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(59, 24);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(32, 22);
            this.lblId.TabIndex = 20;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(108, 21);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(157, 28);
            this.txtId.TabIndex = 20;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDataCompromisso
            // 
            this.lblDataCompromisso.AutoSize = true;
            this.lblDataCompromisso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCompromisso.Location = new System.Drawing.Point(37, 98);
            this.lblDataCompromisso.Name = "lblDataCompromisso";
            this.lblDataCompromisso.Size = new System.Drawing.Size(53, 22);
            this.lblDataCompromisso.TabIndex = 20;
            this.lblDataCompromisso.Text = "Data:";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(247, 98);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(56, 22);
            this.lblInicio.TabIndex = 20;
            this.lblInicio.Text = "Início:";
            // 
            // lblTermino
            // 
            this.lblTermino.AutoSize = true;
            this.lblTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermino.Location = new System.Drawing.Point(407, 98);
            this.lblTermino.Name = "lblTermino";
            this.lblTermino.Size = new System.Drawing.Size(81, 22);
            this.lblTermino.TabIndex = 20;
            this.lblTermino.Text = "Término:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(480, 334);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 39);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(374, 334);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(100, 39);
            this.buttonLimpar.TabIndex = 10;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(268, 334);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(100, 39);
            this.buttonSalvar.TabIndex = 9;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // dateTimePickerDataCompromisso
            // 
            this.dateTimePickerDataCompromisso.Checked = false;
            this.dateTimePickerDataCompromisso.CustomFormat = "DD/MM/YYYY";
            this.dateTimePickerDataCompromisso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDataCompromisso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataCompromisso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerDataCompromisso.Location = new System.Drawing.Point(108, 95);
            this.dateTimePickerDataCompromisso.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDataCompromisso.MinDate = new System.DateTime(2024, 5, 22, 0, 0, 0, 0);
            this.dateTimePickerDataCompromisso.Name = "dateTimePickerDataCompromisso";
            this.dateTimePickerDataCompromisso.Size = new System.Drawing.Size(127, 28);
            this.dateTimePickerDataCompromisso.TabIndex = 1;
            this.dateTimePickerDataCompromisso.Value = new System.DateTime(2024, 5, 28, 0, 0, 0, 0);
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssunto.Location = new System.Drawing.Point(6, 60);
            this.lblAssunto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(80, 22);
            this.lblAssunto.TabIndex = 20;
            this.lblAssunto.Text = "Assunto:";
            this.lblAssunto.Click += new System.EventHandler(this.lblAssunto_Click);
            // 
            // txtAssunto
            // 
            this.txtAssunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssunto.Location = new System.Drawing.Point(108, 57);
            this.txtAssunto.Margin = new System.Windows.Forms.Padding(4);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(472, 28);
            this.txtAssunto.TabIndex = 0;
            // 
            // checkBoxContato
            // 
            this.checkBoxContato.AutoSize = true;
            this.checkBoxContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxContato.Location = new System.Drawing.Point(108, 133);
            this.checkBoxContato.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxContato.Name = "checkBoxContato";
            this.checkBoxContato.Size = new System.Drawing.Size(399, 26);
            this.checkBoxContato.TabIndex = 4;
            this.checkBoxContato.Text = "Deseja marcar um contato nesteCompromisso";
            this.checkBoxContato.UseVisualStyleBackColor = true;
            this.checkBoxContato.CheckedChanged += new System.EventHandler(this.checkBoxContato_CheckedChanged);
            // 
            // comboBoxContato
            // 
            this.comboBoxContato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContato.Enabled = false;
            this.comboBoxContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxContato.FormattingEnabled = true;
            this.comboBoxContato.Location = new System.Drawing.Point(108, 170);
            this.comboBoxContato.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxContato.MaxDropDownItems = 5;
            this.comboBoxContato.Name = "comboBoxContato";
            this.comboBoxContato.Size = new System.Drawing.Size(472, 30);
            this.comboBoxContato.TabIndex = 5;
            this.comboBoxContato.SelectedIndexChanged += new System.EventHandler(this.comboBoxContato_SelectedIndexChanged);
            // 
            // radioButtonRemoto
            // 
            this.radioButtonRemoto.AutoSize = true;
            this.radioButtonRemoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRemoto.Location = new System.Drawing.Point(204, 32);
            this.radioButtonRemoto.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonRemoto.Name = "radioButtonRemoto";
            this.radioButtonRemoto.Size = new System.Drawing.Size(93, 26);
            this.radioButtonRemoto.TabIndex = 7;
            this.radioButtonRemoto.Text = "Remoto";
            this.radioButtonRemoto.UseVisualStyleBackColor = true;
            this.radioButtonRemoto.CheckedChanged += new System.EventHandler(this.radioButtonRemoto_CheckedChanged);
            // 
            // radioButtonPresencial
            // 
            this.radioButtonPresencial.AutoSize = true;
            this.radioButtonPresencial.Checked = true;
            this.radioButtonPresencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPresencial.Location = new System.Drawing.Point(71, 32);
            this.radioButtonPresencial.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonPresencial.Name = "radioButtonPresencial";
            this.radioButtonPresencial.Size = new System.Drawing.Size(115, 26);
            this.radioButtonPresencial.TabIndex = 6;
            this.radioButtonPresencial.TabStop = true;
            this.radioButtonPresencial.Text = "Presencial";
            this.radioButtonPresencial.UseVisualStyleBackColor = true;
            this.radioButtonPresencial.CheckedChanged += new System.EventHandler(this.radioButtonPresencial_CheckedChanged);
            // 
            // txtLocal
            // 
            this.txtLocal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocal.Location = new System.Drawing.Point(71, 66);
            this.txtLocal.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(394, 28);
            this.txtLocal.TabIndex = 8;
            this.txtLocal.TextChanged += new System.EventHandler(this.txtPresencial_TextChanged);
            // 
            // dateTimePickerHoraInicio
            // 
            this.dateTimePickerHoraInicio.Checked = false;
            this.dateTimePickerHoraInicio.CustomFormat = "HH:mm";
            this.dateTimePickerHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHoraInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerHoraInicio.Location = new System.Drawing.Point(312, 95);
            this.dateTimePickerHoraInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerHoraInicio.MinDate = new System.DateTime(2024, 5, 22, 0, 0, 0, 0);
            this.dateTimePickerHoraInicio.Name = "dateTimePickerHoraInicio";
            this.dateTimePickerHoraInicio.ShowUpDown = true;
            this.dateTimePickerHoraInicio.Size = new System.Drawing.Size(81, 28);
            this.dateTimePickerHoraInicio.TabIndex = 2;
            // 
            // dateTimePickerHoraFim
            // 
            this.dateTimePickerHoraFim.Checked = false;
            this.dateTimePickerHoraFim.CustomFormat = "HH:mm";
            this.dateTimePickerHoraFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerHoraFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHoraFim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerHoraFim.Location = new System.Drawing.Point(499, 95);
            this.dateTimePickerHoraFim.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerHoraFim.MinDate = new System.DateTime(2024, 5, 22, 0, 0, 0, 0);
            this.dateTimePickerHoraFim.Name = "dateTimePickerHoraFim";
            this.dateTimePickerHoraFim.ShowUpDown = true;
            this.dateTimePickerHoraFim.Size = new System.Drawing.Size(81, 28);
            this.dateTimePickerHoraFim.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLocal);
            this.groupBox1.Controls.Add(this.radioButtonRemoto);
            this.groupBox1.Controls.Add(this.radioButtonPresencial);
            this.groupBox1.Controls.Add(this.txtLocal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(108, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 110);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Localização:";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(6, 69);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(58, 22);
            this.lblLocal.TabIndex = 21;
            this.lblLocal.Text = "Local:";
            // 
            // TelaCompromissoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePickerHoraFim);
            this.Controls.Add(this.dateTimePickerHoraInicio);
            this.Controls.Add(this.comboBoxContato);
            this.Controls.Add(this.checkBoxContato);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.dateTimePickerDataCompromisso);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.lblTermino);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.lblDataCompromisso);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCompromissoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Agenda - Cadastro de Compromissos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblDataCompromisso;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblTermino;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataCompromisso;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.CheckBox checkBoxContato;
        private System.Windows.Forms.ComboBox comboBoxContato;
        private System.Windows.Forms.RadioButton radioButtonRemoto;
        private System.Windows.Forms.RadioButton radioButtonPresencial;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraFim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLocal;
    }
}