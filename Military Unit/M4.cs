using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class M4 : Rifle
    {
        public M4()
        {
            this.barrelLength = 36.83; //cm
            this.weight = 3010;  //g
            this.caliber = "5.56"; //
            this.length = 75.6;
        }
        override public int Reload()
        {
            return ammo += 30;
        }

        public override void Shoot()
        {

            if (ammo > 0 && bulletInChamber)
            {
                Random r = new Random();

                ammo--;

                int gunShot = r.Next(2);
                if (gunShot == 1)
                {
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Bam!");
                }
                bulletInChamber = true;
            }

            else if (this.ammo == 0 || !bulletInChamber)
            {
                Console.WriteLine("Click..");

                bulletInChamber = false;
            }
        }
    }
}
