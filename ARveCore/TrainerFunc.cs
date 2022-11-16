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
            if (!memoryPatcher.WriteMemory(Offsets.BaseItemAdress, "bytes", "90 90 90 90"))
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
            memoryPatcher.WriteBytes(Offsets.BaseItemAdress, Offsets.BaseItem);
            Logger("Deactivated", "Func: UnlimitedBaseItems", ConsoleColor.Yellow, ConsoleColor.Green);
        }

        public static void UnlimitedCamera()
        {
            UpdateItem();
            if (!memoryPatcher.FreezeValue(Offsets.CameraAdress, "int", Offsets.Camera.ToString()))
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
            memoryPatcher.UnfreezeValue(Offsets.CameraAdress);
            Logger("Deactivated", "Func: UnlimitedCamera", ConsoleColor.Yellow, ConsoleColor.Green);
        }

        public static void UnlimitedRadio()
        {
            UpdateItem();
            if (!memoryPatcher.FreezeValue(Offsets.RadioAdress, "int", Offsets.Radio.ToString()))
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
            memoryPatcher.UnfreezeValue(Offsets.RadioAdress);
            Logger("Deactivated", "Func: UnlimitedRadio", ConsoleColor.Yellow, ConsoleColor.Green);
        }
    }
}
