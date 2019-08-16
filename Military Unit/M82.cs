using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class M82 : Rifle
    {
        public M82()
        {
            this.barrelLength = 74; //cm
            this.weight = 14000;  //g
            this.caliber = ".416"; //
            this.length = 140;
        }
        public override int Reload()
        {
            return ammo += 10;
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
                    Console.WriteLine("Pow!");
                }
                bulletInChamber = false;

            }

            else if (this.ammo == 0 || !bulletInChamber)
            {
                Console.WriteLine("Click..");

                bulletInChamber = false;
            }
        }
    }
}
