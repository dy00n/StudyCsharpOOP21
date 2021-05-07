using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandlerCheckApp
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            var result = txtUserID.Text + "\n" + txtPassword.Text;
            MessageBox.Show($"당신의 아이디와 패스워드는 {result}");
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mainform_Resize(object sender, EventArgs e)
        {

        }
    }
}
