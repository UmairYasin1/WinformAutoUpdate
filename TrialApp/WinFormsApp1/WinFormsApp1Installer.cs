﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    [RunInstaller(true)]
    public partial class WinFormsApp1Installer : System.Configuration.Install.Installer
    {
        public WinFormsApp1Installer()
        {
            InitializeComponent();
        }

        public override void Commit(IDictionary savedState)
        {
            base.Commit(savedState);

            Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Process.Start(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\WinFormsApp1.exe");
        }
    }
}
