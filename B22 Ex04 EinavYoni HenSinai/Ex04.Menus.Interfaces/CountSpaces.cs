using System;

namespace Ex04.Menues.Interfaces
{
    public class CountSpaces : MenuItem, IExecutable
    {
        public CountSpaces(string i_Headline) : base(i_Headline) 
        {
        }

        public void Execute()
        {
            const char k_SpaceChar = ' ';
            string userSentenceInput;
            int countSpaces;

            Console.WriteLine("Please enter your sentence:");
            userSentenceInput = Console.ReadLine();
            countSpaces = 0;
            foreach (char letter in userSentenceInput)
            {
                if (k_SpaceChar == letter)
                {
                    countSpaces++;
                }
            }

            Console.WriteLine("There are {0} spaces in your sentence", countSpaces);
        }
    }
}
