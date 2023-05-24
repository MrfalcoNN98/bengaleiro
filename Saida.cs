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
    public partial class Saida : Form
    {
        public Saida()
        {
            InitializeComponent();
        }

        private void btn_exit_s_Click(object sender, EventArgs e)
        {
            this.Close();
            Segundo s2 = new Segundo();
            s2.Show();
        }
    }
}
