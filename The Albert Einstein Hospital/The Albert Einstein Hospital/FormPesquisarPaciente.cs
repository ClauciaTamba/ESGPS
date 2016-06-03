using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Albert_Einstein_Hospital
{
    public partial class FormPesquisarPaciente : Form
    {
        public FormPesquisarPaciente()
        {
            InitializeComponent();
            Model1Container context = new Model1Container();
            List<Paciente> pacientes = context.PacienteSet.ToList();

        }

        private void suspenderUtilizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void actualizarUtilizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistarPaciente form = new FormRegistarPaciente();
            form.Show();
            this.Hide();
        }

        private void registarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistarutilizador form = new FormRegistarutilizador();
            form.Show();
            this.Hide();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
