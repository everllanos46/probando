using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialAG
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        int cont;

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void entrarBtn_Click(object sender, EventArgs e)
        {
            if (cont == 3)
            {
                MessageBox.Show("Máximos intentos alcanzados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            else
            {
                VerificarDatos();
            }

        }

        private void VerificarDatos()
        {
            if(usuarioTexto.Text.Equals("") || label3.Text.Equals(""))
            {
                MessageBox.Show("Hay campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (usuarioTexto.Text.Equals("ADMIN") && contraTexto.Text.Equals("123"))
                {
                    this.Hide();
                    AdministradorForm administrador = new AdministradorForm();
                    administrador.Show();
                }
                else if (usuarioTexto.Text.Equals("COBRADOR") && contraTexto.Text.Equals("321"))
                {
                    this.Hide();
                    CobradorForm cobrador = new CobradorForm();
                    cobrador.Show();
                }
                else if (usuarioTexto.Text.Equals("COBRADOR2") && contraTexto.Text.Equals("321"))
                {
                    this.Hide();
                    CobradorForm cobrador = new CobradorForm();
                    cobrador.Show();
                }
                else cont++;
            }
        }
    }
}
