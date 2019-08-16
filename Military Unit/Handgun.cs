using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    public class Handgun : RangedWeapon
    {

        public override void Shoot()
        {
            while (ammo > 0)
            {
                ammo--;
                Console.WriteLine("Pew!");
            }

            if (ammo == 0)
            {
                Console.WriteLine("Click.");
            }
        }
    }
}
