
namespace life_UI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.speed = new System.Windows.Forms.Label();
            this.nudSpeedGame = new System.Windows.Forms.NumericUpDown();
            this.density = new System.Windows.Forms.Label();
            this.bStop = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.nudDensity = new System.Windows.Forms.NumericUpDown();
            this.nudResolution = new System.Windows.Forms.NumericUpDown();
            this.resolution = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bPause = new System.Windows.Forms.Button();
            this.bProceed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeedGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bProceed);
            this.splitContainer1.Panel2.Controls.Add(this.bPause);
            this.splitContainer1.Panel2.Controls.Add(this.speed);
            this.splitContainer1.Panel2.Controls.Add(this.nudSpeedGame);
            this.splitContainer1.Panel2.Controls.Add(this.density);
            this.splitContainer1.Panel2.Controls.Add(this.bStop);
            this.splitContainer1.Panel2.Controls.Add(this.bStart);
            this.splitContainer1.Panel2.Controls.Add(this.nudDensity);
            this.splitContainer1.Panel2.Controls.Add(this.nudResolution);
            this.splitContainer1.Panel2.Controls.Add(this.resolution);
            this.splitContainer1.Size = new System.Drawing.Size(1202, 553);
            this.splitContainer1.SplitterDistance = 1049;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1045, 549);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Location = new System.Drawing.Point(12, 108);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(83, 13);
            this.speed.TabIndex = 12;
            this.speed.Text = "Скорость игры";
            // 
            // nudSpeedGame
            // 
            this.nudSpeedGame.Location = new System.Drawing.Point(15, 124);
            this.nudSpeedGame.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSpeedGame.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeedGame.Name = "nudSpeedGame";
            this.nudSpeedGame.Size = new System.Drawing.Size(120, 20);
            this.nudSpeedGame.TabIndex = 11;
            this.nudSpeedGame.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // density
            // 
            this.density.AutoSize = true;
            this.density.Location = new System.Drawing.Point(12, 62);
            this.density.Name = "density";
            this.density.Size = new System.Drawing.Size(118, 13);
            this.density.TabIndex = 10;
            this.density.Text = "Плотность заселения";
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(15, 189);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(120, 23);
            this.bStop.TabIndex = 6;
            this.bStop.Text = "Стоп";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(15, 160);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(120, 23);
            this.bStart.TabIndex = 5;
            this.bStart.Text = "Старт";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // nudDensity
            // 
            this.nudDensity.Location = new System.Drawing.Point(15, 78);
            this.nudDensity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDensity.Name = "nudDensity";
            this.nudDensity.Size = new System.Drawing.Size(120, 20);
            this.nudDensity.TabIndex = 7;
            this.nudDensity.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nudResolution
            // 
            this.nudResolution.Location = new System.Drawing.Point(15, 32);
            this.nudResolution.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudResolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudResolution.Name = "nudResolution";
            this.nudResolution.Size = new System.Drawing.Size(120, 20);
            this.nudResolution.TabIndex = 9;
            this.nudResolution.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // resolution
            // 
            this.resolution.AutoSize = true;
            this.resolution.Location = new System.Drawing.Point(12, 16);
            this.resolution.Name = "resolution";
            this.resolution.Size = new System.Drawing.Size(70, 13);
            this.resolution.TabIndex = 1;
            this.resolution.Text = "Разрешение";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bPause
            // 
            this.bPause.Location = new System.Drawing.Point(15, 276);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(120, 23);
            this.bPause.TabIndex = 13;
            this.bPause.Text = "Пауза";
            this.bPause.UseVisualStyleBackColor = true;
            this.bPause.Click += new System.EventHandler(this.bPause_Click);
            // 
            // bProceed
            // 
            this.bProceed.Location = new System.Drawing.Point(15, 247);
            this.bProceed.Name = "bProceed";
            this.bProceed.Size = new System.Drawing.Size(120, 23);
            this.bProceed.TabIndex = 14;
            this.bProceed.Text = "продолжить";
            this.bProceed.UseVisualStyleBackColor = true;
            this.bProceed.Click += new System.EventHandler(this.bProceed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 553);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeedGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudResolution;
        private System.Windows.Forms.Label resolution;
        private System.Windows.Forms.NumericUpDown nudDensity;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label density;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.NumericUpDown nudSpeedGame;
        private System.Windows.Forms.Button bProceed;
        private System.Windows.Forms.Button bPause;
    }
}

