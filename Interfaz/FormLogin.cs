using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        int Contador = 0;

        private void EntrarBtn_Click(object sender, EventArgs e)
        {
            if (Contador <3)
            {
                if(UsuarioTxt.Text.Length==0 || ContrasenaTxt.Text.Length == 0)
                {
                    MessageBox.Show("Hay campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (UsuarioTxt.Text.Equals("RodEle") && ContrasenaTxt.Text.Equals("123"))
                    {
                        MessageBox.Show("Bienvenida, señora Elena", "Bienvenida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        AbrirFormPrincipal();
                        this.Hide();
                    } else
                    {
                        Contador++;
                    }
                }
            } else
            {
                MessageBox.Show("Número máximo de intentos alcanzados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void AbrirFormPrincipal()
        {
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }
    }
}
