using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;
using System.Collections.Generic;
using MagicDestroyers.InputOutputUser;
using System.IO;
using System;

namespace MagicDestroyers
{
    class EntryPoint
    {
        static void Main()
        {
            /*
            //Tipos por valor y por referencia

            //Por valor
            int firstNumber = 4;
            int secondNumber = firstNumber;
            System.Console.WriteLine($"firstNumber: {firstNumber}, secondNumber: {secondNumber}");
            firstNumber += 1;
            System.Console.WriteLine($"firstNumber: {firstNumber}, secondNumber: {secondNumber}");


            //Por referencia
            List<int> firstList = new List<int> { firstNumber, secondNumber };
            List<int> secondList = firstList;
            for (int i = 0; i < firstList.Count; i++)
            {
                System.Console.WriteLine($"{firstList[i]}, {secondList[i]}");
            }
            firstList[0] = firstNumber * 2;
            for (int i = 0; i < firstList.Count; i++)
            {
                System.Console.WriteLine($"{firstList[i]}, {secondList[i]}");
            }

            //Otro Ejemplo con objetos, las clases creadas son por referencia
            Warrior warrior1 = new Warrior();
            System.Console.WriteLine(warrior1.Name);
            changeWarriorName(warrior1); 
            System.Console.WriteLine(warrior1.Name);

            //Que pasa si cambio el valor de un int en un metodo?
            System.Console.WriteLine(PlusOne(firstNumber)); // Esto deberia mostrar 6
            System.Console.WriteLine(firstNumber); //Esto mostrara 5 porque es por valor!!
            */

            // I/O
            List<Character> characters = new List<Character>();
            List<string> options = new List<string>()
            {
                "Test send message",
                "Test error message",
                "Test load file",
                "Exit"
            };
            int option = -1;

            while (option != options.Count - 1)
            {
                IOUser.ConsoleListOutput("Please select one option", options);
                option = IOUser.ConsoleReadInput();
                switch (option)
                {
                    case 0:
                        IOUser.ConsoleOutput("Testing send message...");
                        break;
                    case 1:
                        IOUser.ConsoleError("Testing error message...");
                        break;
                    case 2:
                        IOUser.ConsoleOutput("Loading file...");
                        string s = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../Files/Characters.txt");
                        StreamReader reader = new StreamReader(s);

                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string [] characterParams = line.Split(',');
                            switch (characterParams[0])
                            {
                                case "Warrior":
                                    characters.Add(new Warrior(characterParams[1], int.Parse(characterParams[2])));
                                    break;
                                case "Knight":
                                    characters.Add(new Knight(characterParams[1], int.Parse(characterParams[2])));
                                    break;
                                case "Assassin":
                                    characters.Add(new Assassin(characterParams[1], int.Parse(characterParams[2])));
                                    break;
                                case "Mage":
                                    characters.Add(new Mage(characterParams[1], int.Parse(characterParams[2])));
                                    break;
                                case "Druid":
                                    characters.Add(new Druid(characterParams[1], int.Parse(characterParams[2])));
                                    break;
                                case "Necromancer":
                                    characters.Add(new Necromancer(characterParams[1], int.Parse(characterParams[2])));
                                    break;
                                default:
                                    break;
                            }
                        }
                        foreach (Character character in characters)
                        {
                            System.Console.WriteLine($"Character class: {character.GetType().Name}, Character Name: {character.Name}");
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        static void changeWarriorName(Warrior warrior)
        {
            //Al ser por referencia, el parametro cambiara el valor del guerrero que se encuentra en el main.
            warrior.Name = "Phil";
        }

        static int PlusOne(int number)
        {
            return number+1;
        }
    }
}
