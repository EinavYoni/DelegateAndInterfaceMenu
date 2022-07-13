using Ex04.Menues.Interfaces;

namespace Ex04.Menus.Test
{
    public class MenusInterfaces
    {
        private const string k_MainMenuZeroSelection = "Exit";
        private const string k_internalMenuZeroSelection = "Back";
        private readonly Menu r_MainMenu;

        public MenusInterfaces()
        {
            Menu versionAndSpaces, showDateOrTime;

            r_MainMenu = new Menu("Interfaces Main Menu", k_MainMenuZeroSelection);
            versionAndSpaces = new Menu("Version And Spaces", k_internalMenuZeroSelection);
            showDateOrTime = new Menu("Show Date/Time", k_internalMenuZeroSelection);
            versionAndSpaces.Add(new CountSpaces("Count Spaces"));
            versionAndSpaces.Add(new ShowVersion("Show Version"));
            showDateOrTime.Add(new ShowDate("Show Date"));
            showDateOrTime.Add(new ShowTime("Show Time"));

            r_MainMenu.Add(versionAndSpaces);
            r_MainMenu.Add(showDateOrTime); 
        }

        public void Show()
        {
            r_MainMenu.Show();
        }
    }
}
