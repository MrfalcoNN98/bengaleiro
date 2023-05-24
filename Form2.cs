using System;
using System.Collections;
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
    public partial class Segundo : Form
    {
        public Segundo()
        {
            InitializeComponent();
        }

        private void Segundo_Load(object sender, EventArgs e)
        {

        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            this.Close();

            Registo r1 = new Registo();
            r1.Show();
        }

        private void btn_ex_Click(object sender, EventArgs e)
        {
            this.Close ();
            Saida s1 = new Saida();
            s1.Show();
        }
    }
}
