namespace _1_11Struktury.App1
{
    internal static class App1
    {
        public static void Start()
        {
            var todos = new List<Todo>();
            while (true)
            {
                todos = Menu.ShowMenu(todos);
            }
        }
    }
}
