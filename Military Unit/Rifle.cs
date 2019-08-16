using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    public class Rifle : RangedWeapon
    {
        public Rifle()
        {

        }


        override public void Shoot()
        {
            while (bulletInChamber)
            {
                while (ammo > 0)
                {
                    Random r = new Random();

                    ammo--;

                    int gunShot = r.Next(2);
                    if (gunShot == 1)
                    {
                        Console.WriteLine("Bang!");
                    }
                    else if (gunShot == 2)
                    {
                        Console.WriteLine("Bam!");
                    }
                    bulletInChamber = false;
                }
            }

            if (ammo == 0)
            {
                bulletInChamber = false;
                Console.WriteLine("Click.");
            }
        }
    }
}
