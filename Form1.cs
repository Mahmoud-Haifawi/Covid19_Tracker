using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace termProject
{
    public partial class home_screen : Form
    {
       
            public home_screen()
        {
            InitializeComponent();
        }

        private void personShot1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vaccineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mainScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newPersonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
           this.Hide();
            f.Show();
            
        }

        private void personsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search f2 = new Search();
            this.Hide();
            f2.Show();
        }
    }
}
