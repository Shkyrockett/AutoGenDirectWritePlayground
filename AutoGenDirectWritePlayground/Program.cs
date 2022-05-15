namespace AutoGenDirectWritePlayground
{
    /// <summary>
    /// 
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            using var mainForm = new Form1();
            Application.Run(mainForm);
        }
    }
}
