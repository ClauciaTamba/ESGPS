namespace The_Albert_Einstein_Hospital
{
    partial class FormPesquisarPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>w
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
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.listBoxPesquisar = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarUtilizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suspenderUtilizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelNomePaciente = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Location = new System.Drawing.Point(128, 44);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(100, 20);
            this.textBoxPesquisar.TabIndex = 0;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(47, 104);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 1;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // listBoxPesquisar
            // 
            this.listBoxPesquisar.FormattingEnabled = true;
            this.listBoxPesquisar.Location = new System.Drawing.Point(305, 44);
            this.listBoxPesquisar.Name = "listBoxPesquisar";
            this.listBoxPesquisar.Size = new System.Drawing.Size(293, 199);
            this.listBoxPesquisar.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registarPacienteToolStripMenuItem,
            this.actualizarUtilizadorToolStripMenuItem,
            this.suspenderUtilizadorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registarPacienteToolStripMenuItem
            // 
            this.registarPacienteToolStripMenuItem.Name = "registarPacienteToolStripMenuItem";
            this.registarPacienteToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.registarPacienteToolStripMenuItem.Text = "Registar Paciente";
            this.registarPacienteToolStripMenuItem.Click += new System.EventHandler(this.registarPacienteToolStripMenuItem_Click);
            // 
            // actualizarUtilizadorToolStripMenuItem
            // 
            this.actualizarUtilizadorToolStripMenuItem.Name = "actualizarUtilizadorToolStripMenuItem";
            this.actualizarUtilizadorToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.actualizarUtilizadorToolStripMenuItem.Text = "Registar Utilizador";
            this.actualizarUtilizadorToolStripMenuItem.Click += new System.EventHandler(this.actualizarUtilizadorToolStripMenuItem_Click);
            // 
            // suspenderUtilizadorToolStripMenuItem
            // 
            this.suspenderUtilizadorToolStripMenuItem.Name = "suspenderUtilizadorToolStripMenuItem";
            this.suspenderUtilizadorToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.suspenderUtilizadorToolStripMenuItem.Text = "Pesquisar Paciente";
            this.suspenderUtilizadorToolStripMenuItem.Click += new System.EventHandler(this.suspenderUtilizadorToolStripMenuItem_Click);
            // 
            // labelNomePaciente
            // 
            this.labelNomePaciente.AutoSize = true;
            this.labelNomePaciente.Location = new System.Drawing.Point(37, 44);
            this.labelNomePaciente.Name = "labelNomePaciente";
            this.labelNomePaciente.Size = new System.Drawing.Size(85, 13);
            this.labelNomePaciente.TabIndex = 4;
            this.labelNomePaciente.Text = "Nome Pacientes";
            // 
            // FormPesquisarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 374);
            this.Controls.Add(this.labelNomePaciente);
            this.Controls.Add(this.listBoxPesquisar);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.textBoxPesquisar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPesquisarPaciente";
            this.Text = "FormPesquisarPaciente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.ListBox listBoxPesquisar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarUtilizadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suspenderUtilizadorToolStripMenuItem;
        private System.Windows.Forms.Label labelNomePaciente;
    }
}