namespace The_Albert_Einstein_Hospital
{
    partial class FormRegistarPaciente
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
            this.labelNomeCompleto = new System.Windows.Forms.Label();
            this.labelMorada = new System.Windows.Forms.Label();
            this.labelCodigoPostal = new System.Windows.Forms.Label();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelMedicacao = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBoxnome = new System.Windows.Forms.TextBox();
            this.textBoxmorada = new System.Windows.Forms.TextBox();
            this.textBoxcodigoPostal = new System.Windows.Forms.TextBox();
            this.textBoxMedicacao = new System.Windows.Forms.TextBox();
            this.radioButtonSexoM = new System.Windows.Forms.RadioButton();
            this.radioButtonSexoF = new System.Windows.Forms.RadioButton();
            this.buttonCarregarExames = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarUtilizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suspenderUtilizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNomeCompleto
            // 
            this.labelNomeCompleto.AutoSize = true;
            this.labelNomeCompleto.Location = new System.Drawing.Point(58, 47);
            this.labelNomeCompleto.Name = "labelNomeCompleto";
            this.labelNomeCompleto.Size = new System.Drawing.Size(82, 13);
            this.labelNomeCompleto.TabIndex = 0;
            this.labelNomeCompleto.Text = "Nome Completo";
            // 
            // labelMorada
            // 
            this.labelMorada.AutoSize = true;
            this.labelMorada.Location = new System.Drawing.Point(68, 79);
            this.labelMorada.Name = "labelMorada";
            this.labelMorada.Size = new System.Drawing.Size(43, 13);
            this.labelMorada.TabIndex = 1;
            this.labelMorada.Text = "Morada";
            // 
            // labelCodigoPostal
            // 
            this.labelCodigoPostal.AutoSize = true;
            this.labelCodigoPostal.Location = new System.Drawing.Point(68, 129);
            this.labelCodigoPostal.Name = "labelCodigoPostal";
            this.labelCodigoPostal.Size = new System.Drawing.Size(72, 13);
            this.labelCodigoPostal.TabIndex = 2;
            this.labelCodigoPostal.Text = "Código Postal";
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(68, 230);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(104, 13);
            this.labelDataNascimento.TabIndex = 3;
            this.labelDataNascimento.Text = "Data de Nascimento";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(68, 159);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(31, 13);
            this.labelSexo.TabIndex = 4;
            this.labelSexo.Text = "Sexo";
            // 
            // labelMedicacao
            // 
            this.labelMedicacao.AutoSize = true;
            this.labelMedicacao.Location = new System.Drawing.Point(68, 195);
            this.labelMedicacao.Name = "labelMedicacao";
            this.labelMedicacao.Size = new System.Drawing.Size(60, 13);
            this.labelMedicacao.TabIndex = 5;
            this.labelMedicacao.Text = "Medicação";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(184, 224);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // textBoxnome
            // 
            this.textBoxnome.Location = new System.Drawing.Point(164, 47);
            this.textBoxnome.Name = "textBoxnome";
            this.textBoxnome.Size = new System.Drawing.Size(100, 20);
            this.textBoxnome.TabIndex = 7;
            // 
            // textBoxmorada
            // 
            this.textBoxmorada.Location = new System.Drawing.Point(164, 79);
            this.textBoxmorada.Name = "textBoxmorada";
            this.textBoxmorada.Size = new System.Drawing.Size(167, 20);
            this.textBoxmorada.TabIndex = 8;
            // 
            // textBoxcodigoPostal
            // 
            this.textBoxcodigoPostal.Location = new System.Drawing.Point(164, 122);
            this.textBoxcodigoPostal.Name = "textBoxcodigoPostal";
            this.textBoxcodigoPostal.Size = new System.Drawing.Size(100, 20);
            this.textBoxcodigoPostal.TabIndex = 9;
            // 
            // textBoxMedicacao
            // 
            this.textBoxMedicacao.Location = new System.Drawing.Point(184, 195);
            this.textBoxMedicacao.Name = "textBoxMedicacao";
            this.textBoxMedicacao.Size = new System.Drawing.Size(100, 20);
            this.textBoxMedicacao.TabIndex = 10;
            // 
            // radioButtonSexoM
            // 
            this.radioButtonSexoM.AutoSize = true;
            this.radioButtonSexoM.Location = new System.Drawing.Point(149, 157);
            this.radioButtonSexoM.Name = "radioButtonSexoM";
            this.radioButtonSexoM.Size = new System.Drawing.Size(73, 17);
            this.radioButtonSexoM.TabIndex = 11;
            this.radioButtonSexoM.TabStop = true;
            this.radioButtonSexoM.Text = "Masculino";
            this.radioButtonSexoM.UseVisualStyleBackColor = true;
            // 
            // radioButtonSexoF
            // 
            this.radioButtonSexoF.AutoSize = true;
            this.radioButtonSexoF.Location = new System.Drawing.Point(241, 157);
            this.radioButtonSexoF.Name = "radioButtonSexoF";
            this.radioButtonSexoF.Size = new System.Drawing.Size(67, 17);
            this.radioButtonSexoF.TabIndex = 12;
            this.radioButtonSexoF.TabStop = true;
            this.radioButtonSexoF.Text = "Feminino";
            this.radioButtonSexoF.UseVisualStyleBackColor = true;
            // 
            // buttonCarregarExames
            // 
            this.buttonCarregarExames.Location = new System.Drawing.Point(423, 369);
            this.buttonCarregarExames.Name = "buttonCarregarExames";
            this.buttonCarregarExames.Size = new System.Drawing.Size(134, 23);
            this.buttonCarregarExames.TabIndex = 13;
            this.buttonCarregarExames.Text = "Carregar Exames";
            this.buttonCarregarExames.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(587, 369);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 14;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registarPacienteToolStripMenuItem,
            this.actualizarUtilizadorToolStripMenuItem,
            this.suspenderUtilizadorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registarPacienteToolStripMenuItem
            // 
            this.registarPacienteToolStripMenuItem.Name = "registarPacienteToolStripMenuItem";
            this.registarPacienteToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.registarPacienteToolStripMenuItem.Text = "Registar Paciente";
            // 
            // actualizarUtilizadorToolStripMenuItem
            // 
            this.actualizarUtilizadorToolStripMenuItem.Name = "actualizarUtilizadorToolStripMenuItem";
            this.actualizarUtilizadorToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.actualizarUtilizadorToolStripMenuItem.Text = "Registar Utilizador";
            // 
            // suspenderUtilizadorToolStripMenuItem
            // 
            this.suspenderUtilizadorToolStripMenuItem.Name = "suspenderUtilizadorToolStripMenuItem";
            this.suspenderUtilizadorToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.suspenderUtilizadorToolStripMenuItem.Text = "Pesquisar Paciente";
            // 
            // FormRegistarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 421);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonCarregarExames);
            this.Controls.Add(this.radioButtonSexoF);
            this.Controls.Add(this.radioButtonSexoM);
            this.Controls.Add(this.textBoxMedicacao);
            this.Controls.Add(this.textBoxcodigoPostal);
            this.Controls.Add(this.textBoxmorada);
            this.Controls.Add(this.textBoxnome);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.labelMedicacao);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.labelCodigoPostal);
            this.Controls.Add(this.labelMorada);
            this.Controls.Add(this.labelNomeCompleto);
            this.Name = "FormRegistarPaciente";
            this.Text = "FormRegistarPaciente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeCompleto;
        private System.Windows.Forms.Label labelMorada;
        private System.Windows.Forms.Label labelCodigoPostal;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelMedicacao;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBoxnome;
        private System.Windows.Forms.TextBox textBoxmorada;
        private System.Windows.Forms.TextBox textBoxcodigoPostal;
        private System.Windows.Forms.TextBox textBoxMedicacao;
        private System.Windows.Forms.RadioButton radioButtonSexoM;
        private System.Windows.Forms.RadioButton radioButtonSexoF;
        private System.Windows.Forms.Button buttonCarregarExames;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarUtilizadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suspenderUtilizadorToolStripMenuItem;
    }
}