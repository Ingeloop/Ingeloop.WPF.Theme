using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Ingeloop.WPF.Theme
{
    public static class SplashScreenManager
    {
        public static void ShowSplashScreen(string applicationName, string versionName, Action startupAction, int minimumDelay = 0)
        {
            IngeloopSplashScreen splashScreen = null;

            Thread splashScreenThread = new Thread(() =>
            {
                splashScreen = new IngeloopSplashScreen(applicationName, versionName);
                splashScreen.ShowDialog();
            });

            splashScreenThread.SetApartmentState(ApartmentState.STA);
            splashScreenThread.Start();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            startupAction?.Invoke();

            if (minimumDelay > 0)
            {
                while(stopwatch.Elapsed.TotalMilliseconds < minimumDelay)
                {
                    Thread.Sleep(100);
                }
            }

            Dispatcher.FromThread(splashScreenThread).Invoke(() => splashScreen.Close());
            splashScreenThread.Join();
        }
    }
}
