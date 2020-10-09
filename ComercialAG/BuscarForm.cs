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
    public partial class BuscarForm : Form
    {
        public BuscarForm()
        {
            InitializeComponent();
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            ModificarForm mf = new ModificarForm();
            mf.Show();
        }
    }
}
