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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void ClientesBtn_Click(object sender, EventArgs e)
        {
            if (PanelBtns.Visible)
            {
                PanelBtns.Hide();
                PagosBtn.Location = new Point(3, 99);
                TotalBtn.Location = new Point(5, 129);
            } else
            {
                PanelBtns.Location = new Point(8, 92);
                PagosBtn.Location = new Point(4, 153);
                TotalBtn.Location = new Point(3, 183);
                PanelBtns.Show();
            }
        }
    }
}
