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
         

        public static string BaseItemAdress
        {
            get { return IniFile.IniReadValue("offsets", "BaseItem"); }
        }
        public static string CameraAdress
        {
            get { return IniFile.IniReadValue("offsets", "Camera"); }
        }
        public static string RadioAdress
        {
            get { return IniFile.IniReadValue("offsets", "Radio"); }
        }
        public static string NotebookAdress
        {
            get { return IniFile.IniReadValue("offsets", "Notebook"); }
        }
        public static string VideoCameraAdress
        {
            get { return IniFile.IniReadValue("offsets", "VideoCamera"); }
        }
        public static string EmpDetectorAdress
        {
            get { return IniFile.IniReadValue("offsets", "EmpDetector"); }
        }
        public static string UvFlashlightAdress
        {
            get { return IniFile.IniReadValue("offsets", "UvFlashlight"); }
        }
        public static string FlashlightAdress
        {
            get { return IniFile.IniReadValue("offsets", "Flashlight"); }
        }
        public static string CandleAdress
        {
            get { return IniFile.IniReadValue("offsets", "Candle"); }
        }
        public static string CrucifixionAdress
        {
            get { return IniFile.IniReadValue("offsets", "Crucifixion"); }
        }
        public static string NeonStickAdress
        {
            get { return IniFile.IniReadValue("offsets", "NeonStick"); }
        }
        public static string HeadMountCameraAdress
        {
            get { return IniFile.IniReadValue("offsets", "HeadMountCamera"); }
        }
        public static string MotionSensorAdress
        {
            get { return IniFile.IniReadValue("offsets", "MotionSensor"); }
        }
        public static string DirectionalMicrophoneAdress
        {
            get { return IniFile.IniReadValue("offsets", "DirectionalMicrophone"); }
        }
        public static string SaltAdress
        {
            get { return IniFile.IniReadValue("offsets", "Salt"); }
        }
        public static string SedativeAdress
        {
            get { return IniFile.IniReadValue("offsets", "Sedative"); }
        }
        public static string IncenseAdress
        {
            get { return IniFile.IniReadValue("offsets", "Incense"); }
        }
        public static string SoundSensorAdress
        {
            get { return IniFile.IniReadValue("offsets", "SoundSensor"); }
        }
        public static string PowerfulFlashlightAdress
        {
            get { return IniFile.IniReadValue("offsets", "PowerfulFlashlight"); }
        }
        public static string ThermometerAdress
        {
            get { return IniFile.IniReadValue("offsets", "Thermometer"); }
        }
        public static string TripodAdress
        {
            get { return IniFile.IniReadValue("offsets", "Tripod"); }
        }
    }
}
