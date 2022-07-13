using System;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class MenusDelegates
    {
        private const string k_MainMenuZeroSelection = "Exit";
        private const string k_internalMenuZeroSelection = "Back";
        private Menu m_MainMenu;

        public MenusDelegates()
        {
         
            ExecuteMenuItem countCapitlas, showVersion, showDate, showTime;
            Menu versionAndSpaces, showDateOrTime;

            countCapitlas = new ExecuteMenuItem("Count Spaces");
            showVersion = new ExecuteMenuItem("Show Version");
            showDate = new ExecuteMenuItem("Show Date");
            showTime = new ExecuteMenuItem("Show Time");
            m_MainMenu = new Menu("Delegate Main Menu", k_MainMenuZeroSelection);
            versionAndSpaces = new Menu("Version And Spaces", k_internalMenuZeroSelection);
            showDateOrTime = new Menu("Show Date/Time", k_internalMenuZeroSelection);

            countCapitlas.m_Execute += CountSpaces_Execute;
            showVersion.m_Execute += ShowVersion_Execute;
            showDate.m_Execute += ShowDate_Execute;
            showTime.m_Execute += ShowTime_Execute;
           
            versionAndSpaces.Add(countCapitlas);
            versionAndSpaces.Add(showVersion);
            showDateOrTime.Add(showDate);
            showDateOrTime.Add(showTime);
            m_MainMenu.Add(versionAndSpaces);
            m_MainMenu.Add(showDateOrTime);
        }

        public void CountSpaces_Execute()
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

            Console.WriteLine("There are {0} spaces in your sentence {1}", countSpaces, Environment.NewLine);
        }

        public void ShowDate_Execute()
        {
            string date;

            date = DateTime.Now.ToShortDateString();
            Console.WriteLine("The Date Of Today: {0}{1}", date, Environment.NewLine);
        }

        public void ShowTime_Execute()
        {
            string time;

            time = DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine("The Current Time: {0}{1}", time, Environment.NewLine);
        }

        public void ShowVersion_Execute()
        {
            Console.WriteLine("Version: 22.2.4.8950 {0}", Environment.NewLine);
        }

        public void Show()
        {
            m_MainMenu.Show();
        }
    }
}
