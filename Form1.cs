using System.Media;

namespace bengaleiro
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "Admin" || txt_pw.Text == "Admin")
            {
                MessageBox.Show("Bem vindo!");
                this.Hide();
                Segundo s2 = new Segundo();
                s2.Show();

            }
            else
            {
                //MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("Login invalido, tente novamente");


            }
        }
    }
}