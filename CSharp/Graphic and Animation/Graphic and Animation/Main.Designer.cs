namespace Graphic_and_Animation
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbTitle = new System.Windows.Forms.Label();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.lbNow = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.CtrlTimer = new System.Windows.Forms.Timer(this.components);
            this.lbMotor = new System.Windows.Forms.Label();
            this.btDirection = new System.Windows.Forms.Button();
            this.tbSetLevel = new System.Windows.Forms.TextBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.lbLevel = new System.Windows.Forms.Label();
            this.pbMotor = new System.Windows.Forms.PictureBox();
            this.pbAgitator = new System.Windows.Forms.PictureBox();
            this.pbDirection = new System.Windows.Forms.PictureBox();
            this.pbScrew = new System.Windows.Forms.PictureBox();
            this.pbStart = new System.Windows.Forms.PictureBox();
            this.lbForStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgitator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScrew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(202, 30);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(393, 25);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "TANK MONITORING AND CONTROL";
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 1000;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // lbNow
            // 
            this.lbNow.AutoSize = true;
            this.lbNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNow.Location = new System.Drawing.Point(312, 67);
            this.lbNow.Name = "lbNow";
            this.lbNow.Size = new System.Drawing.Size(164, 18);
            this.lbNow.TabIndex = 1;
            this.lbNow.Text = "##/##/#### ##:##:## XX";
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(51, 141);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(67, 26);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btStart_MouseDown);
            this.btStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btStart_MouseUp);
            // 
            // btStop
            // 
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStop.Location = new System.Drawing.Point(51, 189);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(67, 26);
            this.btStop.TabIndex = 3;
            this.btStop.Text = "STOP";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btStop_MouseDown);
            this.btStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btStop_MouseUp);
            // 
            // CtrlTimer
            // 
            this.CtrlTimer.Enabled = true;
            this.CtrlTimer.Tick += new System.EventHandler(this.CtrlTimer_Tick);
            // 
            // lbMotor
            // 
            this.lbMotor.AutoSize = true;
            this.lbMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotor.Location = new System.Drawing.Point(189, 255);
            this.lbMotor.Name = "lbMotor";
            this.lbMotor.Size = new System.Drawing.Size(39, 20);
            this.lbMotor.TabIndex = 4;
            this.lbMotor.Text = "###";
            // 
            // btDirection
            // 
            this.btDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDirection.Location = new System.Drawing.Point(499, 141);
            this.btDirection.Name = "btDirection";
            this.btDirection.Size = new System.Drawing.Size(96, 26);
            this.btDirection.TabIndex = 5;
            this.btDirection.Text = "DIRECTION";
            this.btDirection.UseVisualStyleBackColor = true;
            this.btDirection.Click += new System.EventHandler(this.btDirection_Click);
            // 
            // tbSetLevel
            // 
            this.tbSetLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSetLevel.Location = new System.Drawing.Point(499, 233);
            this.tbSetLevel.Name = "tbSetLevel";
            this.tbSetLevel.Size = new System.Drawing.Size(100, 22);
            this.tbSetLevel.TabIndex = 6;
            this.tbSetLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSetLevel_KeyDown);
            // 
            // btConfirm
            // 
            this.btConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.Location = new System.Drawing.Point(615, 232);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(76, 26);
            this.btConfirm.TabIndex = 7;
            this.btConfirm.Text = "COMFIRM";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.Location = new System.Drawing.Point(499, 272);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(28, 16);
            this.lbLevel.TabIndex = 8;
            this.lbLevel.Text = "###";
            // 
            // pbMotor
            // 
            this.pbMotor.Location = new System.Drawing.Point(140, 327);
            this.pbMotor.Name = "pbMotor";
            this.pbMotor.Size = new System.Drawing.Size(100, 82);
            this.pbMotor.TabIndex = 9;
            this.pbMotor.TabStop = false;
            // 
            // pbAgitator
            // 
            this.pbAgitator.BackColor = System.Drawing.Color.Transparent;
            this.pbAgitator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAgitator.Location = new System.Drawing.Point(51, 342);
            this.pbAgitator.Name = "pbAgitator";
            this.pbAgitator.Size = new System.Drawing.Size(72, 131);
            this.pbAgitator.TabIndex = 10;
            this.pbAgitator.TabStop = false;
            // 
            // pbDirection
            // 
            this.pbDirection.BackColor = System.Drawing.Color.Transparent;
            this.pbDirection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDirection.Location = new System.Drawing.Point(615, 141);
            this.pbDirection.Name = "pbDirection";
            this.pbDirection.Size = new System.Drawing.Size(46, 85);
            this.pbDirection.TabIndex = 11;
            this.pbDirection.TabStop = false;
            this.pbDirection.Click += new System.EventHandler(this.pbDirection_Click);
            // 
            // pbScrew
            // 
            this.pbScrew.BackColor = System.Drawing.Color.Transparent;
            this.pbScrew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbScrew.Location = new System.Drawing.Point(140, 424);
            this.pbScrew.Name = "pbScrew";
            this.pbScrew.Size = new System.Drawing.Size(140, 49);
            this.pbScrew.TabIndex = 12;
            this.pbScrew.TabStop = false;
            // 
            // pbStart
            // 
            this.pbStart.BackColor = System.Drawing.Color.Transparent;
            this.pbStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbStart.Location = new System.Drawing.Point(157, 141);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(47, 41);
            this.pbStart.TabIndex = 13;
            this.pbStart.TabStop = false;
            this.pbStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbStart_MouseDown);
            this.pbStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbStart_MouseUp);
            // 
            // lbForStatus
            // 
            this.lbForStatus.AutoSize = true;
            this.lbForStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForStatus.Location = new System.Drawing.Point(51, 255);
            this.lbForStatus.Name = "lbForStatus";
            this.lbForStatus.Size = new System.Drawing.Size(109, 20);
            this.lbForStatus.TabIndex = 14;
            this.lbForStatus.Text = "Motor State:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.lbForStatus);
            this.Controls.Add(this.pbStart);
            this.Controls.Add(this.pbScrew);
            this.Controls.Add(this.pbDirection);
            this.Controls.Add(this.pbAgitator);
            this.Controls.Add(this.pbMotor);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.tbSetLevel);
            this.Controls.Add(this.btDirection);
            this.Controls.Add(this.lbMotor);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lbNow);
            this.Controls.Add(this.lbTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "SCADA with CSharp";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgitator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScrew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Label lbNow;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Timer CtrlTimer;
        private System.Windows.Forms.Label lbMotor;
        private System.Windows.Forms.Button btDirection;
        private System.Windows.Forms.TextBox tbSetLevel;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.PictureBox pbMotor;
        private System.Windows.Forms.PictureBox pbAgitator;
        private System.Windows.Forms.PictureBox pbDirection;
        private System.Windows.Forms.PictureBox pbScrew;
        private System.Windows.Forms.PictureBox pbStart;
        private System.Windows.Forms.Label lbForStatus;
    }
}

