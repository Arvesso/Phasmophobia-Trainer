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
            CheckMemory_DLL();
            Task.Factory.StartNew(LogConsole);
        }
     
        private void UnlimitedBaseItems_CheckedChanged(object sender, EventArgs e)
        {
            CheckProcess();

            if (!Offsets.CheckBaseItemOffset())
            {
                Trainer.Logger("BaseItem offset load error", "Func: UnlimitedBaseItems", ConsoleColor.Yellow, ConsoleColor.Red);
                UnlimitedBaseItems.Enabled = false;
            }
            else if (UnlimitedBaseItems.Checked)
            {
                ChangeAllFunc(true, false);
                Trainer.UnlimitedBaseItems();
            }
            else if (!UnlimitedBaseItems.Checked)
            {
                Trainer.LimitedBaseItems();
                ChangeAllFunc(false, true);
            }
        }

        private void UnlimitedCamera_CheckedChanged(object sender, EventArgs e)
        {
            CheckProcess();

            if (UnlimitedCamera.Checked)
            {
                Trainer.UnlimitedCamera();
            }
            else if (!UnlimitedCamera.Checked)
            {
                Trainer.LimitedCamera();
            }
            if (!Offsets.CheckCameraOffset())
            {
                Trainer.Logger("Incorrect camera offset or object value is 0", "Func: UnlimitedCamera", ConsoleColor.Yellow, ConsoleColor.White);
            }
        }

        private void UnlimitedRadio_CheckedChanged(object sender, EventArgs e)
        {
            CheckProcess();

            if (UnlimitedRadio.Checked)
            {
                Trainer.UnlimitedRadio();
            }
            else if (!UnlimitedRadio.Checked)
            {
                Trainer.LimitedRadio();
            }
        }

        private void UnlimitedNotebook_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UnlimitedVideoCamera_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
