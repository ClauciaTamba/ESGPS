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
    public partial class FormRegistarutilizador : Form
    {
        Model1Container context = new Model1Container();
        public FormRegistarutilizador()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string morada = textBoxmorada.Text;
            string nome = textBoxnomeCompleto.Text;
            DateTime dataNascimento = monthCalendar1.SelectionStart;
            string sexo = "";
            if (radioButtonSexo.Checked)
            {
                sexo = radioButtonSexo.Text;
            }else
            {
                sexo = radioButtonSexoF.Text;
            }
            string tipoUtilizador = comboBoxTipoUtilizador.SelectedText;
            Utilizador utilizador = new Utilizador();
            utilizador.username = username;
            utilizador.password = password;
            utilizador.morada = morada;
            utilizador.nome = nome;
            utilizador.dataNascimento = dataNascimento;
            utilizador.sexo = sexo;
            utilizador.tipoUtilizador = tipoUtilizador;
            List<Utilizador> lista = context.UtilizadorSet.ToList();
            utilizador.Id = lista.Count+1;
            context.UtilizadorSet.Add(utilizador);
            context.SaveChanges();
            MessageBox.Show("Utilizador criado!");
            textBoxUsername.Text= "";
             textBoxPassword.Text = "";
            textBoxmorada.Text = "";
            textBoxnomeCompleto.Text = "";
            textBoxCodigoPostal.Text = "";
            
        }

        private void registarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistarPaciente form = new FormRegistarPaciente();
            form.Show();
            this.Hide();
        }

        private void actualizarUtilizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisarPaciente form = new FormPesquisarPaciente();
            form.Show();
            this.Hide();
        }

        private void suspenderUtilizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void FormRegistarutilizador_Load(object sender, EventArgs e)
        {

        }
    }
}
