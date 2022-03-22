using System;

namespace Exercicio3
{
    internal class Program
    {
        [Flags]
        private enum Perk
        {
            Stealth  = 0b0001, // 1 << 0
            Combat   = 0b0010, // 1 << 1
            Lockpick = 0b0100, // 1 << 2
            Luck     = 0b1000  // 1 << 3
        }


        private static void Main(string[] args)
        {
            Console.Write("Insere o número de NPCs: ");
            // Read NPC amount
            int npcAmount = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // Create NPC perk list
            Perk[] npcPerks = new Perk[npcAmount];

            // Variable to verify if perk should be added
            string shouldHave;

            for (int i = 0; i < npcPerks.Length; i++)
            {
                // Should add Stealth
                Console.Write($"O NPC {i} deve ter o Perk Stealth? [y][n]: ");
                shouldHave = Console.ReadLine();

                // Add Stealth if y
                if (shouldHave == "y") npcPerks[i] |= Perk.Stealth;

                // Should add Combat
                Console.Write($"O NPC {i} deve ter o Perk Combat? [y][n]: ");
                shouldHave = Console.ReadLine();

                // Add Combat if y
                if (shouldHave == "y") npcPerks[i] |= Perk.Combat;

                // Should add Lockpick
                Console.Write($"O NPC {i} deve ter o Perk Lockpick? [y][n]: ");
                shouldHave = Console.ReadLine();

                // Add Lockpick if y
                if (shouldHave == "y") npcPerks[i] |= Perk.Lockpick;

                // Should add Luck
                Console.Write($"O NPC {i} deve ter o Perk Luck? [y][n]: ");
                shouldHave = Console.ReadLine();

                // Add Luck if y
                if (shouldHave == "y") npcPerks[i] |= Perk.Luck;

                Console.WriteLine();
            }

            for (int i = 0; i < npcPerks.Length; i++)
            {
                // Write NPC perks
                Console.WriteLine($"O NPC {i} tem os perks: {npcPerks[i]}");

                // If NPC has Combat and Luck write special message
                if ((npcPerks[i] & Perk.Combat) == Perk.Combat &&
                    (npcPerks[i] & Perk.Luck) == Perk.Luck)
                    Console.WriteLine("You shall win all fights!");

                Console.WriteLine();
            }
        }
    }
}