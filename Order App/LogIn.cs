using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order_App
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public delegate void sendValue(string name, string id, LogIn logIn);

        private void button1_Click(object sender, EventArgs e)
        {
            Database a = new Database();
            string username = a.authUser(IDuser.Text, Clave.Text);
            PrincipalMenu m = new PrincipalMenu();
            sendValue sendValue = new sendValue(m.receiveData);
            if (username != null)
            {
                sendValue(username, IDuser.Text, this);
                m.Show();
                this.Visible = false;
            }
            else MessageBox.Show("El usuario o la contraseña son incorrectas.");
        }
    }
}
