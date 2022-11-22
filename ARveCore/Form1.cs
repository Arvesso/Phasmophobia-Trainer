using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace ARveCore
{
    public partial class TrainerForm : Form
    {
        public TrainerForm()
        {
            InitializeComponent();
        }

        private void TrainerForm_Load(object sender, EventArgs e)
        {

        }
         
        private void StartButton_Click(object sender, EventArgs e)
        {         
            StartButton.Enabled = false;
            FillProgressBar();
            CheckMemory_DLL();
            ChangeAllFunc(true, false);
            Task.Factory.StartNew(LogConsole);
        }
     
        private void UnlimitedBaseItems_CheckedChanged(object sender, EventArgs e)
        {
            CheckProcess();

            if (!Offsets.CheckBaseItemOffset())
            {
                Trainer.Logger("BaseItem offset load error", "Func: UnlimitedBaseItems", ConsoleColor.Yellow, ConsoleColor.Red);
                UnlimitedBaseItems.Checked = false;
                UnlimitedBaseItems.Enabled = false;
            }
            else if (UnlimitedBaseItems.Checked)
            {
                Trainer.UnlimitedBaseItems();
            }
            else if (!UnlimitedBaseItems.Checked)
            {
                Trainer.LimitedBaseItems();
            }
        }

        private void UnlimitedSelectedItem_CheckedChanged(object sender, EventArgs e)
        {
            CheckProcess();

            if (UnlimitedSelectedItem.Checked)
            {
                Trainer.UnlimitedSelectedItem();

                SelectedItemCounter.Text = Offsets.SelectedItem.ToString();

                if (!Offsets.CheckSelectedItemOffset())
                {
                    Trainer.Logger("Incorrect SelectedItem offset or object value is 0", "Func: UnlimitedSelectedItem", ConsoleColor.Yellow, ConsoleColor.White);
                }
            }
            else if (!UnlimitedSelectedItem.Checked)
            {
                Trainer.LimitedSelectedItem();
                SelectedItemCounter.Text = "Null";
            }
        }

        private void UnlimitedCamera_CheckedChanged(object sender, EventArgs e)
        {
            CheckProcess();

            if (UnlimitedCamera.Checked)
            {
                Trainer.UnlimitedCamera();

                if (!Offsets.CheckCameraOffset())
                {
                    Trainer.Logger("Incorrect camera offset or object value is 0", "Func: UnlimitedCamera", ConsoleColor.Yellow, ConsoleColor.White);
                }
            }
            else if (!UnlimitedCamera.Checked)
            {
                Trainer.LimitedCamera();
            }            
        }

        private void UnlimitedRadio_CheckedChanged(object sender, EventArgs e)
        {
            CheckProcess();

            if (UnlimitedRadio.Checked)
            {
                Trainer.UnlimitedRadio();

                if (!Offsets.CheckRadioOffset())
                {
                    Trainer.Logger("Incorrect radio offset or object value is 0", "Func: UnlimitedRadio", ConsoleColor.Yellow, ConsoleColor.White);
                }
            }
            else if (!UnlimitedRadio.Checked)
            {
                Trainer.LimitedRadio();
            }
        }

        private void UnlimitedNotebook_CheckedChanged(object sender, EventArgs e)
        {
            CheckProcess();

            if (UnlimitedNotebook.Checked)
            {
                Trainer.UnlimitedNotebook();

                if (!Offsets.CheckNotebookOffset())
                {
                    Trainer.Logger("Incorrect Notebook offset or object value is 0", "Func: UnlimitedNotebook", ConsoleColor.Yellow, ConsoleColor.White);
                }
            }
            else if (!UnlimitedNotebook.Checked)
            {
                Trainer.LimitedNotebook();
            }
        }

        private void UnlimitedVideoCamera_CheckedChanged(object sender, EventArgs e)
        {
            CheckProcess();

            if (UnlimitedVideoCamera.Checked)
            {
                Trainer.UnlimitedVideoCamera();

                if (!Offsets.CheckVideoCameraOffset())
                {
                    Trainer.Logger("Incorrect VideoCamera offset or object value is 0", "Func: UnlimitedVideoCamera", ConsoleColor.Yellow, ConsoleColor.White);
                }
            }
            else if (!UnlimitedVideoCamera.Checked)
            {
                Trainer.LimitedVideoCamera();
            }
        }

        private void UnlimitedEmpDetector_CheckedChanged(object sender, EventArgs e)
        {
            CheckProcess();

            if (UnlimitedEmpDetector.Checked)
            {
                Trainer.UnlimitedEmpDetector();

                if (!Offsets.CheckEmpDetectorOffset())
                {
                    Trainer.Logger("Incorrect EmpDetector offset or object value is 0", "Func: UnlimitedEmpDetector", ConsoleColor.Yellow, ConsoleColor.White);
                }
            }
            else if (!UnlimitedEmpDetector.Checked)
            {
                Trainer.LimitedEmpDetector();
            }
        }

        private void UnlimitedUvFlashlight_CheckedChanged(object sender, EventArgs e)
        {
            CheckProcess();

            if (UnlimitedUvFlashlight.Checked)
            {
                Trainer.UnlimitedUvFlashlight();

                if (!Offsets.CheckUvFlashlightOffset())
                {
                    Trainer.Logger("Incorrect UvFlashlight offset or object value is 0", "Func: UnlimitedUvFlashlight", ConsoleColor.Yellow, ConsoleColor.White);
                }
            }
            else if (!UnlimitedUvFlashlight.Checked)
            {
                Trainer.LimitedUvFlashlight();
            }
        }

        private void UnlimitedFlashlight_CheckedChanged(object sender, EventArgs e)
        {
            CheckProcess();

            if (UnlimitedFlashlight.Checked)
            {
                Trainer.UnlimitedFlashlight();

                if (!Offsets.CheckFlashlightOffset())
                {
                    Trainer.Logger("Incorrect Flashlight offset or object value is 0", "Func: UnlimitedFlashlight", ConsoleColor.Yellow, ConsoleColor.White);
                }
            }
            else if (!UnlimitedFlashlight.Checked)
            {
                Trainer.LimitedFlashlight();
            }
        }

        private void UnlimitedCandle_CheckedChanged(object sender, EventArgs e)
        {
            CheckProcess();

            if (UnlimitedCandle.Checked)
            {
                Trainer.UnlimitedCandle();

                if (!Offsets.CheckCandleOffset())
                {
                    Trainer.Logger("Incorrect Candle offset or object value is 0", "Func: UnlimitedCandle", ConsoleColor.Yellow, ConsoleColor.White);
                }
            }
            else if (!UnlimitedCandle.Checked)
            {
                Trainer.LimitedCandle();
            }
        }

        private void UnlimitedCrucifixion_CheckedChanged(object sender, EventArgs e)
        {
            CheckProcess();

            if (UnlimitedCrucifixion.Checked)
            {
                Trainer.UnlimitedCrucifixion();

                if (!Offsets.CheckCrucifixionOffset())
                {
                    Trainer.Logger("Incorrect Crucifixion offset or object value is 0", "Func: UnlimitedCrucifixion", ConsoleColor.Yellow, ConsoleColor.White);
                }
            }
            else if (!UnlimitedCrucifixion.Checked)
            {
                Trainer.LimitedCrucifixion();
            }
        }

        private void UnlimitedNeonStick_CheckedChanged(object sender, EventArgs e)
        {
            CheckProcess();

            if (UnlimitedNeonStick.Checked)
            {
                Trainer.UnlimitedNeonStick();

                if (!Offsets.CheckNeonStickOffset())
                {
                    Trainer.Logger("Incorrect NeonStick offset or object value is 0", "Func: UnlimitedNeonStick", ConsoleColor.Yellow, ConsoleColor.White);
                }
            }
            else if (!UnlimitedNeonStick.Checked)
            {
                Trainer.LimitedNeonStick();
            }
        }

        private void UnlimitedHeadMountCamera_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UnlimitedMotionSensor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UnlimitedDirectionalMicrophone_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UnlimitedSalt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UnlimitedSedative_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UnlimitedIncense_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UnlimitedSoundSensor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UnlimitedPowerfulFlashlight_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UnlimitedThermometer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UnlimitedTripod_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
