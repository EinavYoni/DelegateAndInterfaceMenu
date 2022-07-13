using System;

namespace Ex04.Menues.Interfaces
{
    public class ShowVersion : MenuItem, IExecutable
    {
        public ShowVersion(string i_Headline) : base(i_Headline) 
        {
        }

        public void Execute()
        {
            Console.WriteLine("Version: 22.2.4.8950");
        }
    }
}
