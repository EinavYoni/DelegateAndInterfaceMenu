namespace Ex04.Menus.Delegates
{
    public delegate void ExecuteHandlerDelegate();

    public class ExecuteMenuItem : MenuItem
    {
        public event ExecuteHandlerDelegate m_Execute;

        public ExecuteMenuItem(string i_Headline) : base(i_Headline) 
        {
        }

        public override void OnExecute()
        {
            if (m_Execute != null)
            {
                m_Execute.Invoke();
            }
        }
    }
}
