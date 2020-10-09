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
    public partial class AdministradorForm : Form
    {
        public AdministradorForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ingresarBtn_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new IngresarForm());
        }

        private void AbrirFormularios(object formulario)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
                this.PanelPrincipal.Controls.RemoveAt(0);
            Form fh = formulario as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelPrincipal.Controls.Add(fh);
            this.PanelPrincipal.Tag = fh;
            fh.Show();
        }

        private void rutasTxt_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new VerRutasForm());
        }

        private void buscarTxt_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new BuscarForm());
        }

        private void CuentaTxt_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new CuentasForm());
        }
    }
}
