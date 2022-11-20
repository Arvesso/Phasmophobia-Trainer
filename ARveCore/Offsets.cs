using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace ARveCore
{
    partial class Offsets
    {      
        public static void LoadOffsets(Mem memory)
        {
            BaseItem = memory.ReadBytes(BaseItemAddress, 4);
            SelectedItem = memory.ReadInt(SelectedItemAddress);
            Camera = memory.ReadInt(CameraAddress);
            Radio = memory.ReadInt(RadioAddress);
            Notebook = memory.ReadInt(NotebookAddress);
            VideoCamera = memory.ReadInt(VideoCameraAddress);
            EmpDetector = memory.ReadInt(EmpDetectorAddress);
            UvFlashlight = memory.ReadInt(UvFlashlightAddress);
            Flashlight = memory.ReadInt(FlashlightAddress);
            Candle = memory.ReadInt(CandleAddress);
            Crucifixion = memory.ReadInt(CrucifixionAddress);
            NeonStick = memory.ReadInt(NeonStickAddress);
            HeadMountCamera = memory.ReadInt(HeadMountCameraAddress);
            MotionSensor = memory.ReadInt(MotionSensorAddress);
            DirectionalMicrophone = memory.ReadInt(DirectionalMicrophoneAddress);
            Salt = memory.ReadInt(SaltAddress);
            Sedative = memory.ReadInt(SedativeAddress);
            Incense = memory.ReadInt(IncenseAddress);
            SoundSensor = memory.ReadInt(SoundSensorAddress);
            PowerfulFlashlight = memory.ReadInt(PowerfulFlashlightAddress);
            Thermometer = memory.ReadInt(ThermometerAddress);
            Tripod = memory.ReadInt(TripodAddress);
        }

        public static bool CheckBaseItemOffset()
        {
            if (BaseItem == null)
                return false;
            else
                return true;
        }
        public static bool CheckSelectedItemOffset()
        {
            if (SelectedItem == 0)
                return false;
            else
                return true;
        }
        public static bool CheckCameraOffset()
        {
            if (Camera == 0)
                return false;
            else
                return true;
        }
        public static bool CheckRadioOffset()
        {
            if (Radio == 0)
                return false;
            else
                return true;
        }
        public static bool CheckNotebookOffset()
        {
            if (Notebook == 0)
                return false;
            else
                return true;
        }
        public static bool CheckVideoCameraOffset()
        {
            if (VideoCamera == 0)
                return false;
            else
                return true;
        }
        public static bool CheckEmpDetectorOffset()
        {
            if (EmpDetector == 0)
                return false;
            else
                return true;
        }
        public static bool CheckUvFlashlightOffset()
        {
            if (UvFlashlight == 0)
                return false;
            else
                return true;
        }
        public static bool CheckFlashlightOffset()
        {
            if (Flashlight == 0)
                return false;
            else
                return true;
        }
        public static bool CheckCandleOffset()
        {
            if (Candle == 0)
                return false;
            else
                return true;
        }
        public static bool CheckCrucifixionOffset()
        {
            if (Crucifixion == 0)
                return false;
            else
                return true;
        }
        public static bool CheckNeonStickOffset()
        {
            if (NeonStick == 0)
                return false;
            else
                return true;
        }
    }
}
