﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localizer.Decompilers
{
    public class CFRZipDecompilerWrapper
    {
        public static void Decompile(string jarFileAbsolutePath, string decompiledZipPath)
        {
            Process process = new Process();
            // Configure the process using the StartInfo properties.
            process.StartInfo.FileName = "java";
            string decompilerAbsolutePath = Path.GetFullPath("Decompilers/CFRZip-0.152.jar");
            process.StartInfo.Arguments = $"-jar \"{decompilerAbsolutePath}\" \"{jarFileAbsolutePath}\" --outputzip \"{decompiledZipPath}\" --silent true --renameillegalidents true";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            process.Start();
            process.WaitForExit();// Waits here for the process to exit.
        }
    }
}
