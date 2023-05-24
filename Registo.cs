using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bengaleiro
{
    public partial class Registo : Form
    {
        public Registo()
        {
            InitializeComponent();
        }

        private void btn_exit_r_Click(object sender, EventArgs e)
        {
            this.Close();
            Segundo s2 = new Segundo();
            s2.Show();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
