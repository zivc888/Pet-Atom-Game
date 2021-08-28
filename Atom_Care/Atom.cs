using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atom_Care
{
    public class Atom
    {
        private int energy_percent;
        private int happines_percent;
        private int money;
        private int xp;
        private int level;

        public Atom()
        {
            energy_percent = 100;
            happines_percent = 100;
            money = 0;
            xp = 0;
            level = 0;
        }

        // GET/SET for the energy
        public int GetEnergy()
        {
            return energy_percent;
        }
        public void UpdateEnergy(int energy)
        {
            this.energy_percent += energy;
            if (this.energy_percent > 100)
            {
                this.energy_percent = 100;
            }
        }

        // GET/SET for the happiness
        public int GetHappines()
        {
            return happines_percent;
        }
        public void UpdateHappines(int happines)
        {
            this.happines_percent += happines;
            if (this.happines_percent > 100)
            {
                this.happines_percent = 100;
            }
        }

        // GET/SET for the money
        public int GetMoney()
        {
            return money;
        }
        public void UpdateMoney(int money)
        {
            this.money += money;
        }

        // GET/SET for the XP and some calculations
        public int GetXP()
        {
            return xp;
        }
        public int GetXPForNextLevel()
        {
            return (int)Math.Pow(2, GetLevel()) * 100;
        }
        public int UpdateXP(int xp)
        {
            this.xp += xp;
            if (this.xp >= GetXPForNextLevel())
            {
                this.xp %= GetXPForNextLevel();
                level++;
                return 1;
            }
            return 0;
        }

        // GET for the level
        public int GetLevel()
        {
            return level;
        }

    }
}
