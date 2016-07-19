using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class ChangePassword : Form
    {
        Form1 mainForm;
        public ChangePassword(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != string.Empty)
            {

                mainForm.changepasswordbox.AppendText(textBox1.Text);

            }
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter) { OK_Click(null, null); }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter) { OK_Click(null, null); }
        }
    }
}
