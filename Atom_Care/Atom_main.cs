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
    public partial class Atom_main : Form
    {
        public static Atom my_atom;
        public static Inventory my_inventory;
        private static Random rnd = new Random();

        private int color_press = -1, wait_for_money = 0, tickles = 0, gamma_ray_cooldown = 0, touchmax = rnd.Next(1, 5), face_swap_cooldown = 0;
        private bool gamma_is_ready = true, continue_decision = false;

        public Atom_main()
        {
            InitializeComponent();
            my_atom = new Atom();
            my_inventory = new Inventory();
        }

        private void btnexit_Click(object sender, EventArgs e) //exits the program (how surprising!) 
        {
            Application.Exit();
        }

        private void main_timer_Tick(object sender, EventArgs e) //kind of the "main" function in this form 
        {
            //labels update
            lblenergy.Text = my_atom.GetEnergy() + "%";
            lblhappiness.Text = my_atom.GetHappines() + "%";
            lbllevel.Text = "Level: " + my_atom.GetLevel();
            lblmoney.Text = my_atom.GetMoney() + "";
            lblxp.Text = my_atom.GetXP() + " / " + my_atom.GetXPForNextLevel();

            lblelectrons.Text = "electrons: " + my_inventory.GetNumberOfElectrons();
            lblphoton.Text = "photons: " + my_inventory.GetNumberOfPhotons();
            if (!my_inventory.CheckGammaRay())
            {
                lblgamma_ray.Text = "unavailable";
            }
            else if (gamma_is_ready)
            {
                lblgamma_ray.Text = "ready";
            }
            else
            {
                lblgamma_ray.Text = "cooldown: " + (30 - gamma_ray_cooldown);
            }


            //updating intervals of timers
            time_is_money.Interval = (int)(((50000) * (1 + 0.05 * my_atom.GetLevel())) / (Math.Abs(my_atom.GetEnergy()) + 1));
            happy_timer.Interval = 5000 * (my_atom.GetLevel() + 1);
            energy_timer.Interval = 1000 * (my_atom.GetLevel() + 1);
            if (my_inventory.CheckRadioactivity())
            {
                radioactive_timer.Enabled = true;
            }

            //reacting to low happiness and energy and controling the atom's face
            if (my_atom.GetHappines() < 35 || my_atom.GetEnergy() < 35)
            {
                picatom.Image = Properties.Resources.atom_eyes3;
            }
            if (my_atom.GetHappines() <= 0)
            {
                TimersControl(false);

                string message = "Look what you have done! The little atom died from agony - all because of you.\nShame on you.\n\n" +
                "Press Yes to replay or No to close the game";
                string caption = "Death from agony :(";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    (new Atom_main()).Show();
                    this.Close();
                }
                else if (result == System.Windows.Forms.DialogResult.No)
                {
                    Application.Exit();
                }
            }
            if (my_atom.GetEnergy() <= 0)
            {
                TimersControl(false);

                string message = "Look what you have done! The little atom died from exhastion - all because of you.\nShame on you.\n\n" +
                "Press Yes to replay or No to close the game";
                string caption = "Death from exhastion :(";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    (new Atom_main()).Show();
                    this.Close();
                }
                else if (result == System.Windows.Forms.DialogResult.No)
                {
                    Application.Exit();
                }
            }

            if(my_atom.GetHappines() >= 35 && my_atom.GetEnergy() >= 35 && face_swap_cooldown!=0)
            {
                if (my_atom.GetLevel() <= 2)
                {
                    picatom.Image = Properties.Resources.atom_eyes4;
                }
                else
                {
                    picatom.Image = Properties.Resources.atom_eyes1;
                }
            }

            //win
            if (my_atom.GetLevel() == 3 && !continue_decision)
            {
                picatom.Image = Properties.Resources.atom_eyes1;
                TimersControl(false);

                string message = "Thanks to you the atom is now a full grown isotope!\nWell done!\n\n" +
                "Press Yes to replay, No to close the game or Cancel to continue playing";
                string caption = "You Won! :)";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    (new Atom_main()).Show();
                    this.Close();
                }
                else if (result == System.Windows.Forms.DialogResult.No)
                {
                    Application.Exit();
                }
                else if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    TimersControl(true);
                    continue_decision = true;
                }
            }
        }

        private void btnsettings_Click(object sender, EventArgs e) //changes background color 
        {
            color_press++;

            if (color_press == 5)
            {
                color_press = -1;
            }

            switch (color_press)
            {
                case -1:
                    this.BackColor = SystemColors.Control;
                    break;
                case 0:
                    this.BackColor = Color.Red;
                    break;
                case 1:
                    this.BackColor = Color.Blue;
                    break;
                case 2:
                    this.BackColor = Color.Green;
                    break;
                case 3:
                    this.BackColor = Color.Purple;
                    break;
                case 4:
                    this.BackColor = Color.Aqua;
                    break;
            }
        }

        private void time_is_money_Tick(object sender, EventArgs e) //earn money 
        {
            wait_for_money++;
            if (wait_for_money <= rnd.Next(1, 50))
            {
                if (my_atom.GetHappines() >= 95)
                {
                    my_atom.UpdateMoney(10);
                }
                else if (my_atom.GetHappines() >= 75)
                {
                    my_atom.UpdateMoney(5);
                }
                else if (my_atom.GetHappines() >= 50)
                {
                    my_atom.UpdateMoney(3);
                }
                else if (my_atom.GetHappines() >= 25)
                {
                    my_atom.UpdateMoney(1);
                }
                wait_for_money = 0;
            }
        }

        public void picmarket_Click(object sender, EventArgs e) //opens the market 
        {
            (new market()).Show();
        }

        private void happy_timer_Tick(object sender, EventArgs e) //decreses happiness 
        {
            my_atom.UpdateHappines(-5);
        }

        private void picphoton_Click(object sender, EventArgs e) //uses one photon 
        {
            /*photon stats:
             * 5 XP
             * 5 happiness
             * 15 energy
             */

            if (my_inventory.GetNumberOfPhotons() > 0)
            {
                AddXP(5);
                my_inventory.UsePhoton();
                my_atom.UpdateHappines(5);
                my_atom.UpdateEnergy(15);
            }
        }

        private void energy_timer_Tick(object sender, EventArgs e) //decreses energy 
        {
            my_atom.UpdateEnergy(-1);
        }

        private void radioactive_timer_Tick(object sender, EventArgs e) //radioactivity ability 
        {
            AddXP(1);
        }

        private void picelectron_Click(object sender, EventArgs e) //uses one electron 
        {
            /*photon stats:
             * 10 XP
             * 10 happiness
             * 30 energy
             */

            if (my_inventory.GetNumberOfElectrons() > 0)
            {
                AddXP(10);
                my_inventory.UseElectron();
                my_atom.UpdateHappines(10);
                my_atom.UpdateEnergy(30);
            }
        }

        private void face_cooldown_Tick(object sender, EventArgs e) //changes the face after a level up for certein time 
        {
            face_swap_cooldown++;
            if (face_swap_cooldown == 2)
            {
                picatom.Image = Properties.Resources.atom_eyes4;
                face_swap_cooldown = 0;
                face_cooldown.Stop();
            }
        }

        private void picatom_Click(object sender, EventArgs e) //tickles the atom 
        {
            AddXP(my_atom.GetLevel());
            tickles++;

            if (tickles == touchmax)
            {
                touchmax = rnd.Next(1, 5);
                my_atom.UpdateHappines(1);
                my_atom.UpdateMoney(1);
                tickles = 0;
            }
        }

        private void picgamma_ray_Click(object sender, EventArgs e) //uses the gamma ray 
        {
            /*photon stats:
             * 40 XP
             * 25 happiness
             * 25 energy
             * 30 sec cooldown
             */

            if (lblgamma_ray.Text == "ready")
            {
                AddXP(40);
                my_atom.UpdateHappines(25);
                my_atom.UpdateEnergy(25);
                gamma_is_ready = false;
                gamma_cooldown.Start();
            }
        }

        private void gamma_cooldown_Tick(object sender, EventArgs e) //cooldown between uses of the gamma ray 
        {
            gamma_ray_cooldown++;
            if (gamma_ray_cooldown == 30)
            {
                gamma_ray_cooldown = 0;
                gamma_cooldown.Stop();
                gamma_is_ready = true;
            }
        }

        private void AddXP(int xp) //a helper function in the process of adding XP 
        {
            if (my_atom.UpdateXP(xp) == 1)
            {
                picatom.Image = Properties.Resources.atom_eyes2;
                face_cooldown.Start();
            }
        }

        private void TimersControl(bool flip) //controls all of the timers simulanously (I don't think this is how I was supposed to spell this word...) 
        {
            time_is_money.Enabled = flip;
            main_timer.Enabled = flip;
            happy_timer.Enabled = flip;
            gamma_cooldown.Enabled = flip;
            energy_timer.Enabled = flip;
            radioactive_timer.Enabled = flip;
        }
    }
}
