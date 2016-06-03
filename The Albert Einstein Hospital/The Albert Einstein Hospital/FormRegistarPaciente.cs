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
    public partial class FormRegistarPaciente : Form
    {
        Model1Container context = new Model1Container();
        public FormRegistarPaciente()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
           
            string morada = textBoxmorada.Text;
            string nome = textBoxnome.Text;
            string medicacao = textBoxMedicacao.Text;
            DateTime dataNascimento = monthCalendar1.SelectionStart;
            
            string codigoPostal = textBoxcodigoPostal.Text;
            string sexo = "";
            if (radioButtonSexoM.Checked)
            {
                sexo = radioButtonSexoM.Text;
            }
            else
            {
                sexo = radioButtonSexoF.Text;
            }
           
            Paciente utilizador = new Paciente();
           
            utilizador.morada = morada;
            utilizador.nome = nome;
            utilizador.dataNascimento = dataNascimento;
            utilizador.sexo = sexo;
            utilizador.medicacao = medicacao;
            utilizador.codigoPostal = codigoPostal;
            List<Paciente> lista = context.PacienteSet.ToList();
            utilizador.Id = lista.Count + 1;
            context.PacienteSet.Add(utilizador);
            context.SaveChanges();
            MessageBox.Show("paciente criado!");
            
            textBoxmorada.Text = "";
            textBoxnome.Text = "";
            textBoxcodigoPostal.Text = "";
            textBoxMedicacao.Text = "";
         
           
        }

        private void buttonCarregarExames_Click(object sender, EventArgs e)
        {

        }
    }
}
