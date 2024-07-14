namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private MenuItem m_RootMenu = new MenuItem("Delegates Main Menu");
        public MenuItem GetMainMenu() => m_RootMenu;
        public void RunMenu() => m_RootMenu.HandleSelection();
        public void AddItemToMenu(MenuItem i_MenuItem) => m_RootMenu.AddItemToMenu(i_MenuItem);
    }
}