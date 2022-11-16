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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ActivePanel = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UnlimitedCamera = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UnlimitedRadio = new System.Windows.Forms.CheckBox();
            this.UnlimitedNotebook = new System.Windows.Forms.CheckBox();
            this.UnlimitedVideoCamera = new System.Windows.Forms.CheckBox();
            this.UnlimitedBaseItems = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ActivePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ARveCore.Properties.Resources.back2;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 383);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ActivePanel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.UnlimitedVideoCamera);
            this.panel2.Controls.Add(this.UnlimitedNotebook);
            this.panel2.Controls.Add(this.UnlimitedRadio);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.UnlimitedCamera);
            this.panel2.Location = new System.Drawing.Point(22, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 249);
            this.panel2.TabIndex = 7;
            // 
            // ActivePanel
            // 
            this.ActivePanel.Controls.Add(this.StartButton);
            this.ActivePanel.Location = new System.Drawing.Point(3, 3);
            this.ActivePanel.Name = "ActivePanel";
            this.ActivePanel.Size = new System.Drawing.Size(410, 241);
            this.ActivePanel.TabIndex = 1;
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
            // UnlimitedCamera
            // 
            this.UnlimitedCamera.AutoSize = true;
            this.UnlimitedCamera.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedCamera.Location = new System.Drawing.Point(21, 63);
            this.UnlimitedCamera.Name = "UnlimitedCamera";
            this.UnlimitedCamera.Size = new System.Drawing.Size(62, 17);
            this.UnlimitedCamera.TabIndex = 1;
            this.UnlimitedCamera.Text = "Camera";
            this.UnlimitedCamera.UseVisualStyleBackColor = true;
            this.UnlimitedCamera.CheckedChanged += new System.EventHandler(this.UnlimitedCamera_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(351, 88);
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
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = "PHASMOPHOBIA";
            // 
            // UnlimitedRadio
            // 
            this.UnlimitedRadio.AutoSize = true;
            this.UnlimitedRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedRadio.Location = new System.Drawing.Point(21, 86);
            this.UnlimitedRadio.Name = "UnlimitedRadio";
            this.UnlimitedRadio.Size = new System.Drawing.Size(54, 17);
            this.UnlimitedRadio.TabIndex = 9;
            this.UnlimitedRadio.Text = "Radio";
            this.UnlimitedRadio.UseVisualStyleBackColor = true;
            this.UnlimitedRadio.CheckedChanged += new System.EventHandler(this.UnlimitedRadio_CheckedChanged);
            // 
            // UnlimitedNotebook
            // 
            this.UnlimitedNotebook.AutoSize = true;
            this.UnlimitedNotebook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedNotebook.Location = new System.Drawing.Point(21, 109);
            this.UnlimitedNotebook.Name = "UnlimitedNotebook";
            this.UnlimitedNotebook.Size = new System.Drawing.Size(73, 17);
            this.UnlimitedNotebook.TabIndex = 10;
            this.UnlimitedNotebook.Text = "Notebook";
            this.UnlimitedNotebook.UseVisualStyleBackColor = true;
            this.UnlimitedNotebook.CheckedChanged += new System.EventHandler(this.UnlimitedNotebook_CheckedChanged);
            // 
            // UnlimitedVideoCamera
            // 
            this.UnlimitedVideoCamera.AutoSize = true;
            this.UnlimitedVideoCamera.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnlimitedVideoCamera.Location = new System.Drawing.Point(21, 132);
            this.UnlimitedVideoCamera.Name = "UnlimitedVideoCamera";
            this.UnlimitedVideoCamera.Size = new System.Drawing.Size(91, 17);
            this.UnlimitedVideoCamera.TabIndex = 11;
            this.UnlimitedVideoCamera.Text = "Video camera";
            this.UnlimitedVideoCamera.UseVisualStyleBackColor = true;
            this.UnlimitedVideoCamera.CheckedChanged += new System.EventHandler(this.UnlimitedVideoCamera_CheckedChanged);
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
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.UnlimitedBaseItems);
            this.panel3.Location = new System.Drawing.Point(212, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 87);
            this.panel3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(7, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 42);
            this.label4.TabIndex = 13;
            this.label4.Text = "*This function replaces 4 bytes with \"nope (4x90)\" at the item\'s static base addr" +
    "ess";
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
            // TrainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 383);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TrainerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phasmo Trainer";
            this.Load += new System.EventHandler(this.TrainerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ActivePanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel panel1;
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
    }
}

