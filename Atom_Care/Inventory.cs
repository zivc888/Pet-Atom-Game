using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atom_Care
{
    public class Inventory
    {
        private int number_of_photons;
        private int number_of_electrons;
        private bool gamma_ray;
        private bool radioactivity;

        public Inventory()
        {
            number_of_photons = 0;
            number_of_electrons = 0;
            gamma_ray = false;
            radioactivity = false;
        }

        // GET/SET for the photons
        public int GetNumberOfPhotons()
        {
            return number_of_photons;
        }
        public void UsePhoton()
        {
            this.number_of_photons--;
        }
        public void BuyPhoton()
        {
            this.number_of_photons++;
        }

        // GET/SET for the electrons
        public int GetNumberOfElectrons()
        {
            return number_of_electrons;
        }
        public void UseElectron()
        {
            this.number_of_electrons--;
        }
        public void BuyElectron()
        {
            this.number_of_electrons++;
        }

        // GET/SET for the gamma ray
        public bool CheckGammaRay()
        {
            return gamma_ray;
        }
        public void BuyGammaRays()
        {
            this.gamma_ray = true;
        }

        // GET/SET for the radioactivity
        public bool CheckRadioactivity()
        {
            return radioactivity;
        }
        public void BuyRadioactivity()
        {
            this.radioactivity = true;
        }
    }
}
