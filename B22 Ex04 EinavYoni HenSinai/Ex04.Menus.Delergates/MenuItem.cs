namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        private readonly string r_Headline;

        public MenuItem(string i_Headline)
        {
            r_Headline = i_Headline;
        }

        public string Headline
        {
            get 
            { 
                return r_Headline;
            }
        }

        public abstract void OnExecute();
    }
}
