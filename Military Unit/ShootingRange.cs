using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    public class ShootingRange
    {
        public static void shootingRange()
        {
            Revolver c1 = new Revolver();
            M9 m9 = new M9();
            M4 m4 = new M4();
            M82 m82 = new M82();

            Console.WriteLine("We currently have revolver, m9(pistol), m4(automatic rifle), m82(semi-auto rifle) or \"leave\"\n\n");
            Console.Write("\tWhich weapon would you like to play with? ");
            string entry = Console.ReadLine();

            if (entry == "m4")
            {
                Console.WriteLine($"the length of barrel is {m4.barrelLength} cm long.");
                Console.WriteLine($"Length of this weapon is {m4.length} cm long.");
                Console.WriteLine($"Weight of this weapon is {m4.weight} grams.");
                Console.WriteLine($"This weapon feeds on {m4.caliber} rounds.");
                Console.WriteLine("Available actions: reload / charge / shoot / clip / return");
                doStuff(m4);
            }
            else if (entry == "m9")
            {
                Console.WriteLine($"the length of barrel is {m9.barrelLength} cm long.");
                Console.WriteLine($"Length of this weapon is {m9.length} cm long.");
                Console.WriteLine($"Weight of this weapon is {m9.weight} grams.");
                Console.WriteLine($"This weapon feeds on {m9.caliber} rounds.");
                Console.WriteLine("Available actions: reload / charge / shoot / clip/ return");
                doStuff(m9);
            }
            else if (entry == "revolver")
            {
                Console.WriteLine($"the length of barrel is {c1.barrelLength} cm long.");
                Console.WriteLine($"Length of this weapon is {c1.length} cm long.");
                Console.WriteLine($"Weight of this weapon is {c1.weight} grams.");
                Console.WriteLine($"This weapon feeds on {c1.caliber} rounds.");
                Console.WriteLine("Available actions: shoot / return");
                doStuff(c1);
            }
            else if (entry == "m82")
            {
                Console.WriteLine($"the length of barrel is {m82.barrelLength} cm long.");
                Console.WriteLine($"Length of this weapon is {m82.length} cm long.");
                Console.WriteLine($"Weight of this weapon is {m82.weight} grams.");
                Console.WriteLine($"This weapon feeds on {m82.caliber} rounds.");
                Console.WriteLine("Available actions: reload / charge / shoot / clip / return");
                doStuff(m82);
            }
            else if (entry == "leave")
            {

            }
            else
            {
                Console.WriteLine("Check your input");
                shootingRange();
            }
        }

        static void doStuff(M4 inputName)
        {
            Console.Write("Your action: ");
            string action = Console.ReadLine();

            if (action == "reload")
            {
                inputName.Reload();
                doStuff(inputName);
            }
            else if (action == "shoot")
            {
                inputName.Shoot();
                doStuff(inputName);
            }
            else if (action == "charge")
            {
                inputName.pullChargingHandle();
                doStuff(inputName);
            }
            else if (action == "return")
            {
                shootingRange();
            }
            else if (action == "clip")
            {
                Console.WriteLine($"You have {inputName.CheckClip()} rounds left in current clip.");
                doStuff(inputName);
            }
            else
            {
                Console.WriteLine("Check your input");
                doStuff(inputName);
            }
        }

        static void doStuff(M82 inputName)
        {
            Console.Write("Your action: ");
            string action = Console.ReadLine();

            if (action == "reload")
            {
                inputName.Reload();
                doStuff(inputName);
            }
            else if (action == "shoot")
            {
                inputName.Shoot();
                doStuff(inputName);
            }
            else if (action == "charge")
            {
                inputName.pullChargingHandle();
                doStuff(inputName);
            }
            else if (action == "return")
            {
                shootingRange();
            }
            else if (action == "clip")
            {
                Console.WriteLine($"You have {inputName.CheckClip()} rounds left in current clip.");
                doStuff(inputName);
            }
            else
            {
                Console.WriteLine("Check your input");
                doStuff(inputName);
            }
        }

        static void doStuff(Revolver inputName)
        {
            Console.Write("Your action: ");
            string action = Console.ReadLine();

            if (action == "shoot")
            {
                inputName.Shoot(inputName.drum(inputName.Reload()));
                doStuff(inputName);
            }
            else if (action == "return")
            {
                shootingRange();
            }
            else
            {
                Console.WriteLine("Check your input");
                doStuff(inputName);
            }
        }
        static void doStuff(M9 inputName)
        {
            Console.Write("Your action: ");
            string action = Console.ReadLine();

            if (action == "reload")
            {
                inputName.Reload();
                doStuff(inputName);
            }
            else if (action == "shoot")
            {
                inputName.Shoot();
                doStuff(inputName);
            }
            else if (action == "charge")
            {
                inputName.pullChargingHandle();
                doStuff(inputName);
            }
            else if (action == "return")
            {
                shootingRange();
            }
            else if (action == "clip")
            {
                Console.WriteLine($"You have {inputName.CheckClip()} rounds left in current clip.");
                doStuff(inputName);
            }
            else
            {
                Console.WriteLine("Check your input");
                doStuff(inputName);
            }
        }
    }
}
