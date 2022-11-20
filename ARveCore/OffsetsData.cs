using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARveCore
{
    partial class Offsets
    {
        public static byte[] BaseItem { get; set; }
        public static int SelectedItem { get; set; }
        public static int Camera { get; set; }
        public static int Radio { get; set; }
        public static int Notebook { get; set; }
        public static int VideoCamera { get; set; }
        public static int EmpDetector { get; set; }
        public static int UvFlashlight { get; set; }
        public static int Flashlight { get; set; }
        public static int Candle { get; set; }
        public static int Crucifixion { get; set; }
        public static int NeonStick { get; set; }
        public static int HeadMountCamera { get; set; }
        public static int MotionSensor { get; set; }
        public static int DirectionalMicrophone { get; set; }
        public static int Salt { get; set; }
        public static int Sedative { get; set; }
        public static int Incense { get; set; }
        public static int SoundSensor { get; set; }
        public static int PowerfulFlashlight { get; set; }
        public static int Thermometer { get; set; }
        public static int Tripod { get; set; }

        public static string BaseItemAddress
        {
            get { return IniFile.IniReadValue("offsets", "BaseItem"); }
        }
        public static string SelectedItemAddress
        {
            get { return IniFile.IniReadValue("offsets", "SelectedItem"); }
        }
        public static string CameraAddress
        {
            get { return IniFile.IniReadValue("offsets", "Camera"); }
        }
        public static string RadioAddress
        {
            get { return IniFile.IniReadValue("offsets", "Radio"); }
        }
        public static string NotebookAddress
        {
            get { return IniFile.IniReadValue("offsets", "Notebook"); }
        }
        public static string VideoCameraAddress
        {
            get { return IniFile.IniReadValue("offsets", "VideoCamera"); }
        }
        public static string EmpDetectorAddress
        {
            get { return IniFile.IniReadValue("offsets", "EmpDetector"); }
        }
        public static string UvFlashlightAddress
        {
            get { return IniFile.IniReadValue("offsets", "UvFlashlight"); }
        }
        public static string FlashlightAddress
        {
            get { return IniFile.IniReadValue("offsets", "Flashlight"); }
        }
        public static string CandleAddress
        {
            get { return IniFile.IniReadValue("offsets", "Candle"); }
        }
        public static string CrucifixionAddress
        {
            get { return IniFile.IniReadValue("offsets", "Crucifixion"); }
        }
        public static string NeonStickAddress
        {
            get { return IniFile.IniReadValue("offsets", "NeonStick"); }
        }
        public static string HeadMountCameraAddress
        {
            get { return IniFile.IniReadValue("offsets", "HeadMountCamera"); }
        }
        public static string MotionSensorAddress
        {
            get { return IniFile.IniReadValue("offsets", "MotionSensor"); }
        }
        public static string DirectionalMicrophoneAddress
        {
            get { return IniFile.IniReadValue("offsets", "DirectionalMicrophone"); }
        }
        public static string SaltAddress
        {
            get { return IniFile.IniReadValue("offsets", "Salt"); }
        }
        public static string SedativeAddress
        {
            get { return IniFile.IniReadValue("offsets", "Sedative"); }
        }
        public static string IncenseAddress
        {
            get { return IniFile.IniReadValue("offsets", "Incense"); }
        }
        public static string SoundSensorAddress
        {
            get { return IniFile.IniReadValue("offsets", "SoundSensor"); }
        }
        public static string PowerfulFlashlightAddress
        {
            get { return IniFile.IniReadValue("offsets", "PowerfulFlashlight"); }
        }
        public static string ThermometerAddress
        {
            get { return IniFile.IniReadValue("offsets", "Thermometer"); }
        }
        public static string TripodAddress
        {
            get { return IniFile.IniReadValue("offsets", "Tripod"); }
        }
    }
}
