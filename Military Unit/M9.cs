using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class M9 : Handgun
    {
        public M9()
        {
            this.barrelLength = 12.49; //cm
            this.weight = 970;  //g
            this.caliber = "19mm"; //
            this.length = 21.7;
        }
        public override int Reload()
        {          
            bulletInChamber = true;
            return ammo += 15;
        }

        public override void Shoot()
        {
            while (bulletInChamber)
            {
                while (ammo > 0)
                {
                    ammo--;
                    Console.WriteLine("Pew!");
                }

                if (ammo == 0)
                {
                    bulletInChamber = false;
                    Console.WriteLine("Click.");
                }
            }
        }
    }
}
