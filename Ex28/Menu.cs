﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28
{
    public class Menu
    {
        Database_Controller DBC = new Database_Controller();
        private void Show()
        {
            Console.WriteLine("Welcome to the menu!");
            Console.WriteLine("1. Insert a Pet");
            Console.WriteLine("2. Show all pets");
            Console.WriteLine("3. Insert Owner");
            Console.WriteLine("4. Find owner by last name");
            Console.WriteLine("5. Find owner by email");
            Console.WriteLine("0. Exit");
        }
        public void RunMenu()
        {
            Show();
            //bool run = true;
            string input = GetUserInput();

            //do
            //{
            switch (input)
            {
                case "1":
                    do
                    {
                        Console.Clear();
                        DBC.InsertPet();
                        break;

                    } while (true);
                    RunMenu();
                    break;

                case "2":
                    do
                    {
                        Console.Clear();
                        DBC.ShowPets();
                        Console.WriteLine("\n");
                        break;

                    } while (true);
                    RunMenu();
                    break;

                case "3":
                    do
                    {
                        Console.Clear();
                        DBC.InsertOwner();
                        break;

                    } while (true);
                    RunMenu();
                    break;

                case "4":
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Insert last name");
                        DBC.FindOwnerByLastName(GetUserInput());
                        Console.WriteLine("\n");
                        break;

                    } while (true);
                    RunMenu();
                    break;

                case "5":
                    Console.WriteLine("Insert email");
                    Console.WriteLine("Insert name");
                    DBC.FindOwnerByEmail(GetUserInput(), GetUserInput());
                    break;
                case "0":
                    //run = false;
                    break;
                default:
                    do
                    {
                        Console.WriteLine("??");
                        Console.WriteLine("\n");
                        break;

                    } while (true);
                    RunMenu();
                    break;
            }

            //} while (run);
        }

        private string GetUserInput()
        {
            string input = Console.ReadLine();
            return input;
        }
    }
}