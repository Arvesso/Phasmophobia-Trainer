using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARveCore
{
    partial class Trainer
    {
        public static void UnlimitedBaseItems()
        {
            if (!memoryPatcher.WriteMemory(Offsets.BaseItemAddress, "bytes", "90 90 90 90"))
            {
                Logger("Activate error, incorrect offsets", "Func: UnlimitedBaseItems", ConsoleColor.Yellow, ConsoleColor.Red);
                return;
            }
            else
            {
                Logger("Activated", "Func: UnlimitedBaseItems", ConsoleColor.Yellow, ConsoleColor.Green);
            }
        }
        public static void LimitedBaseItems()
        {
            memoryPatcher.WriteBytes(Offsets.BaseItemAddress, Offsets.BaseItem);
            Logger("Deactivated", "Func: UnlimitedBaseItems", ConsoleColor.Yellow, ConsoleColor.Green);
        }

        public static void UnlimitedSelectedItem()
        {
            UpdateItem();

            if (!memoryPatcher.FreezeValue(Offsets.SelectedItemAddress, "int", Offsets.SelectedItem.ToString()))
            {
                Logger("Activate error, incorrect offsets", "Func: UnlimitedSelectedItem", ConsoleColor.Yellow, ConsoleColor.Red);
                return;
            }
            else
            {
                Logger("Activated", "Func: UnlimitedSelectedItem", ConsoleColor.Yellow, ConsoleColor.Green);
            }
        }
        public static void LimitedSelectedItem()
        {
            memoryPatcher.UnfreezeValue(Offsets.SelectedItemAddress);
            Logger("Deactivated", "Func: UnlimitedSelectedItem", ConsoleColor.Yellow, ConsoleColor.Green);
        }

        public static void UnlimitedCamera()
        {
            UpdateItem();
            if (!memoryPatcher.FreezeValue(Offsets.CameraAddress, "int", Offsets.Camera.ToString()))
            {
                Logger("Activate error, incorrect offsets", "Func: UnlimitedCamera", ConsoleColor.Yellow, ConsoleColor.Red);
                return;
            }
            else
            {
                Logger("Activated", "Func: UnlimitedCamera", ConsoleColor.Yellow, ConsoleColor.Green);
            }
        }
        public static void LimitedCamera()
        {
            memoryPatcher.UnfreezeValue(Offsets.CameraAddress);
            Logger("Deactivated", "Func: UnlimitedCamera", ConsoleColor.Yellow, ConsoleColor.Green);
        }

        public static void UnlimitedRadio()
        {
            UpdateItem();
            if (!memoryPatcher.FreezeValue(Offsets.RadioAddress, "int", Offsets.Radio.ToString()))
            {
                Logger("Activate error, incorrect offsets", "Func: UnlimitedRadio", ConsoleColor.Yellow, ConsoleColor.Red);
                return;
            }
            else
            {
                Logger("Activated", "Func: UnlimitedRadio", ConsoleColor.Yellow, ConsoleColor.Green);
            }
        }
        public static void LimitedRadio()
        {
            memoryPatcher.UnfreezeValue(Offsets.RadioAddress);
            Logger("Deactivated", "Func: UnlimitedRadio", ConsoleColor.Yellow, ConsoleColor.Green);
        }

        public static void UnlimitedNotebook()
        {
            UpdateItem();
            if (!memoryPatcher.FreezeValue(Offsets.NotebookAddress, "int", Offsets.Notebook.ToString()))
            {
                Logger("Activate error, incorrect offsets", "Func: UnlimitedNotebook", ConsoleColor.Yellow, ConsoleColor.Red);
                return;
            }
            else
            {
                Logger("Activated", "Func: UnlimitedNotebook", ConsoleColor.Yellow, ConsoleColor.Green);
            }
        }
        public static void LimitedNotebook()
        {
            memoryPatcher.UnfreezeValue(Offsets.NotebookAddress);
            Logger("Deactivated", "Func: UnlimitedNotebook", ConsoleColor.Yellow, ConsoleColor.Green);
        }

        public static void UnlimitedVideoCamera()
        {
            UpdateItem();
            if (!memoryPatcher.FreezeValue(Offsets.VideoCameraAddress, "int", Offsets.VideoCamera.ToString()))
            {
                Logger("Activate error, incorrect offsets", "Func: UnlimitedVideoCamera", ConsoleColor.Yellow, ConsoleColor.Red);
                return;
            }
            else
            {
                Logger("Activated", "Func: UnlimitedVideoCamera", ConsoleColor.Yellow, ConsoleColor.Green);
            }
        }
        public static void LimitedVideoCamera()
        {
            memoryPatcher.UnfreezeValue(Offsets.VideoCameraAddress);
            Logger("Deactivated", "Func: UnlimitedVideoCamera", ConsoleColor.Yellow, ConsoleColor.Green);
        }

        public static void UnlimitedEmpDetector()
        {
            UpdateItem();
            if (!memoryPatcher.FreezeValue(Offsets.EmpDetectorAddress, "int", Offsets.EmpDetector.ToString()))
            {
                Logger("Activate error, incorrect offsets", "Func: UnlimitedEmpDetector", ConsoleColor.Yellow, ConsoleColor.Red);
                return;
            }
            else
            {
                Logger("Activated", "Func: UnlimitedEmpDetector", ConsoleColor.Yellow, ConsoleColor.Green);
            }
        }
        public static void LimitedEmpDetector()
        {
            memoryPatcher.UnfreezeValue(Offsets.EmpDetectorAddress);
            Logger("Deactivated", "Func: UnlimitedEmpDetector", ConsoleColor.Yellow, ConsoleColor.Green);
        }

        public static void UnlimitedUvFlashlight()
        {
            UpdateItem();
            if (!memoryPatcher.FreezeValue(Offsets.UvFlashlightAddress, "int", Offsets.UvFlashlight.ToString()))
            {
                Logger("Activate error, incorrect offsets", "Func: UnlimitedUvFlashlight", ConsoleColor.Yellow, ConsoleColor.Red);
                return;
            }
            else
            {
                Logger("Activated", "Func: UnlimitedUvFlashlight", ConsoleColor.Yellow, ConsoleColor.Green);
            }
        }
        public static void LimitedUvFlashlight()
        {
            memoryPatcher.UnfreezeValue(Offsets.UvFlashlightAddress);
            Logger("Deactivated", "Func: UnlimitedUvFlashlight", ConsoleColor.Yellow, ConsoleColor.Green);
        }

        public static void UnlimitedFlashlight()
        {
            UpdateItem();
            if (!memoryPatcher.FreezeValue(Offsets.FlashlightAddress, "int", Offsets.Flashlight.ToString()))
            {
                Logger("Activate error, incorrect offsets", "Func: UnlimitedFlashlight", ConsoleColor.Yellow, ConsoleColor.Red);
                return;
            }
            else
            {
                Logger("Activated", "Func: UnlimitedFlashlight", ConsoleColor.Yellow, ConsoleColor.Green);
            }
        }
        public static void LimitedFlashlight()
        {
            memoryPatcher.UnfreezeValue(Offsets.FlashlightAddress);
            Logger("Deactivated", "Func: UnlimitedFlashlight", ConsoleColor.Yellow, ConsoleColor.Green);
        }

        public static void UnlimitedCandle()
        {
            UpdateItem();
            if (!memoryPatcher.FreezeValue(Offsets.CandleAddress, "int", Offsets.Candle.ToString()))
            {
                Logger("Activate error, incorrect offsets", "Func: UnlimitedCandle", ConsoleColor.Yellow, ConsoleColor.Red);
                return;
            }
            else
            {
                Logger("Activated", "Func: UnlimitedCandle", ConsoleColor.Yellow, ConsoleColor.Green);
            }
        }
        public static void LimitedCandle()
        {
            memoryPatcher.UnfreezeValue(Offsets.CandleAddress);
            Logger("Deactivated", "Func: UnlimitedCandle", ConsoleColor.Yellow, ConsoleColor.Green);
        }

        public static void UnlimitedCrucifixion()
        {
            UpdateItem();
            if (!memoryPatcher.FreezeValue(Offsets.CrucifixionAddress, "int", Offsets.Crucifixion.ToString()))
            {
                Logger("Activate error, incorrect offsets", "Func: UnlimitedCrucifixion", ConsoleColor.Yellow, ConsoleColor.Red);
                return;
            }
            else
            {
                Logger("Activated", "Func: UnlimitedCrucifixion", ConsoleColor.Yellow, ConsoleColor.Green);
            }
        }
        public static void LimitedCrucifixion()
        {
            memoryPatcher.UnfreezeValue(Offsets.CrucifixionAddress);
            Logger("Deactivated", "Func: UnlimitedCrucifixion", ConsoleColor.Yellow, ConsoleColor.Green);
        }

        public static void UnlimitedNeonStick()
        {
            UpdateItem();
            if (!memoryPatcher.FreezeValue(Offsets.NeonStickAddress, "int", Offsets.NeonStick.ToString()))
            {
                Logger("Activate error, incorrect offsets", "Func: UnlimitedNeonStick", ConsoleColor.Yellow, ConsoleColor.Red);
                return;
            }
            else
            {
                Logger("Activated", "Func: UnlimitedNeonStick", ConsoleColor.Yellow, ConsoleColor.Green);
            }
        }
        public static void LimitedNeonStick()
        {
            memoryPatcher.UnfreezeValue(Offsets.NeonStickAddress);
            Logger("Deactivated", "Func: UnlimitedNeonStick", ConsoleColor.Yellow, ConsoleColor.Green);
        }
    }
}
