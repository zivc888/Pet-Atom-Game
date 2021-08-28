using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atom_Care
{
    public partial class market : Form
    {
        public market()
        {
            InitializeComponent();
        }

        private void GammaRaysToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Atom_main.my_inventory.CheckGammaRay())
            {
                string message = "You already own this";
                string caption = "Double";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
            else if (Atom_main.my_atom.GetMoney() < 250)
            {
                string message = "Not enough money!";
                string caption = "You are poor";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                Atom_main.my_atom.UpdateMoney(-250);
                Atom_main.my_inventory.BuyGammaRays();
            }
        }

        private void PhotonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Atom_main.my_atom.GetMoney() < 50)
            {
                string message = "Not enough money!";
                string caption = "You are poor";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                Atom_main.my_atom.UpdateMoney(-50);
                Atom_main.my_inventory.BuyPhoton();
            }
        }

        private void ElectronsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Atom_main.my_atom.GetMoney() < 100)
            {
                string message = "Not enough money!";
                string caption = "You are poor";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                Atom_main.my_atom.UpdateMoney(-100);
                Atom_main.my_inventory.BuyElectron();
            }
        }

        private void market_timer_Tick(object sender, EventArgs e)
        {
            lblmoney_in_market.Text = Atom_main.my_atom.GetMoney() + "";
        }

        private void RadioactivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Atom_main.my_inventory.CheckRadioactivity())
            {
                string message = "You already own this";
                string caption = "Double";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
            else if (Atom_main.my_atom.GetMoney() < 500)
            {
                string message = "Not enough money!";
                string caption = "You are poor";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                Atom_main.my_atom.UpdateMoney(-500);
                Atom_main.my_inventory.BuyRadioactivity();
            }
        }
    }
}