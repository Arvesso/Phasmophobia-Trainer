using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace ARveCore
{
    partial class Trainer
    {
        private static Mem memoryPatcher = new Mem();
        private static Process phasmophobia;
        private static bool appStatus;

        private static bool CheckProcess()
        {
            try
            {
                phasmophobia = Process.GetProcessesByName("Phasmophobia")[0];              
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static int GetProcessId()
        {
            return phasmophobia.Id;
        }

        private static void OpenProcess()
        {
            if (!CheckProcess())
            {
                Logger("Phasmophobia process not found", "Error", ConsoleColor.Red, ConsoleColor.White);
                MessageBox.Show("[Phasmophobia.exe] Process not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                Logger("Phasmophobia process detected", "Info", ConsoleColor.Green, ConsoleColor.White);
                memoryPatcher.OpenProcess(GetProcessId());
                LoadOffset();
            }
        }

        private static void LoadOffset()
        {
            Logger("Start loading offsets", "Info", ConsoleColor.Green, ConsoleColor.White);

            if (!File.Exists(IniFile.codeFile))
            {
                Logger("Config file offsets.ini not found", "Error", ConsoleColor.Red, ConsoleColor.White);
                MessageBox.Show("Config file offsets.ini not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                Offsets.LoadOffsets(memoryPatcher);
                Logger("Offsets loaded", "Info", ConsoleColor.Green, ConsoleColor.White);
                Logger("Successfully", "Trainer", ConsoleColor.Magenta, ConsoleColor.Green);
                appStatus = true;
            }
        }

        public static void UpdateItem()
        {
            Offsets.LoadOffsets(memoryPatcher);
        }

        public static bool Start()
        {
            Logger("Start", "Trainer", ConsoleColor.DarkMagenta, ConsoleColor.Green);
            OpenProcess();
            return appStatus;
        }
    }
}
