using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOrarend
{
    public partial class Belepes : Form
    {
        public Belepes()
        {
            InitializeComponent();
        }

        private void button_login_Click_1(object sender, EventArgs e)
        {
            if (Program.db.validUser(textBox_nev.Text, textBox_jelszo.Text)>=0)
            {
                Program.formOrarend.Show();
            }
        }
    }
}
