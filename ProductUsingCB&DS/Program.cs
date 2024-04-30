namespace ProductUsingCB_DS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuOptions menuOptions = new MenuOptions();

            while (true)
            {
                menuOptions.ShowMenu();
                menuOptions.HandleUserInput();
            }
        }
    }
}
