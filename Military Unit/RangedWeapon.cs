using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    public class RangedWeapon : Weapon
    {
        public int ammo;
        public bool bulletInChamber;
        public double barrelLength;
        public string caliber;
        public double length;
        public int weight;

        public RangedWeapon()
        {
            this.isRanged = true;
            this.ammo = 0;
            this.bulletInChamber = false;
        }

        virtual public int Reload()
        {
            
            bulletInChamber = true;
            return ammo++;
        }

        virtual public void Shoot()
        {
            while (this.ammo > 0)
            {
                ammo--;
            }
            if(this.ammo == 0)
            {
                Console.WriteLine("Out of ammunition.");
            }
            bulletInChamber = false;
        }

        public void pullChargingHandle()
        {
            bulletInChamber = true;
        }

        public int CheckClip()
        {
            int clip = ammo;



            return clip;
        }
    }
}
