namespace cinti_chat
{
    internal static class Program
    {




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
            Application.Run(new frmChatUtente1());
        }
    }
}