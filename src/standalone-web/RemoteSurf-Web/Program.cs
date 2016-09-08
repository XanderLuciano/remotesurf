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
            lib = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"cefsharp\libcef.dll");
            browser = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"cefsharp\CefSharp.BrowserSubprocess.exe");
            locales = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"cefsharp\locales\");
            res = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"cefsharp\");
            Console.WriteLine($"lib: {lib}");
            Console.WriteLine($"browser: {browser}");
            Console.WriteLine($"locales: {locales}");
            Console.WriteLine($"res: {res}");

            AppDomain.CurrentDomain.AssemblyResolve += Resolver;

            var libraryLoader = new CefLibraryHandle(lib);
            var isValid = libraryLoader.IsInvalid;

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

        private static Assembly Resolver(object sender, ResolveEventArgs args)
        {
            if (args.Name.StartsWith("CefSharp"))
            {
                string assemblyName = args.Name.Split(new[] { ',' }, 2)[0] + ".dll";
                string archSpecificPath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase,
                                                       "cefsharp",
                                                       assemblyName);
                Console.WriteLine($"Path: {archSpecificPath}");

                return File.Exists(archSpecificPath)
                           ? Assembly.LoadFile(archSpecificPath)
                           : null;
            }

            return null;
        }
    }
}
