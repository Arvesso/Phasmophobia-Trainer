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
        public static void LoadOffsets(Mem memoryValue)
        {
            BaseItem = memoryValue.ReadBytes(BaseItemAdress, 4);
            Camera = memoryValue.ReadInt(CameraAdress);
            Radio = memoryValue.ReadInt(RadioAdress);
            Notebook = memoryValue.ReadInt(NotebookAdress);
            VideoCamera = memoryValue.ReadInt(VideoCameraAdress);
            EmpDetector = memoryValue.ReadInt(EmpDetectorAdress);
            UvFlashlight = memoryValue.ReadInt(UvFlashlightAdress);
            Flashlight = memoryValue.ReadInt(FlashlightAdress);
            Candle = memoryValue.ReadInt(CandleAdress);
            Crucifixion = memoryValue.ReadInt(CrucifixionAdress);
            NeonStick = memoryValue.ReadInt(NeonStickAdress);
            HeadMountCamera = memoryValue.ReadInt(HeadMountCameraAdress);
            MotionSensor = memoryValue.ReadInt(MotionSensorAdress);
            DirectionalMicrophone = memoryValue.ReadInt(DirectionalMicrophoneAdress);
            Salt = memoryValue.ReadInt(SaltAdress);
            Sedative = memoryValue.ReadInt(SedativeAdress);
            Incense = memoryValue.ReadInt(IncenseAdress);
            SoundSensor = memoryValue.ReadInt(SoundSensorAdress);
            PowerfulFlashlight = memoryValue.ReadInt(PowerfulFlashlightAdress);
            Thermometer = memoryValue.ReadInt(ThermometerAdress);
            Tripod = memoryValue.ReadInt(TripodAdress);
        }

        public static bool CheckBaseItemOffset()
        {
            if (BaseItem == null)
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
    }
}
