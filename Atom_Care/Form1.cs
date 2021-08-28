using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using WMPLib;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Atom_Care
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            (new Atom_main()).Show();
            this.Hide();
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            string message = "Atoms are very pickey: they care about their energy levels, how stable they are and oubviously, they want to be happy (not really).\n" +
            "Your mission is to keep your pet atom safe and sound - feed him with photons and electrons, make sure he isn't sad and help him become a radioactive isotope!";

            string caption = "Info";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ;
        }
    }
}
