namespace Ex04.Menues.Interfaces
{
    public abstract class MenuItem
    {
        private string m_Headline;

        public MenuItem(string i_HeadLine)
        {
            m_Headline = i_HeadLine;
        }

        public string Headline
        {
            get 
            { 
                return m_Headline;
            }

            set
            { 
                m_Headline = value;
            }
        }
    }
}