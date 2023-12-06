using MySql.Data.MySqlClient;
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
    public partial class Form_Ora : Form
    {
        MySqlCommand command = null;
        string mod = null;
        Orak kivalasztottOra = null;
        public Form_Ora(string mod)
        {
            InitializeComponent();
            this.mod=mod;
        }

        private void Form_Ora_Load(object sender, EventArgs e)
        {
            if (Program.formOrarend.listBox_Nap1.SelectedIndex>=0)
            {
                kivalasztottOra = (Orak)Program.formOrarend.listBox_Nap1.SelectedItem;
            }
            else
            {
                return;
            }
            switch (this.mod)
            {
                case "Beszúrás":
                    this.Text = "Új óra beszúrása";
                    button_muvelet.Text = "Új óra beszúrása";
                    break;
                case "Módosítás":
                    this.Text = "Óra módosítása";
                    button_muvelet.Text = "Óra módosítása";
                    adatokBetolteseMezokbe();
                    break;
                case "Törlés":
                    this.Text = "Óra törlése";
                    button_muvelet.Text = "Óra törlése";
                    adatokBetolteseMezokbe();
                    break;
                default:
                    break;
            }
        }
        private void adatokBetolteseMezokbe()
        {
            textBox_oraid.Text = kivalasztottOra.oraid.ToString();
            textBox_oranev.Text = kivalasztottOra.tantargy;
            numericUpDown_sorszam.Value = kivalasztottOra.sorszam;
        }

        private void button_muvelet_Click(object sender, EventArgs e)
        {
            switch (this.mod)
            {
                case "Beszúrás":
                    Program.db.Beszuras(textBox_oranev.Text, numericUpDown_sorszam.Value);
                    MessageBox.Show("Sikeres beszúrás!");
                    Program.formOrarend.updateOraLista();
                    break;
                case "Módosítás":
                    Program.db.Modositas(textBox_oranev.Text,numericUpDown_sorszam.Value,int.Parse(textBox_oraid.Text.ToString()));
                    MessageBox.Show("Sikeres módosítás!");
                    Program.formOrarend.updateOraLista();
                    break;
                case "Törlés":
                    Program.db.Torles(int.Parse(textBox_oraid.Text.ToString()));
                    MessageBox.Show("Sikeres törlés!");
                    Program.formOrarend.updateOraLista();
                    break;
                default:
                    break;
            }
            
        }
    }
}
