using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsThreadApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {     
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10000;
            Thread th = new Thread(() => { });
            for (int i = 0; i <= 10000; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(50); //50ms 걸리는 처리할 일이 있음
            }
            // 스레드로 분리 윈폼의 화면스레드, 처리스레드 분리
            
            th.IsBackground = true; //백그라운드로 실행할지 여부
            th.Start();
        }
    }
}
