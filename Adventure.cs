using System;

namespace Adventure
{
    class Program
    {

        public static Player mainCharacter = new Player();
        public static enemy firstEnemy = new enemy();
        public static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            Console.WriteLine("Wow, You have just started the coolest console game ever! Are you ready to start your adventure? Y/N");
            bool validInputName = false;
            while (!validInputName)
            {
                var answer = Console.ReadLine();
                answer = answer.ToLower();

                if (answer == "y")
                {
                    validInputName = true;
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Didn't want you to play anyway.");
                    return;
                }
                else
                {
                    Console.WriteLine("Please select a valid option. Y/N");
                }
            }
            Console.WriteLine("And so it begins...");
            Console.WriteLine("------------------\n Character Creation \n ------------------");
            Console.WriteLine("What is your name?");
            mainCharacter.name = Console.ReadLine();
            Console.WriteLine($"Great, {mainCharacter.name}");
            Console.WriteLine("What is your Gender? M/F");
            bool validInputg = false;
            while (!validInputg)
            {
                var answer = Console.ReadLine();
                answer = answer.ToLower();

                if (answer == "m")
                {
                    mainCharacter.gender = "Male";
                    validInputg = true;
                }
                else if (answer == "f")
                {
                    mainCharacter.gender = "Female";
                    validInputg = true;
                }
                else
                {
                    Console.WriteLine("Please select a valid option: M/F");
                }
            }
            Console.WriteLine("What race are you? (Type in the corresponding number) \n 1. Human \n 2. Orc \n 3. Elf \n 4. Dwarf");
            bool validrace = false;
            while (!validrace)
            {
                var race = Console.ReadLine();
                switch (race)
                {
                    case "1":
                        mainCharacter.race = "Human";
                        validrace = true;
                        break;
                    case "2":
                        mainCharacter.race = "Orc";
                        validrace = true;
                        break;
                    case "3":
                        mainCharacter.race = "Elf";
                        validrace = true;
                        break;
                    case "4":
                        mainCharacter.race = "Dwarf";
                        validrace = true;
                        break;
                    default:
                        Console.WriteLine("Please select a valid number: \n 1. Human \n 2. Orc \n 3. Elf \n 4. Dwarf");
                        validrace = false;
                        break;
                }
            }
            Console.WriteLine($"Your name is {mainCharacter.name} and you are a {mainCharacter.gender} {mainCharacter.race}. You Currently have 20 health. You have only your fists as a weapon. You have no armor.");
            Console.WriteLine("------------------------------------------- The Story Begins -------------------------------------------");
            Console.WriteLine("Narrator: You wake up to darkness, you hear the sound of water drips echoing through a large chamber. You hear the sound of your breathing echoing. You feel your arms tied behind your back, sitting on a chair. A short test of the bonds show they are secure...");
            Console.WriteLine("RANDOM JUMP TO ACTION");
            Console.WriteLine("A large Orc enters the chamber. He's looking for a fight.");
            firstEnemy.health = 20;
            firstEnemy.damage = 5;
            Encounters.combat(mainCharacter.health, mainCharacter.weaponDamage, mainCharacter.armorHealth, firstEnemy.damage, firstEnemy.health);
        }
    }
}

