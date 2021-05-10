using NLog;
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
        static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public Mainform()
        {
            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {

            var result = txtUserID.Text + "\n" + txtPassword.Text;
            MessageBox.Show($"당신의 아이디와 패스워드는 {result}");

            try
            {
                var val = txtPassword.Text.Substring(3, 7); //문자열 자르는 메서드
                MessageBox.Show($"{val}");
                logger.Info("제대로 완료");
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외발생, 관리자에게 문의 요망");
                logger.Error("예외발생, 관리자에게 문의 요망");
                logger.Error($"{ex}");    
            } 
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mainform_Resize(object sender, EventArgs e)
        {

        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            //초기호ㅏ...
            logger.Info("Mainform 로드");
        }
    }
}
