namespace NoSleep
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new NoSleepFrm());
        }

        public static CancellationToken cancelToken = new CancellationToken(false);

        public static void StartNoSleep()
        {
            //var timer = new PeriodicTimer(TimeSpan.FromSeconds(60));

            //while (await timer.WaitForNextTickAsync())
            //{
            //    if (cancelToken.IsCancellationRequested)
            //    {
            //        return;
            //    }

                NativeMethods.PreventSleep();
            //}
        }
    }
}