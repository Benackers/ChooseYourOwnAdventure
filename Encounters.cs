using System;

namespace Adventure
{

    class enemy
    {
        public int health;
        public int damage;
    }
    class Encounters
    {
        public static void firstEncounter()
        {

        }

        public static void combat(int playerHealth, int weaponDamage, int armorHealth, int enemyDamage, int enemyHealth)
        {
            bool combatStatus = true;
            bool enemyTurn = false;
            Random random = new Random();
            int roll;
            while (combatStatus == true)
            {
                Console.WriteLine("Please select a combat option: \n 1. Attack \n 2. Run");
                var response = Console.ReadLine().ToLower();
                if (response == "1")
                {
                    roll = random.Next(1, 6);
                    if (roll > 2)
                    {

                        if (enemyHealth > 0)
                        {
                            enemyHealth -= weaponDamage;
                            Console.WriteLine($"You attack and damage the enemy for {weaponDamage} health! They now have {enemyHealth} health left!");
                            enemyTurn = true;
                        }
                        else
                        {
                            Console.WriteLine("You have defeated your enemy!");
                            combatStatus = false;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Your attack missed!");
                        enemyTurn = true;
                    }
                }
                else if (response == "2")
                {
                    Console.WriteLine("You run away like a coward!");
                    combatStatus = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                }
                while (enemyTurn)
                {
                    Console.WriteLine("The enemy swings their weapon at you!");
                    roll = random.Next(1, 6);
                    if (roll > 4)
                    {
                        playerHealth -= enemyDamage;
                        if (playerHealth > 0)
                        {
                            Console.WriteLine($"the enemy Damages you causing {enemyDamage} damage! Your health is now {playerHealth}.");
                        }
                        else
                        {
                            Console.WriteLine("You have been defeated!");
                            combatStatus = false;
                        }

                    }
                    else
                    {
                        Console.WriteLine("The enemy attack missed!");
                    }
                    enemyTurn = false;
                }
            }
        }
    }
}