using System;

namespace Ex04.Menues.Interfaces
{
    public class ShowTime : MenuItem, IExecutable
    {
        public ShowTime(string i_Headline) : base(i_Headline) 
        {
        }

        public void Execute()
        {
            string time;

            time = DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine("The Current Time: {0}", time);
        }
    }
}
