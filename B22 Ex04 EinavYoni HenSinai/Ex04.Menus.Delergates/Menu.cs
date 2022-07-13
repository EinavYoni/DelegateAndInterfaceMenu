using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class Menu : MenuItem
    {
        private readonly string r_ZeroSelection;
        private List<MenuItem> m_MenuItems = new List<MenuItem>();

        public Menu(string i_Headline, string i_ZeroSelection) : base(i_Headline)
        {
            r_ZeroSelection = i_ZeroSelection;
        }

        public void Add(MenuItem i_MenuItem)
        {
            m_MenuItems.Add(i_MenuItem);
        }

        public void Show()
        {
            int userChoose;

            printMenu();
            userChoose = getInputFromUser();
            while (userChoose != 0)
            {
                Console.Clear();
                m_MenuItems[userChoose - 1].OnExecute();
                printMenu();
                userChoose = getInputFromUser();
            }

            Console.Clear();
        }

        private int getInputFromUser()
        {
            int optionUserChoose;
            bool isInvalidInput;
            string userInput;

            optionUserChoose = -1;
            isInvalidInput = true;
            do
            {
                userInput = Console.ReadLine();
                try
                {
                    optionUserChoose = ValidateInput(userInput);
                    isInvalidInput = false;
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine(formatException.Message);
                }
                catch (ValueOutOfRangeException valueOutOfRangeException)
                {
                    Console.WriteLine(valueOutOfRangeException.Message);
                }
            } 
            while (isInvalidInput);

            return optionUserChoose;
        }

        public int ValidateInput(string i_UserInput)
        {
            int optionUserChoose = 0;
            bool isValid = int.TryParse(i_UserInput, out optionUserChoose);

            if (!isValid)
            {
                throw new FormatException("Invalid input");
            }

            if (!ValidateRange(optionUserChoose, 0, m_MenuItems.Count))
            {
                throw new ValueOutOfRangeException(0, m_MenuItems.Count);
            }

            return optionUserChoose;
        }

        public bool ValidateRange(int i_UserInput, int i_MinValue, int i_MaxValue)
        {
            bool isValidate = true;

            if (i_UserInput < i_MinValue || i_UserInput > i_MaxValue)
            {
                isValidate = !isValidate;
            }

            return isValidate;
        }

        public override void OnExecute()
        {
            Show();
        }

        private void printMenu()
        {
            const int k_FirstOptionIndex = 1;

            Console.WriteLine(Headline);
            Console.WriteLine("-----------------");
            for (int i = 0; i < m_MenuItems.Count; i++)
            {
                Console.WriteLine("{0} -> {1}", i + 1, m_MenuItems[i].Headline);
            }

            Console.WriteLine("0 -> {0}", r_ZeroSelection);
            Console.WriteLine("-----------------");
            if (m_MenuItems.Count > 0)
            {
                Console.WriteLine("Enter your request ({0} to {1} or '0' to {2})", k_FirstOptionIndex, m_MenuItems.Count, r_ZeroSelection);
            }
            else
            {
                Console.WriteLine("Enter '0' to {0}", r_ZeroSelection);
            }
        }
    }
}