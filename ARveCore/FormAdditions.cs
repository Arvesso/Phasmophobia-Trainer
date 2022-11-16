using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARveCore
{
    partial class TrainerForm
    {
        private static void CheckMemory_DLL()
        {
            if (!File.Exists(Application.StartupPath + @"\Memory.dll"))
            {
                MessageBox.Show("Memory.dll file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private static Process phasmophobia;

        private static void CheckProcess()
        {
            try
            {
                phasmophobia = Process.GetProcessesByName("Phasmophobia")[0];
            }
            catch
            {
                Application.Exit();
                Thread.Sleep(1000);
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeConsole();

        private void LogConsole()
        {
            if (AllocConsole())
            {
                System.Console.Title = "Trainer log";
                if (Trainer.Start())
                {
                    ActivePanel.Hide();
                }
            }
        }

        private void ChangeAllFunc(bool uncheckedAllFunc, bool conditionAllFunc)
        {
            if (uncheckedAllFunc)
            {
                UnlimitedCamera.Checked = false;
                UnlimitedRadio.Checked = false;
                UnlimitedNotebook.Checked = false;
                UnlimitedVideoCamera.Checked = false;
            }
            UnlimitedCamera.Enabled = conditionAllFunc;
            UnlimitedRadio.Enabled = conditionAllFunc;
            UnlimitedNotebook.Enabled = conditionAllFunc;
            UnlimitedVideoCamera.Enabled = conditionAllFunc;
        }
    }
}
