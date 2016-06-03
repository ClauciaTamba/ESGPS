using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace The_Albert_Einstein_Hospital
{
    public partial class FormLogin : Form
    {
        Model1Container context = new Model1Container();
        public FormLogin()
        {
            InitializeComponent();
            
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            string usernameText = textBoxLogin.Text;
            string passwordText = textBoxPassword.Text;
            Utilizador utilizador =
           context.UtilizadorSet.Where(i => i.username == usernameText && i.password == passwordText).FirstOrDefault();
            if (utilizador != null)
            {
                FormRegistarutilizador form = new FormRegistarutilizador();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Utilizador não existe!");
            }
        }
    }
}
