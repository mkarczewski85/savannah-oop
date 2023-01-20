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
            this.eventsLogPanel = new System.Windows.Forms.GroupBox();
            this.eventsList = new System.Windows.Forms.ListBox();
            this.legendBox = new System.Windows.Forms.GroupBox();
            this.lionLegendBox = new System.Windows.Forms.PictureBox();
            this.antelopeLegendBox = new System.Windows.Forms.PictureBox();
            this.hyenaLegendBox = new System.Windows.Forms.PictureBox();
            this.birdLegendBox = new System.Windows.Forms.PictureBox();
            this.snakeLegendBox = new System.Windows.Forms.PictureBox();
            this.snakeBirdLegendBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.densityValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedValue)).BeginInit();
            this.eventsLogPanel.SuspendLayout();
            this.legendBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lionLegendBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antelopeLegendBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyenaLegendBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdLegendBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeLegendBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeBirdLegendBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Location = new System.Drawing.Point(12, 100);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(960, 620);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1124, 740);
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
            this.btnSettings.Location = new System.Drawing.Point(968, 36);
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
            5,
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
            // eventsLogPanel
            // 
            this.eventsLogPanel.Controls.Add(this.eventsList);
            this.eventsLogPanel.Location = new System.Drawing.Point(1176, 100);
            this.eventsLogPanel.Name = "eventsLogPanel";
            this.eventsLogPanel.Size = new System.Drawing.Size(500, 353);
            this.eventsLogPanel.TabIndex = 11;
            this.eventsLogPanel.TabStop = false;
            this.eventsLogPanel.Text = "Log zdarzeń:";
            // 
            // eventsList
            // 
            this.eventsList.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eventsList.FormattingEnabled = true;
            this.eventsList.ItemHeight = 17;
            this.eventsList.Location = new System.Drawing.Point(6, 35);
            this.eventsList.Name = "eventsList";
            this.eventsList.Size = new System.Drawing.Size(488, 293);
            this.eventsList.TabIndex = 0;
            // 
            // legendBox
            // 
            this.legendBox.Controls.Add(this.label9);
            this.legendBox.Controls.Add(this.label8);
            this.legendBox.Controls.Add(this.label7);
            this.legendBox.Controls.Add(this.label6);
            this.legendBox.Controls.Add(this.label5);
            this.legendBox.Controls.Add(this.label4);
            this.legendBox.Controls.Add(this.snakeBirdLegendBox);
            this.legendBox.Controls.Add(this.snakeLegendBox);
            this.legendBox.Controls.Add(this.birdLegendBox);
            this.legendBox.Controls.Add(this.hyenaLegendBox);
            this.legendBox.Controls.Add(this.antelopeLegendBox);
            this.legendBox.Controls.Add(this.lionLegendBox);
            this.legendBox.Location = new System.Drawing.Point(1182, 493);
            this.legendBox.Name = "legendBox";
            this.legendBox.Size = new System.Drawing.Size(494, 274);
            this.legendBox.TabIndex = 12;
            this.legendBox.TabStop = false;
            this.legendBox.Text = "Legenda:";
            // 
            // lionLegendBox
            // 
            this.lionLegendBox.Location = new System.Drawing.Point(17, 59);
            this.lionLegendBox.Name = "lionLegendBox";
            this.lionLegendBox.Size = new System.Drawing.Size(48, 42);
            this.lionLegendBox.TabIndex = 0;
            this.lionLegendBox.TabStop = false;
            // 
            // antelopeLegendBox
            // 
            this.antelopeLegendBox.Location = new System.Drawing.Point(17, 124);
            this.antelopeLegendBox.Name = "antelopeLegendBox";
            this.antelopeLegendBox.Size = new System.Drawing.Size(48, 42);
            this.antelopeLegendBox.TabIndex = 13;
            this.antelopeLegendBox.TabStop = false;
            // 
            // hyenaLegendBox
            // 
            this.hyenaLegendBox.Location = new System.Drawing.Point(17, 189);
            this.hyenaLegendBox.Name = "hyenaLegendBox";
            this.hyenaLegendBox.Size = new System.Drawing.Size(48, 42);
            this.hyenaLegendBox.TabIndex = 13;
            this.hyenaLegendBox.TabStop = false;
            // 
            // birdLegendBox
            // 
            this.birdLegendBox.Location = new System.Drawing.Point(257, 59);
            this.birdLegendBox.Name = "birdLegendBox";
            this.birdLegendBox.Size = new System.Drawing.Size(48, 42);
            this.birdLegendBox.TabIndex = 13;
            this.birdLegendBox.TabStop = false;
            // 
            // snakeLegendBox
            // 
            this.snakeLegendBox.Location = new System.Drawing.Point(257, 124);
            this.snakeLegendBox.Name = "snakeLegendBox";
            this.snakeLegendBox.Size = new System.Drawing.Size(48, 42);
            this.snakeLegendBox.TabIndex = 13;
            this.snakeLegendBox.TabStop = false;
            // 
            // snakeBirdLegendBox
            // 
            this.snakeBirdLegendBox.Location = new System.Drawing.Point(257, 189);
            this.snakeBirdLegendBox.Name = "snakeBirdLegendBox";
            this.snakeBirdLegendBox.Size = new System.Drawing.Size(48, 42);
            this.snakeBirdLegendBox.TabIndex = 13;
            this.snakeBirdLegendBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Lew";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Antylopa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Hiena";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ptak Toko";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Wąż";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(311, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ptak i wąż";
            // 
            // SavannahMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1688, 867);
            this.Controls.Add(this.legendBox);
            this.Controls.Add(this.eventsLogPanel);
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
            this.eventsLogPanel.ResumeLayout(false);
            this.legendBox.ResumeLayout(false);
            this.legendBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lionLegendBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antelopeLegendBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyenaLegendBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdLegendBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeLegendBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeBirdLegendBox)).EndInit();
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
        private GroupBox eventsLogPanel;
        private ListBox eventsList;
        private GroupBox legendBox;
        private PictureBox birdLegendBox;
        private PictureBox hyenaLegendBox;
        private PictureBox antelopeLegendBox;
        private PictureBox lionLegendBox;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox snakeBirdLegendBox;
        private PictureBox snakeLegendBox;
    }
}