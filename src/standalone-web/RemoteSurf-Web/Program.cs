using CefSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteSurf
{
    static class Program
    {
        static string lib, browser, locales, res;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            lib = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"resources\cefsharp\libcef.dll");
            browser = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"resources\cefsharp\CefSharp.BrowserSubprocess.exe");
            locales = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"resources\cefsharp\locales\");
            res = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"resources\cefsharp\");

            var libraryLoader = new CefLibraryHandle(lib);
            var isValid = !libraryLoader.IsInvalid;
            Console.WriteLine($"Library is valid: {isValid}");

            LoadForm();

            libraryLoader.Dispose();
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void LoadForm()
        {
            var settings = new CefSettings();
            settings.BrowserSubprocessPath = browser;
            settings.LocalesDirPath = locales;
            settings.ResourcesDirPath = res;

            Cef.Initialize(settings, shutdownOnProcessExit: false, performDependencyCheck: false);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RemoteSurfWebForm());
        }
    }
}
