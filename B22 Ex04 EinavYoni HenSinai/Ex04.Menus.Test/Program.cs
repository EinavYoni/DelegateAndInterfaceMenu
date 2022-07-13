using System;

namespace Ex04.Menus.Test
{
    public class Program
    {

      
        public static void Main()
        {
            MenusInterfaces menusInterfaces = new MenusInterfaces();
            MenusDelegates menusDelegates = new MenusDelegates();
            menusInterfaces.Show();
            Console.Clear();
            menusDelegates.Show();
        }
    }
}
