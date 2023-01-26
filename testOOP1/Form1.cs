using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testOOP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string jmeno;
        private void panel1_Click(object sender, EventArgs e)
        {
            Herni_postava player = new Herni_postava(jmeno);
            this.Cursor = new Cursor(Cursor.Current.Handle); //program nefunguje.... 
            player.zmena_pozice(Cursor.Position.X, Cursor.Position.Y);

        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Zadejte jméno!");
            }
            else
            {
                jmeno = textBox1.Text;
            }
        }
    }
}
