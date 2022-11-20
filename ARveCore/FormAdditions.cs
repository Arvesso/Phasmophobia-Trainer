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

        private void FillProgressBar()
        {
            progressBar1.Visible = true;
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = i;
                progressBar1.Update();
                Thread.Sleep(25);
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
                Console.Title = "Trainer log";
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
                UnlimitedEmpDetector.Checked = false;
                UnlimitedUvFlashlight.Checked = false;
                UnlimitedFlashlight.Checked = false;
                UnlimitedCandle.Checked = false;
                UnlimitedCrucifixion.Checked = false;
                UnlimitedNeonStick.Checked = false;
                UnlimitedHeadMountCamera.Checked = false;
                UnlimitedMotionSensor.Checked = false;
                UnlimitedDirectionalMicrophone.Checked = false;
                UnlimitedSalt.Checked = false;
                UnlimitedSedative.Checked = false;
                UnlimitedIncense.Checked = false;
                UnlimitedSoundSensor.Checked = false;
                UnlimitedPowerfulFlashlight.Checked = false;
                UnlimitedThermometer.Checked = false;
                UnlimitedTripod.Checked = false;
            }
            UnlimitedCamera.Enabled = conditionAllFunc;
            UnlimitedRadio.Enabled = conditionAllFunc;
            UnlimitedNotebook.Enabled = conditionAllFunc;
            UnlimitedVideoCamera.Enabled = conditionAllFunc;
            UnlimitedEmpDetector.Enabled = conditionAllFunc;
            UnlimitedUvFlashlight.Enabled = conditionAllFunc;
            UnlimitedFlashlight.Enabled = conditionAllFunc;
            UnlimitedCandle.Enabled = conditionAllFunc;
            UnlimitedCrucifixion.Enabled = conditionAllFunc;
            UnlimitedNeonStick.Enabled = conditionAllFunc;
            UnlimitedHeadMountCamera.Enabled = conditionAllFunc;
            UnlimitedMotionSensor.Enabled = conditionAllFunc;
            UnlimitedDirectionalMicrophone.Enabled = conditionAllFunc;
            UnlimitedSalt.Enabled = conditionAllFunc;
            UnlimitedSedative.Enabled = conditionAllFunc;
            UnlimitedIncense.Enabled = conditionAllFunc;
            UnlimitedSoundSensor.Enabled = conditionAllFunc;
            UnlimitedPowerfulFlashlight.Enabled = conditionAllFunc;
            UnlimitedThermometer.Enabled = conditionAllFunc;
            UnlimitedTripod.Enabled = conditionAllFunc;
        }
    }
}
