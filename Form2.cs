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
    public partial class Authorization : Form
    {
        public List<Авторизация> users = new List<Авторизация>();

        public Authorization()
        {
            InitializeComponent();
            date.Text = $"Дата: {DateTime.Today.ToString("dd.MM.yyyy")}";
            fetchUsers();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = $"Время: {DateTime.Now.ToString("%H:%m:%s")}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool login = this.users.Exists(user =>
                user.Электронная_почта == email.Text &&
                user.Пароль == password.Text
            );

            MessageBox.Show(login.ToString());
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void fetchUsers()
        {
            using (Model1 db = new Model1())
            {
                this.users.Clear();

                foreach(Авторизация user in db.Авторизация)
                {
                    this.users.Add(user);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
