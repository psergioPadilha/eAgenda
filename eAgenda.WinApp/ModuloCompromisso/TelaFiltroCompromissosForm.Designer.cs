namespace eAgenda.WinApp.ModuloCompromisso
{
    partial class TelaFiltroCompromissosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFiltroCompromissosForm));
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBoxFiltro = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataInicio = new System.Windows.Forms.DateTimePicker();
            this.radioButtonPeriodo = new System.Windows.Forms.RadioButton();
            this.radioButtonFuturos = new System.Windows.Forms.RadioButton();
            this.radioButtonPassados = new System.Windows.Forms.RadioButton();
            this.radioButtonHoje = new System.Windows.Forms.RadioButton();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.groupBoxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltrar.Location = new System.Drawing.Point(97, 295);
            this.buttonFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(100, 39);
            this.buttonFiltrar.TabIndex = 13;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(203, 295);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 39);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // groupBoxFiltro
            // 
            this.groupBoxFiltro.Controls.Add(this.label1);
            this.groupBoxFiltro.Controls.Add(this.lblInicio);
            this.groupBoxFiltro.Controls.Add(this.dateTimePickerFinal);
            this.groupBoxFiltro.Controls.Add(this.dateTimePickerDataInicio);
            this.groupBoxFiltro.Controls.Add(this.radioButtonPeriodo);
            this.groupBoxFiltro.Controls.Add(this.radioButtonFuturos);
            this.groupBoxFiltro.Controls.Add(this.radioButtonPassados);
            this.groupBoxFiltro.Controls.Add(this.radioButtonHoje);
            this.groupBoxFiltro.Controls.Add(this.radioButtonTodos);
            this.groupBoxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltro.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFiltro.Name = "groupBoxFiltro";
            this.groupBoxFiltro.Size = new System.Drawing.Size(291, 268);
            this.groupBoxFiltro.TabIndex = 16;
            this.groupBoxFiltro.TabStop = false;
            this.groupBoxFiltro.Text = "Como deseja filtrar?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Término:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(31, 191);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(56, 22);
            this.lblInicio.TabIndex = 3;
            this.lblInicio.Text = "Início:";
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Checked = false;
            this.dateTimePickerFinal.CustomFormat = "DD/MM/YYYY";
            this.dateTimePickerFinal.Enabled = false;
            this.dateTimePickerFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFinal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerFinal.Location = new System.Drawing.Point(94, 224);
            this.dateTimePickerFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFinal.MinDate = new System.DateTime(2024, 5, 22, 0, 0, 0, 0);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(127, 28);
            this.dateTimePickerFinal.TabIndex = 2;
            this.dateTimePickerFinal.Value = new System.DateTime(2024, 5, 28, 0, 0, 0, 0);
            this.dateTimePickerFinal.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePickerDataInicio
            // 
            this.dateTimePickerDataInicio.Checked = false;
            this.dateTimePickerDataInicio.CustomFormat = "DD/MM/YYYY";
            this.dateTimePickerDataInicio.Enabled = false;
            this.dateTimePickerDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerDataInicio.Location = new System.Drawing.Point(94, 188);
            this.dateTimePickerDataInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDataInicio.MinDate = new System.DateTime(2024, 5, 22, 0, 0, 0, 0);
            this.dateTimePickerDataInicio.Name = "dateTimePickerDataInicio";
            this.dateTimePickerDataInicio.Size = new System.Drawing.Size(127, 28);
            this.dateTimePickerDataInicio.TabIndex = 2;
            this.dateTimePickerDataInicio.Value = new System.DateTime(2024, 5, 28, 0, 0, 0, 0);
            this.dateTimePickerDataInicio.ValueChanged += new System.EventHandler(this.dateTimePickerDataInicio_ValueChanged);
            // 
            // radioButtonPeriodo
            // 
            this.radioButtonPeriodo.AutoSize = true;
            this.radioButtonPeriodo.Location = new System.Drawing.Point(6, 155);
            this.radioButtonPeriodo.Name = "radioButtonPeriodo";
            this.radioButtonPeriodo.Size = new System.Drawing.Size(272, 26);
            this.radioButtonPeriodo.TabIndex = 0;
            this.radioButtonPeriodo.TabStop = true;
            this.radioButtonPeriodo.Text = "Compromissos em um período";
            this.radioButtonPeriodo.UseVisualStyleBackColor = true;
            this.radioButtonPeriodo.CheckedChanged += new System.EventHandler(this.radioButtonCompromissoEmUmPeriodo_CheckedChanged);
            // 
            // radioButtonFuturos
            // 
            this.radioButtonFuturos.AutoSize = true;
            this.radioButtonFuturos.Location = new System.Drawing.Point(6, 123);
            this.radioButtonFuturos.Name = "radioButtonFuturos";
            this.radioButtonFuturos.Size = new System.Drawing.Size(92, 26);
            this.radioButtonFuturos.TabIndex = 0;
            this.radioButtonFuturos.TabStop = true;
            this.radioButtonFuturos.Text = "Futuros";
            this.radioButtonFuturos.UseVisualStyleBackColor = true;
            // 
            // radioButtonPassados
            // 
            this.radioButtonPassados.AutoSize = true;
            this.radioButtonPassados.Location = new System.Drawing.Point(6, 91);
            this.radioButtonPassados.Name = "radioButtonPassados";
            this.radioButtonPassados.Size = new System.Drawing.Size(110, 26);
            this.radioButtonPassados.TabIndex = 0;
            this.radioButtonPassados.TabStop = true;
            this.radioButtonPassados.Text = "Passados";
            this.radioButtonPassados.UseVisualStyleBackColor = true;
            this.radioButtonPassados.CheckedChanged += new System.EventHandler(this.radioButtonPassados_CheckedChanged);
            // 
            // radioButtonHoje
            // 
            this.radioButtonHoje.AutoSize = true;
            this.radioButtonHoje.Location = new System.Drawing.Point(6, 59);
            this.radioButtonHoje.Name = "radioButtonHoje";
            this.radioButtonHoje.Size = new System.Drawing.Size(68, 26);
            this.radioButtonHoje.TabIndex = 0;
            this.radioButtonHoje.TabStop = true;
            this.radioButtonHoje.Text = "Hoje";
            this.radioButtonHoje.UseVisualStyleBackColor = true;
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(6, 27);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(82, 26);
            this.radioButtonTodos.TabIndex = 0;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroCompromissosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 350);
            this.Controls.Add(this.groupBoxFiltro);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.buttonCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaFiltroCompromissosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "e-Agenda - Filtro de compromissos";
            this.groupBoxFiltro.ResumeLayout(false);
            this.groupBoxFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.GroupBox groupBoxFiltro;
        private System.Windows.Forms.RadioButton radioButtonFuturos;
        private System.Windows.Forms.RadioButton radioButtonPassados;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonHoje;
        private System.Windows.Forms.RadioButton radioButtonPeriodo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
    }
}