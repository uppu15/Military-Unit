using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Military_Unit
{
    public class Revolver : Handgun
    {
        //private bool drum1;
        //private bool drum2;
        //private bool drum3;
        //private bool drum4;
        //private bool drum5;
        //private bool drum6;
        public Revolver()
        {
            this.barrelLength = 19.05; //cm
            this.weight = 1048;  //g
            this.caliber = ".45 Colt"; //
            this.length = 31.8;
        }

        public override int Reload()
        {
            Console.Write("How many bullets? ");
            int newBullet = int.Parse(Console.ReadLine());

            return newBullet;    
        }

        public bool[] drum(int newBullet) //will randomly generate a bullet in each hole in the drum.
        {                          
            bool[] drum = new bool[6];
            int freshAmmo = 0;

            int totalBulletCount = drum.Sum(x => x ? 1 : 0);

            if (newBullet <= 6)
            {
                while (freshAmmo < newBullet)
                {
                    for (int i = 0; i < drum.Length; i++)
                    {

                        if (!drum[i])
                        {
                            Random bullet = new Random();

                            if (bullet.NextDouble() <= 0.5)
                            {
                                drum[i] = true;
                                freshAmmo++;
                            }
                            else
                            {
                                drum[i] = false;
                            }
                            if (freshAmmo == newBullet || totalBulletCount == 6)
                            {
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("invalid");
                Reload();
            }
            
            if (totalBulletCount > 6)
            {
                Console.WriteLine("Too many bullets");
            }

            return drum;
        }

        public void Shoot(bool[] drum)
        {
            for (int i = 0; i < drum.Length; i++)
            {
                if (drum[i])
                {
                    Console.WriteLine("Pew!");
                    drum[i] = false;
                }
                else
                {
                    Console.WriteLine("Click.");
                }
            }
        }
    }
}
