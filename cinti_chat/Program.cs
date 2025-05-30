namespace cinti_chat
{
    internal static class Program
    {

        //forms
        public static frmChatUtente1 formchatUtente1 = new frmChatUtente1();
        public static frmChatUtente2 formchatUtente2 = new frmChatUtente2();



        //inizializzo la chat
        public static Chat chat = new Chat();


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(formchatUtente1);
        }
    }
}