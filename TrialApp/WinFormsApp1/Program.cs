using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RegisterInStartup(true);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


        public static void RegisterInStartup(bool isChecked)
        {
            //RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
            //        ("SOFTWARE\\Legendesk\\LDLog", true);
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (isChecked)
            {
                registryKey.SetValue("WinFormsApp1", Application.ExecutablePath);
            }
            else
            {
                registryKey.DeleteValue("WinFormsApp1");
            }
        }
    }
}
