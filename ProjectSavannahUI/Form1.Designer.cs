namespace ProjectSavannahUI
{
    partial class SavannahMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.sizeValue = new System.Windows.Forms.NumericUpDown();
            this.densityValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.speedValue = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.densityValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedValue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 100);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(960, 620);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1124, 638);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(45, 36);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 29);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(145, 36);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 29);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Location = new System.Drawing.Point(973, 36);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(94, 29);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Parametry";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(245, 36);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(94, 29);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Stop";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // sizeValue
            // 
            this.sizeValue.Location = new System.Drawing.Point(439, 38);
            this.sizeValue.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.sizeValue.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sizeValue.Name = "sizeValue";
            this.sizeValue.Size = new System.Drawing.Size(68, 27);
            this.sizeValue.TabIndex = 5;
            this.sizeValue.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.sizeValue.ValueChanged += new System.EventHandler(this.sizeValue_ValueChanged);
            // 
            // densityValue
            // 
            this.densityValue.Location = new System.Drawing.Point(625, 38);
            this.densityValue.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.densityValue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.densityValue.Name = "densityValue";
            this.densityValue.Size = new System.Drawing.Size(68, 27);
            this.densityValue.TabIndex = 6;
            this.densityValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.densityValue.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rozmiar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pokrycie (%)";
            // 
            // speedValue
            // 
            this.speedValue.Location = new System.Drawing.Point(797, 38);
            this.speedValue.Maximum = 4;
            this.speedValue.Minimum = 1;
            this.speedValue.Name = "speedValue";
            this.speedValue.Size = new System.Drawing.Size(130, 56);
            this.speedValue.TabIndex = 9;
            this.speedValue.Value = 2;
            this.speedValue.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(723, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prędkość";
            // 
            // SavannahMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1148, 750);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.speedValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.densityValue);
            this.Controls.Add(this.sizeValue);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 620);
            this.Name = "SavannahMain";
            this.Text = "Sawanna Symulacja";
            this.Load += new System.EventHandler(this.SavannahMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.densityValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnReset;
        private Button btnStart;
        private Button btnSettings;
        private System.Windows.Forms.Timer timer1;
        private Button btnPause;
        private NumericUpDown sizeValue;
        private NumericUpDown densityValue;
        private Label label1;
        private Label label2;
        private TrackBar speedValue;
        private Label label3;
    }
}