using srap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

class Character_Creation
{
    static void Main(string[] args)
    {
        string CharName;

        int[] Characteristics = new int[8];

        Console.WriteLine("                                  Character Creation");
        Console.WriteLine("Enter your name: ");
        CharName = Console.ReadLine();

        Console.WriteLine("\n" + CharName + ", choose your strong (+3D6) characteristic");

        Console.WriteLine("\n\n                I Physical \n1) Strength \n2) Dexterity \n3) Constitution");
        Console.WriteLine("\n\n                II Mental \n1) Perception \n2) Knowledge \n3) Sanity");
        Console.WriteLine("\n\n                III Social \n1) Persuasion \n2) Stubborness ");

        for (int i = 0; i < 2; i++)                                                                                                    //Choosing characteritics
        {
            while (true)
            {
                Console.Write($"\nPick your strong characteristic #{i + 1}: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                bool isValidChar = choice == 1 || choice == 2 || choice == 3 ||
                                    choice == 21 || choice == 22 || choice == 23 ||
                                    choice == 31 || choice == 32;

                bool duplicate = false;

                for (int j = 0; j < i; j++)
                {
                    if (Characteristics[j] == choice)
                    {
                        duplicate = true;
                        break;
                    }
                }

                Characteristics[i] = choice;

                if (!isValidChar)
                {
                    Console.WriteLine("This is an invalid characteristic. Try again.\n");
                }
                else if (duplicate)
                {
                    Console.WriteLine("You already picked that characteristic.\n");    
                }

                else
                {
                    Console.WriteLine("You chose: " + GetName(choice));
                    break;
                }

            }
        }

        for (int i = 2; i < 6; i++)
        {
            while (true)
            {
                Console.Write($"Pick medium characteristic (+2D6) #{i - 1}: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                bool duplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (Characteristics[j] == choice)
                    {
                        duplicate = true;
                        break;
                    }
                }

                bool isValidChar = choice == 1 || choice == 2 || choice == 3 ||
                                   choice == 21 || choice == 22 || choice == 23 ||
                                   choice == 31 || choice == 32;

                if (!isValidChar)
                {
                    Console.WriteLine("This is an invalid characteristic. Try again.");
                }
                else if (duplicate)
                {
                    Console.WriteLine("You already picked that one! Try again.");
                }
                else
                {
                    Characteristics[i] = choice;
                    Console.WriteLine("You chose: " + GetName(choice));
                    break;
                }
            }
        }




        for (int i = 6; i < 7; i++)
        {
            while (true)
            {
                Console.Write($"Pick minor characteristic(+1D6) #{i - 5}: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                bool duplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (Characteristics[j] == choice)
                    {
                        duplicate = true;
                        break;
                    }
                }
                bool isValidChar = choice == 1 || choice == 2 || choice == 3 ||
                                  choice == 21 || choice == 22 || choice == 23 ||
                                  choice == 31 || choice == 32;
                if (!isValidChar)
                {
                    Console.WriteLine("This is an invalid characteristic. Try again.");
                }

                else if (duplicate)
                {
                    Console.WriteLine("You already picked that one! Try again.");
                }
                else
                {
                    Characteristics[i] = choice;
                    Console.WriteLine("You chose: " + GetName(choice));
                    break;
                }
            }
        }



        int[] allCharacteristicsCode = {1, 2, 3, 21, 22, 23, 31, 32 };                              //Automatically assigning the last remaining characteristic
        foreach (int charCode in allCharacteristicsCode)
        {

            bool isCharactiristicChosen = false;
            for (int j = 0; j < 8; j++)
            {
                if (Characteristics[j] == charCode)
                {
                    isCharactiristicChosen = true;
                }
            }

            if (!isCharactiristicChosen) 
            { 
                Characteristics[7] = charCode; 
                break; 
            }
        }

        Console.WriteLine("\nYour chosen characteristics:");
        Console.WriteLine($"Strong: {GetName(Characteristics[0])}, {GetName(Characteristics[1])}");
        Console.WriteLine($"Medium: {GetName(Characteristics[2])}, {GetName(Characteristics[3])}, {GetName(Characteristics[4])}, {GetName(Characteristics[5])}");
        Console.WriteLine($"Minor: {GetName(Characteristics[6])}, {GetName(Characteristics[7])}");





        string[] strongAbilities = new string[6];                                                                                           //Choosing abilities
        string[] weakAbilities = new string[6];

        Console.WriteLine("\n               Choose strong and weak abilities:  " +
            "\n\n             [Strength]" +
            "\nA) Heavy weapons" +
            "\nB) Heavy firearms");
        Console.WriteLine("\n             [Dexterity]" +
           "\nA) Light weapons" +
           "\nB) Light firearms");
        Console.WriteLine("\n             [Constitution]" +
          "\nA) Armor" +
          "\nB) Rallying");
        Console.WriteLine("\n             [Persception]" +
          "\nA) Environment" +
          "\nB) Human");
        Console.WriteLine("\n             [Knowledge]" +
          "\nA) Esoteric" +
          "\nB) Mechanical");
        Console.WriteLine("\n             [Sanity]" +
          "\nA) Willpower" +
          "\nB) Lucidity");

        Console.WriteLine("\n");


        Console.WriteLine("\nChoose 6 strong abilities:");                                                  

        for (int i = 0; i < 6; i++)
        {
            while (true)
            {
                string ability_choice = Console.ReadLine();

                bool duplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (strongAbilities[j] == ability_choice)
                    {
                        duplicate = true;
                        break;
                    }
                }

                bool abilityValidChar = ability_choice == "1a" || ability_choice == "1b" || ability_choice == "2a" ||
                                        ability_choice == "2b" || ability_choice == "3a" || ability_choice == "3b" ||
                                        ability_choice == "4a" || ability_choice == "4b" || ability_choice == "5a" ||
                                        ability_choice == "5b" || ability_choice == "6a" || ability_choice == "6b";

                if (!abilityValidChar)
                {
                    Console.WriteLine("This is an invalid ability. Try again.");
                }
                else if (duplicate)
                {
                    Console.WriteLine("You already picked that one! Try again.");
                }
                else
                {
                    strongAbilities[i] = ability_choice;
                    Console.WriteLine("You chose: " + GetAbilityName(ability_choice));
                    break;
                }
            }
        }

        // Filling weakAbilities
        string[] allAbilityCodes = {
    "1a", "1b", "2a", "2b", "3a", "3b",
    "4a", "4b", "5a", "5b", "6a", "6b"
};

        int weakIndex = 0;
        foreach (string code in allAbilityCodes)
        {
            bool isChosen = false;
            for (int i = 0; i < 6; i++)
            {
                if (strongAbilities[i] == code)
                {
                    isChosen = true;
                    break;
                }
            }

            if (!isChosen)
            {
                weakAbilities[weakIndex] = code;
                weakIndex++;
            }
        }

        
        Console.WriteLine("\nYour chosen strong abilities:");
        foreach (var abCode in strongAbilities)
            Console.WriteLine("- " + GetAbilityName(abCode));

        Console.WriteLine("\nYour weak abilities:");
        foreach (var abCode in weakAbilities)
            Console.WriteLine("- " + GetAbilityName(abCode));



        bool canUseHeavyMelee = strongAbilities.Contains("1a");
        bool canUseHeavyRanged = strongAbilities.Contains("1b");
        bool canUseLightMelee = strongAbilities.Contains("2a");
        bool canUseLightRanged = strongAbilities.Contains("2b");

        // Intermediate is always allowed



        List<Weapon> allWeapons = new List<Weapon>                                                                                      //Choosing a weapon
{
    new Melee_Weapon { Name = "Saw Cleaver", Type = "Intermediate", Damage = "2D6+3", SpecialEffect = "/", Durability = 10 },
    new Melee_Weapon { Name = "Saw-Spear", Type = "Intermediate", Damage = "2D6+2 / 1D6+4", SpecialEffect = "Nothing / +1D6 initiative", Durability = 10 },
    new Melee_Weapon { Name = "Hunter's Axe", Type = "Heavy / Intermediate", Damage = "2D6+4 / 2D6+2", SpecialEffect = "+1D6 initiative / can use firearm", Durability = 12 },
    new Melee_Weapon { Name = "Whip Cane", Type = "Intermediate", Damage = "2D6+2", SpecialEffect = "Area of effect (1D6 dmg to nearby enemies)", Durability = 10 },
    new Melee_Weapon { Name = "Hammer-Sword", Type = "Heavy / Intermediate", Damage = "2D6+5 / 2D6+2", SpecialEffect = "Nothing / can use firearm", Durability = 12 },
    new Melee_Weapon { Name = "Reiterpallasch", Type = "Light", Damage = "3D6", SpecialEffect = "Initiative +1D6, Ranged", Durability = 8 },
    new Melee_Weapon { Name = "Bayonet Rifle", Type = "Intermediate", Damage = "2D6+2", SpecialEffect = "AOE gun mode (1D6 to others), Ranged", Durability = 8 },

    new Ranged_Weapon { Name = "Pistol", Type = "Intermediate", Damage = "1D6+3", SpecialEffect = "Nothing", Durability = 10, Bullets = 10 },
    new Ranged_Weapon { Name = "Tromblon", Type = "Intermediate", Damage = "2D6+1", SpecialEffect = "AoE (1D6 extra)", Durability = 8, Bullets = 5 },
    new Ranged_Weapon { Name = "Sniper Rifle", Type = "Light", Damage = "2D6+4", SpecialEffect = "Twice range", Durability = 10, Bullets = 10 },
    new Ranged_Weapon { Name = "Flamethrower", Type = "Intermediate", Damage = "1D6+3", SpecialEffect = "AoE full dmg (3 enemies)", Durability = 12, Bullets = 15 }
};




        List<Weapon> availableWeapons = new List<Weapon>();                                                                         
        foreach (var weapon in allWeapons)
        {
            bool isMelee = weapon is Melee_Weapon;
            bool isRanged = weapon is Ranged_Weapon;

            if (weapon.Type == "Intermediate")
            {
                availableWeapons.Add(weapon);
            }
            else if (weapon.Type == "Heavy / Intermediate" && (
                        (isMelee && canUseHeavyMelee) ||
                        (isRanged && canUseHeavyRanged)))
            {
                availableWeapons.Add(weapon);
            }
            else if (weapon.Type == "Light" && (
                        (isMelee && canUseLightMelee) ||
                        (isRanged && canUseLightRanged)))
            {
                availableWeapons.Add(weapon);
            }
        }




        Console.WriteLine("\n\n                     Available weapons:");

        for (int i = 0; i < availableWeapons.Count; i++)
        {
            Console.WriteLine($"\n{i + 1})");
            availableWeapons[i].Display();
        }

        int weaponChoice;
        while (true)
        {
            Console.Write("\nChoose your weapon by number: ");
            if (int.TryParse(Console.ReadLine(), out weaponChoice) &&
                weaponChoice >= 1 && weaponChoice <= availableWeapons.Count)

                break;

            Console.WriteLine("Invalid choice. Try again.");
        }

        Weapon chosenWeapon = availableWeapons[weaponChoice - 1];

        Console.WriteLine("\nYou have selected: \n");
        chosenWeapon.Display();





        List<Armor> allArmor = new List<Armor>                                                                                           //Choosing armor
        {
        new Armor { Name = "Hunter's garb", Type = "intermediate", SpecialEffect = "/" },
        new Armor { Name = "Yharnam's hunter's garb", Type = "intermediate", SpecialEffect = "+1D6 persuasion yharnamite" },
        new Armor { Name = "Tomb prospector's garb", Type = "intermediate", SpecialEffect = "+1D6 persuasion clergy" },
        new Armor { Name = "Knight's uniform", Type = "light", SpecialEffect = "+1D6 persuasion clergy" },
        new Armor { Name = "Student's uniform", Type = "light", SpecialEffect = "+1D6 persuasion scholars" },
        new Armor { Name = "Sweat stained clothes", Type = "light", SpecialEffect = "+1D6 persuasion lowlives" },
        };

        Console.WriteLine("\n\n                        Armor:");

        for (int i = 0; i < allArmor.Count; i++)
        {
            Console.WriteLine($"\n{i + 1})");
            allArmor[i].Display();
        }

        int armorChoice;
        while (true)
        {
            Console.Write("\nChoose your armor by number: ");
            if (int.TryParse(Console.ReadLine(), out armorChoice) &&
                armorChoice >= 1 && armorChoice <= allArmor.Count)
                break;

            Console.WriteLine("Invalid choice. Try again.");
        }

        Armor chosenArmor = allArmor[armorChoice - 1];

        Console.WriteLine("\nYou have selected: \n");
        chosenArmor.Display();







        Console.WriteLine("\n\n                 Your character: ");
        Console.WriteLine($" Name: {CharName} \n\n Characteristics: \n\n Strong: {GetName(Characteristics[0])}, {GetName(Characteristics[1])}");
        Console.WriteLine($" Medium: {GetName(Characteristics[2])}, {GetName(Characteristics[3])}, {GetName(Characteristics[4])}, {GetName(Characteristics[5])}");
        Console.WriteLine($" Weak: {GetName(Characteristics[6])}, {GetName(Characteristics[7])}.");

        Console.WriteLine($"\n Strong abilities: {GetAbilityName(strongAbilities[0])}, {GetAbilityName(strongAbilities[1])}, {GetAbilityName(strongAbilities[2])}, ");
        Console.Write($" {GetAbilityName(strongAbilities[3])}, {GetAbilityName(strongAbilities[4])}, {GetAbilityName(strongAbilities[5])}.");

        Console.WriteLine($"\n Weak abilities: {GetAbilityName(weakAbilities[0])}, {GetAbilityName(weakAbilities[1])}, {GetAbilityName(weakAbilities[2])}, ");
        Console.Write($" {GetAbilityName(weakAbilities[3])}, {GetAbilityName(weakAbilities[4])}, {GetAbilityName(weakAbilities[5])}.");

        Console.WriteLine($"\n\n Weapon: {chosenWeapon.Name}.");
        Console.WriteLine($"\n Armor: {chosenArmor.Name}.");






        Console.ReadLine();


    }


    static string GetName(int code)
    {
        if (code == 1) return "Strength";
        if (code == 2) return "Dexterity";
        if (code == 3) return "Constitution";
        if (code == 21) return "Perception";
        if (code == 22) return "Knowledge";
        if (code == 23) return "Sanity";
        if (code == 31) return "Persuasion";
        if (code == 32) return "Stubbornness";
        return "Unknown";
    }

    static string GetAbilityName(string abilityCode)
    {
        if (abilityCode == "1a") return "Heavy weapons";
        if (abilityCode == "1b") return "Heavy firearms";
        if (abilityCode == "2a") return "Light weapons";
        if (abilityCode == "2b") return "Light firearms";
        if (abilityCode == "3a") return "Armor";
        if (abilityCode == "3b") return "Rallying";
        if (abilityCode == "4a") return "Environment";
        if (abilityCode == "4b") return "Human";
        if (abilityCode == "5a") return "Esoteric";
        if (abilityCode == "5b") return "Mechanical";
        if (abilityCode == "6a") return "Willpower";
        if (abilityCode == "6b") return "Lucidity";
        return "unknown";
    }
}
