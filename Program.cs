namespace SDAM_2_Individual_assignment
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void MainBak()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
        static void Main(string[] args) 
        {
            var stockSystem = new StockManagementSystem();

            // Add new stock items
            stockSystem.AddStockItem("001", "Item A", 100);
            stockSystem.AddStockItem("002", "Item B", 50);

            // View stock levels
            stockSystem.ViewStockLevels();
        }
    }
}