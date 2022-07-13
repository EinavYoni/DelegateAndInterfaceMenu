using System;

namespace Ex04.Menues.Interfaces
{
    public class ShowDate : MenuItem, IExecutable
    {
        public ShowDate(string i_Headline) : base(i_Headline) 
        {
        }

        public void Execute()
        {
            string date;
            
            date = DateTime.Now.ToShortDateString();
            Console.WriteLine("The Date Today is: {0}", date);
        }
    }
}
