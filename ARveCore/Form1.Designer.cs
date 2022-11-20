namespace ARveCore
{
    partial class TrainerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ActivePanel = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.StartButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.UnlimitedDirectionalMicrophone = new System.Windows.Forms.CheckBox();
            this.UnlimitedCandle = new System.Windows.Forms.CheckBox();
            this.UnlimitedTripod = new System.Windows.Forms.CheckBox();
            this.UnlimitedThermometer = new System.Windows.Forms.CheckBox();
            this.UnlimitedPowerfulFlashlight = new System.Windows.Forms.CheckBox();
            this.UnlimitedSoundSensor = new System.Windows.Forms.CheckBox();
            this.UnlimitedIncense = new System.Windows.Forms.CheckBox();
            this.UnlimitedSedative = new System.Windows.Forms.CheckBox();
            this.UnlimitedSalt = new System.Windows.Forms.CheckBox();
            this.UnlimitedNeonStick = new System.Windows.Forms.CheckBox();
            this.UnlimitedHeadMountCamera = new System.Windows.Forms.CheckBox();
            this.UnlimitedMotionSensor = new System.Windows.Forms.CheckBox();
            this.UnlimitedCamera = new System.Windows.Forms.CheckBox();
            this.UnlimitedCrucifixion = new System.Windows.Forms.CheckBox();
            this.UnlimitedRadio = new System.Windows.Forms.CheckBox();
            this.UnlimitedFlashlight = new System.Windows.Forms.CheckBox();
            this.UnlimitedNotebook = new System.Windows.Forms.CheckBox();
            this.UnlimitedUvFlashlight = new System.Windows.Forms.CheckBox();
            this.UnlimitedVideoCamera = new System.Windows.Forms.CheckBox();
            this.UnlimitedEmpDetector = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SelectedItemCounter = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UnlimitedSelectedItem = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UnlimitedBaseItems = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ActivePanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = global::ARveCore.Properties.Resources.back2;
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(582, 398);
            this.MainPanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ActivePanel);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(22, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 298);
            this.panel2.TabIndex = 7;
            // 
            // ActivePanel
            // 
            this.ActivePanel.Controls.Add(this.progressBar1);
            this.ActivePanel.Controls.Add(this.StartButton);
            this.ActivePanel.Location = new System.Drawing.Point(3, 3);
            this.ActivePanel.Name = "ActivePanel";
            this.ActivePanel.Size = new System.Drawing.Size(410, 290);
            this.ActivePanel.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 60);
            this.progressBar1.MarqueeAnimationSpeed = 2000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(403, 10);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StartButton.Location = new System.Drawing.Point(142, 14);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(107, 41);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.UnlimitedDirectionalMicrophone);
            this.panel4.Controls.Add(this.UnlimitedCandle);
            this.panel4.Controls.Add(this.UnlimitedTripod);
            this.panel4.Controls.Add(this.UnlimitedThermometer);
            this.panel4.Controls.Add(this.UnlimitedPowerfulFlashlight);
            this.panel4.Controls.Add(this.UnlimitedSoundSensor);
            this.panel4.Controls.Add(this.UnlimitedIncense);
            this.panel4.Controls.Add(this.UnlimitedSedative);
            this.panel4.Controls.Add(this.UnlimitedSalt);
            this.panel4.Controls.Add(this.UnlimitedNeonStick);
            this.panel4.Controls.Add(this.UnlimitedHeadMountCamera);
            this.panel4.Controls.Add(this.UnlimitedMotionSensor);
            this.panel4.Controls.Add(this.UnlimitedCamera);
            this.panel4.Controls.Add(this.UnlimitedCrucifixion);
            this.panel4.Controls.Add(this.UnlimitedRadio);
            this.panel4.Controls.Add(this.UnlimitedFlashlight);
            this.panel4.Controls.Add(this.UnlimitedNotebook);
            this.panel4.Controls.Add(this.UnlimitedUvFlashlight);
            this.panel4.Controls.Add(this.UnlimitedVideoCamera);
            this.panel4.Controls.Add(this.UnlimitedEmpDetector);
            this.panel4.Location = new System.Drawing.Point(3, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 250);
            this.panel4.TabIndex = 18;
            // 
            // UnlimitedDirectionalMicrophone
            // 
            this.UnlimitedDirectionalMicrophone.AutoSize = true;
            this.UnlimitedDirectionalMicrophone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedDirectionalMicrophone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UnlimitedDirectionalMicrophone.Location = new System.Drawing.Point(111, 58);
            this.UnlimitedDirectionalMicrophone.Name = "UnlimitedDirectionalMicrophone";
            this.UnlimitedDirectionalMicrophone.Size = new System.Drawing.Size(101, 17);
            this.UnlimitedDirectionalMicrophone.TabIndex = 29;
            this.UnlimitedDirectionalMicrophone.Text = "Dir. Microphone";
            this.UnlimitedDirectionalMicrophone.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UnlimitedDirectionalMicrophone.UseVisualStyleBackColor = true;
            this.UnlimitedDirectionalMicrophone.CheckedChanged += new System.EventHandler(this.UnlimitedDirectionalMicrophone_CheckedChanged);
            // 
            // UnlimitedCandle
            // 
            this.UnlimitedCandle.AutoSize = true;
            this.UnlimitedCandle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedCandle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UnlimitedCandle.Location = new System.Drawing.Point(11, 175);
            this.UnlimitedCandle.Name = "UnlimitedCandle";
            this.UnlimitedCandle.Size = new System.Drawing.Size(59, 17);
            this.UnlimitedCandle.TabIndex = 28;
            this.UnlimitedCandle.Text = "Candle";
            this.UnlimitedCandle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UnlimitedCandle.UseVisualStyleBackColor = true;
            this.UnlimitedCandle.CheckedChanged += new System.EventHandler(this.UnlimitedCandle_CheckedChanged);
            // 
            // UnlimitedTripod
            // 
            this.UnlimitedTripod.AutoSize = true;
            this.UnlimitedTripod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedTripod.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UnlimitedTripod.Location = new System.Drawing.Point(111, 221);
            this.UnlimitedTripod.Name = "UnlimitedTripod";
            this.UnlimitedTripod.Size = new System.Drawing.Size(56, 17);
            this.UnlimitedTripod.TabIndex = 27;
            this.UnlimitedTripod.Text = "Tripod";
            this.UnlimitedTripod.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UnlimitedTripod.UseVisualStyleBackColor = true;
            this.UnlimitedTripod.CheckedChanged += new System.EventHandler(this.UnlimitedTripod_CheckedChanged);
            // 
            // UnlimitedThermometer
            // 
            this.UnlimitedThermometer.AutoSize = true;
            this.UnlimitedThermometer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedThermometer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UnlimitedThermometer.Location = new System.Drawing.Point(111, 198);
            this.UnlimitedThermometer.Name = "UnlimitedThermometer";
            this.UnlimitedThermometer.Size = new System.Drawing.Size(88, 17);
            this.UnlimitedThermometer.TabIndex = 26;
            this.UnlimitedThermometer.Text = "Thermometer";
            this.UnlimitedThermometer.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UnlimitedThermometer.UseVisualStyleBackColor = true;
            this.UnlimitedThermometer.CheckedChanged += new System.EventHandler(this.UnlimitedThermometer_CheckedChanged);
            // 
            // UnlimitedPowerfulFlashlight
            // 
            this.UnlimitedPowerfulFlashlight.AutoSize = true;
            this.UnlimitedPowerfulFlashlight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedPowerfulFlashlight.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UnlimitedPowerfulFlashlight.Location = new System.Drawing.Point(111, 175);
            this.UnlimitedPowerfulFlashlight.Name = "UnlimitedPowerfulFlashlight";
            this.UnlimitedPowerfulFlashlight.Size = new System.Drawing.Size(91, 17);
            this.UnlimitedPowerfulFlashlight.TabIndex = 25;
            this.UnlimitedPowerfulFlashlight.Text = "Pwf. flashlight";
            this.UnlimitedPowerfulFlashlight.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UnlimitedPowerfulFlashlight.UseVisualStyleBackColor = true;
            this.UnlimitedPowerfulFlashlight.CheckedChanged += new System.EventHandler(this.UnlimitedPowerfulFlashlight_CheckedChanged);
            // 
            // UnlimitedSoundSensor
            // 
            this.UnlimitedSoundSensor.AutoSize = true;
            this.UnlimitedSoundSensor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedSoundSensor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UnlimitedSoundSensor.Location = new System.Drawing.Point(111, 152);
            this.UnlimitedSoundSensor.Name = "UnlimitedSoundSensor";
            this.UnlimitedSoundSensor.Size = new System.Drawing.Size(90, 17);
            this.UnlimitedSoundSensor.TabIndex = 24;
            this.UnlimitedSoundSensor.Text = "SoundSensor";
            this.UnlimitedSoundSensor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UnlimitedSoundSensor.UseVisualStyleBackColor = true;
            this.UnlimitedSoundSensor.CheckedChanged += new System.EventHandler(this.UnlimitedSoundSensor_CheckedChanged);
            // 
            // UnlimitedIncense
            // 
            this.UnlimitedIncense.AutoSize = true;
            this.UnlimitedIncense.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedIncense.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UnlimitedIncense.Location = new System.Drawing.Point(111, 129);
            this.UnlimitedIncense.Name = "UnlimitedIncense";
            this.UnlimitedIncense.Size = new System.Drawing.Size(64, 17);
            this.UnlimitedIncense.TabIndex = 23;
            this.UnlimitedIncense.Text = "Incense";
            this.UnlimitedIncense.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UnlimitedIncense.UseVisualStyleBackColor = true;
            this.UnlimitedIncense.CheckedChanged += new System.EventHandler(this.UnlimitedIncense_CheckedChanged);
            // 
            // UnlimitedSedative
            // 
            this.UnlimitedSedative.AutoSize = true;
            this.UnlimitedSedative.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedSedative.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UnlimitedSedative.Location = new System.Drawing.Point(111, 106);
            this.UnlimitedSedative.Name = "UnlimitedSedative";
            this.UnlimitedSedative.Size = new System.Drawing.Size(68, 17);
            this.UnlimitedSedative.TabIndex = 22;
            this.UnlimitedSedative.Text = "Sedative";
            this.UnlimitedSedative.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UnlimitedSedative.UseVisualStyleBackColor = true;
            this.UnlimitedSedative.CheckedChanged += new System.EventHandler(this.UnlimitedSedative_CheckedChanged);
            // 
            // UnlimitedSalt
            // 
            this.UnlimitedSalt.AutoSize = true;
            this.UnlimitedSalt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedSalt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UnlimitedSalt.Location = new System.Drawing.Point(111, 83);
            this.UnlimitedSalt.Name = "UnlimitedSalt";
            this.UnlimitedSalt.Size = new System.Drawing.Size(44, 17);
            this.UnlimitedSalt.TabIndex = 21;
            this.UnlimitedSalt.Text = "Salt";
            this.UnlimitedSalt.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UnlimitedSalt.UseVisualStyleBackColor = true;
            this.UnlimitedSalt.CheckedChanged += new System.EventHandler(this.UnlimitedSalt_CheckedChanged);
            // 
            // UnlimitedNeonStick
            // 
            this.UnlimitedNeonStick.AutoSize = true;
            this.UnlimitedNeonStick.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedNeonStick.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UnlimitedNeonStick.Location = new System.Drawing.Point(11, 221);
            this.UnlimitedNeonStick.Name = "UnlimitedNeonStick";
            this.UnlimitedNeonStick.Size = new System.Drawing.Size(77, 17);
            this.UnlimitedNeonStick.TabIndex = 20;
            this.UnlimitedNeonStick.Text = "Neon stick";
            this.UnlimitedNeonStick.UseVisualStyleBackColor = true;
            this.UnlimitedNeonStick.CheckedChanged += new System.EventHandler(this.UnlimitedNeonStick_CheckedChanged);
            // 
            // UnlimitedHeadMountCamera
            // 
            this.UnlimitedHeadMountCamera.AutoSize = true;
            this.UnlimitedHeadMountCamera.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedHeadMountCamera.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UnlimitedHeadMountCamera.Location = new System.Drawing.Point(111, 12);
            this.UnlimitedHeadMountCamera.Name = "UnlimitedHeadMountCamera";
            this.UnlimitedHeadMountCamera.Size = new System.Drawing.Size(90, 17);
            this.UnlimitedHeadMountCamera.TabIndex = 19;
            this.UnlimitedHeadMountCamera.Text = "Head camera";
            this.UnlimitedHeadMountCamera.UseVisualStyleBackColor = true;
            this.UnlimitedHeadMountCamera.CheckedChanged += new System.EventHandler(this.UnlimitedHeadMountCamera_CheckedChanged);
            // 
            // UnlimitedMotionSensor
            // 
            this.UnlimitedMotionSensor.AutoSize = true;
            this.UnlimitedMotionSensor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedMotionSensor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UnlimitedMotionSensor.Location = new System.Drawing.Point(111, 35);
            this.UnlimitedMotionSensor.Name = "UnlimitedMotionSensor";
            this.UnlimitedMotionSensor.Size = new System.Drawing.Size(92, 17);
            this.UnlimitedMotionSensor.TabIndex = 18;
            this.UnlimitedMotionSensor.Text = "Motion sensor";
            this.UnlimitedMotionSensor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UnlimitedMotionSensor.UseVisualStyleBackColor = true;
            this.UnlimitedMotionSensor.CheckedChanged += new System.EventHandler(this.UnlimitedMotionSensor_CheckedChanged);
            // 
            // UnlimitedCamera
            // 
            this.UnlimitedCamera.AutoSize = true;
            this.UnlimitedCamera.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedCamera.Location = new System.Drawing.Point(11, 12);
            this.UnlimitedCamera.Name = "UnlimitedCamera";
            this.UnlimitedCamera.Size = new System.Drawing.Size(62, 17);
            this.UnlimitedCamera.TabIndex = 1;
            this.UnlimitedCamera.Text = "Camera";
            this.UnlimitedCamera.UseVisualStyleBackColor = true;
            this.UnlimitedCamera.CheckedChanged += new System.EventHandler(this.UnlimitedCamera_CheckedChanged);
            // 
            // UnlimitedCrucifixion
            // 
            this.UnlimitedCrucifixion.AutoSize = true;
            this.UnlimitedCrucifixion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedCrucifixion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UnlimitedCrucifixion.Location = new System.Drawing.Point(11, 198);
            this.UnlimitedCrucifixion.Name = "UnlimitedCrucifixion";
            this.UnlimitedCrucifixion.Size = new System.Drawing.Size(74, 17);
            this.UnlimitedCrucifixion.TabIndex = 17;
            this.UnlimitedCrucifixion.Text = "Crucifixion";
            this.UnlimitedCrucifixion.UseVisualStyleBackColor = true;
            this.UnlimitedCrucifixion.CheckedChanged += new System.EventHandler(this.UnlimitedCrucifixion_CheckedChanged);
            // 
            // UnlimitedRadio
            // 
            this.UnlimitedRadio.AutoSize = true;
            this.UnlimitedRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedRadio.Location = new System.Drawing.Point(11, 35);
            this.UnlimitedRadio.Name = "UnlimitedRadio";
            this.UnlimitedRadio.Size = new System.Drawing.Size(54, 17);
            this.UnlimitedRadio.TabIndex = 9;
            this.UnlimitedRadio.Text = "Radio";
            this.UnlimitedRadio.UseVisualStyleBackColor = true;
            this.UnlimitedRadio.CheckedChanged += new System.EventHandler(this.UnlimitedRadio_CheckedChanged);
            // 
            // UnlimitedFlashlight
            // 
            this.UnlimitedFlashlight.AutoSize = true;
            this.UnlimitedFlashlight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedFlashlight.Location = new System.Drawing.Point(11, 152);
            this.UnlimitedFlashlight.Name = "UnlimitedFlashlight";
            this.UnlimitedFlashlight.Size = new System.Drawing.Size(70, 17);
            this.UnlimitedFlashlight.TabIndex = 16;
            this.UnlimitedFlashlight.Text = "Flashlight";
            this.UnlimitedFlashlight.UseVisualStyleBackColor = true;
            this.UnlimitedFlashlight.CheckedChanged += new System.EventHandler(this.UnlimitedFlashlight_CheckedChanged);
            // 
            // UnlimitedNotebook
            // 
            this.UnlimitedNotebook.AutoSize = true;
            this.UnlimitedNotebook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedNotebook.Location = new System.Drawing.Point(11, 58);
            this.UnlimitedNotebook.Name = "UnlimitedNotebook";
            this.UnlimitedNotebook.Size = new System.Drawing.Size(73, 17);
            this.UnlimitedNotebook.TabIndex = 10;
            this.UnlimitedNotebook.Text = "Notebook";
            this.UnlimitedNotebook.UseVisualStyleBackColor = true;
            this.UnlimitedNotebook.CheckedChanged += new System.EventHandler(this.UnlimitedNotebook_CheckedChanged);
            // 
            // UnlimitedUvFlashlight
            // 
            this.UnlimitedUvFlashlight.AutoSize = true;
            this.UnlimitedUvFlashlight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedUvFlashlight.Location = new System.Drawing.Point(11, 129);
            this.UnlimitedUvFlashlight.Name = "UnlimitedUvFlashlight";
            this.UnlimitedUvFlashlight.Size = new System.Drawing.Size(84, 17);
            this.UnlimitedUvFlashlight.TabIndex = 15;
            this.UnlimitedUvFlashlight.Text = "Uv flashlight";
            this.UnlimitedUvFlashlight.UseVisualStyleBackColor = true;
            this.UnlimitedUvFlashlight.CheckedChanged += new System.EventHandler(this.UnlimitedUvFlashlight_CheckedChanged);
            // 
            // UnlimitedVideoCamera
            // 
            this.UnlimitedVideoCamera.AutoSize = true;
            this.UnlimitedVideoCamera.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedVideoCamera.Location = new System.Drawing.Point(11, 83);
            this.UnlimitedVideoCamera.Name = "UnlimitedVideoCamera";
            this.UnlimitedVideoCamera.Size = new System.Drawing.Size(91, 17);
            this.UnlimitedVideoCamera.TabIndex = 11;
            this.UnlimitedVideoCamera.Text = "Video camera";
            this.UnlimitedVideoCamera.UseVisualStyleBackColor = true;
            this.UnlimitedVideoCamera.CheckedChanged += new System.EventHandler(this.UnlimitedVideoCamera_CheckedChanged);
            // 
            // UnlimitedEmpDetector
            // 
            this.UnlimitedEmpDetector.AutoSize = true;
            this.UnlimitedEmpDetector.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedEmpDetector.Location = new System.Drawing.Point(11, 106);
            this.UnlimitedEmpDetector.Name = "UnlimitedEmpDetector";
            this.UnlimitedEmpDetector.Size = new System.Drawing.Size(89, 17);
            this.UnlimitedEmpDetector.TabIndex = 14;
            this.UnlimitedEmpDetector.Text = "Emp detector";
            this.UnlimitedEmpDetector.UseVisualStyleBackColor = true;
            this.UnlimitedEmpDetector.CheckedChanged += new System.EventHandler(this.UnlimitedEmpDetector_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.SelectedItemCounter);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.UnlimitedSelectedItem);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.UnlimitedBaseItems);
            this.panel3.Location = new System.Drawing.Point(221, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 193);
            this.panel3.TabIndex = 13;
            // 
            // SelectedItemCounter
            // 
            this.SelectedItemCounter.AutoSize = true;
            this.SelectedItemCounter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectedItemCounter.Location = new System.Drawing.Point(144, 103);
            this.SelectedItemCounter.Name = "SelectedItemCounter";
            this.SelectedItemCounter.Size = new System.Drawing.Size(25, 13);
            this.SelectedItemCounter.TabIndex = 17;
            this.SelectedItemCounter.Text = "Null";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(7, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 57);
            this.label6.TabIndex = 16;
            this.label6.Text = "*Before turning on, click on the desired item in the store, then turn on the func" +
    "tion, the item will become unlimited.";
            // 
            // UnlimitedSelectedItem
            // 
            this.UnlimitedSelectedItem.AutoSize = true;
            this.UnlimitedSelectedItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedSelectedItem.Location = new System.Drawing.Point(10, 102);
            this.UnlimitedSelectedItem.Name = "UnlimitedSelectedItem";
            this.UnlimitedSelectedItem.Size = new System.Drawing.Size(146, 17);
            this.UnlimitedSelectedItem.TabIndex = 15;
            this.UnlimitedSelectedItem.Text = "Unlimited selected item -  ";
            this.UnlimitedSelectedItem.UseVisualStyleBackColor = true;
            this.UnlimitedSelectedItem.CheckedChanged += new System.EventHandler(this.UnlimitedSelectedItem_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(106, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "*Not fully tested";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(7, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 41);
            this.label4.TabIndex = 13;
            this.label4.Text = "*This function replaces 4 bytes with \"nope (4x90)\" at the item\'s static base addr" +
    "ess";
            // 
            // UnlimitedBaseItems
            // 
            this.UnlimitedBaseItems.AutoSize = true;
            this.UnlimitedBaseItems.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedBaseItems.Location = new System.Drawing.Point(10, 24);
            this.UnlimitedBaseItems.Name = "UnlimitedBaseItems";
            this.UnlimitedBaseItems.Size = new System.Drawing.Size(112, 17);
            this.UnlimitedBaseItems.TabIndex = 12;
            this.UnlimitedBaseItems.Text = "Unlimited all items ";
            this.UnlimitedBaseItems.UseVisualStyleBackColor = true;
            this.UnlimitedBaseItems.CheckedChanged += new System.EventHandler(this.UnlimitedBaseItems_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(51, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Unlimited items";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(351, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Trainer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = "PHASMOPHOBIA";
            // 
            // TrainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 398);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TrainerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phasmo Trainer";
            this.Load += new System.EventHandler(this.TrainerForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ActivePanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ActivePanel;
        private System.Windows.Forms.CheckBox UnlimitedCamera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox UnlimitedBaseItems;
        private System.Windows.Forms.CheckBox UnlimitedVideoCamera;
        private System.Windows.Forms.CheckBox UnlimitedNotebook;
        private System.Windows.Forms.CheckBox UnlimitedRadio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox UnlimitedFlashlight;
        private System.Windows.Forms.CheckBox UnlimitedUvFlashlight;
        private System.Windows.Forms.CheckBox UnlimitedCrucifixion;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox UnlimitedNeonStick;
        private System.Windows.Forms.CheckBox UnlimitedHeadMountCamera;
        private System.Windows.Forms.CheckBox UnlimitedMotionSensor;
        private System.Windows.Forms.CheckBox UnlimitedIncense;
        private System.Windows.Forms.CheckBox UnlimitedSedative;
        private System.Windows.Forms.CheckBox UnlimitedSalt;
        private System.Windows.Forms.CheckBox UnlimitedEmpDetector;
        private System.Windows.Forms.CheckBox UnlimitedTripod;
        private System.Windows.Forms.CheckBox UnlimitedThermometer;
        private System.Windows.Forms.CheckBox UnlimitedPowerfulFlashlight;
        private System.Windows.Forms.CheckBox UnlimitedSoundSensor;
        private System.Windows.Forms.CheckBox UnlimitedDirectionalMicrophone;
        private System.Windows.Forms.CheckBox UnlimitedCandle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox UnlimitedSelectedItem;
        private System.Windows.Forms.Label SelectedItemCounter;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

