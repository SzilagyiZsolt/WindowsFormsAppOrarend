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
    public partial class Form_Orarend : Form
    {
        public Form_Orarend()
        {
            InitializeComponent();
        }
        public void updateOraLista()
        {
            listBox_Nap1.Items.Clear();
            listBox_Nap1.Items.AddRange(Program.db.getOrak("hétfő").ToArray());
            listBox_Nap2.Items.Clear();
            listBox_Nap2.Items.AddRange(Program.db.getOrak("kedd").ToArray());
            listBox_Nap3.Items.Clear();
            listBox_Nap3.Items.AddRange(Program.db.getOrak("szerda").ToArray());
            listBox_Nap4.Items.Clear();
            listBox_Nap4.Items.AddRange(Program.db.getOrak("csütörtök").ToArray());
            listBox_Nap5.Items.Clear();
            listBox_Nap5.Items.AddRange(Program.db.getOrak("péntek").ToArray());
        }

        private void Form_Orarend_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Valóban ki akar lépni?", "kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                System.Windows.Forms.Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void listBox_Nap1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Nap1.SelectedIndex<0)
            {
                return;
            }
        }

        private void Form_Orarend_Load(object sender, EventArgs e)
        {
            updateOraLista();
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Ora formDelete = new Form_Ora("Törlés");
            formDelete.ShowDialog();
        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Ora formUpdate = new Form_Ora("Módosítás");
            formUpdate.ShowDialog();
        }

        private void beszúrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Ora formUpdate = new Form_Ora("Beszúrás");
            formUpdate.ShowDialog();
        }
    }
}
