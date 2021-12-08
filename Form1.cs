using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Machine_Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            date.Text = $"Дата: {DateTime.Today.ToString("dd.MM.yyyy")}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void info_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = $"Время: {DateTime.Now.ToString("%H:%m:%s")}";
        }

        private void login_Click(object sender, EventArgs e)
        {
            Authorization form = new Authorization();
            this.Hide();
            form.Show();
        }
    }
}
