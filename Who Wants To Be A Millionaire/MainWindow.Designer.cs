namespace Who_Wants_To_Be_A_Millionaire
{
    partial class MainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.questionPanel = new System.Windows.Forms.Panel();
            this.prizePanel = new System.Windows.Forms.Panel();
            this.lifelinePanel = new System.Windows.Forms.Panel();
            this.chartPollResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.nextQuestionbtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Button();
            this.btnLifelineSwap = new System.Windows.Forms.Button();
            this.btnLifelineAudience = new System.Windows.Forms.Button();
            this.btnLifeline5050 = new System.Windows.Forms.Button();
            this.prize15 = new System.Windows.Forms.Button();
            this.prize12 = new System.Windows.Forms.Button();
            this.prize14 = new System.Windows.Forms.Button();
            this.prize1 = new System.Windows.Forms.Button();
            this.prize13 = new System.Windows.Forms.Button();
            this.prize10 = new System.Windows.Forms.Button();
            this.prize11 = new System.Windows.Forms.Button();
            this.prize5 = new System.Windows.Forms.Button();
            this.prize3 = new System.Windows.Forms.Button();
            this.prize4 = new System.Windows.Forms.Button();
            this.prize9 = new System.Windows.Forms.Button();
            this.prize2 = new System.Windows.Forms.Button();
            this.prize8 = new System.Windows.Forms.Button();
            this.prize6 = new System.Windows.Forms.Button();
            this.prize7 = new System.Windows.Forms.Button();
            this.btnOptionD = new System.Windows.Forms.Button();
            this.btnOptionC = new System.Windows.Forms.Button();
            this.btnOptionB = new System.Windows.Forms.Button();
            this.btnOptionA = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Button();
            this.questionPanel.SuspendLayout();
            this.prizePanel.SuspendLayout();
            this.lifelinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPollResults)).BeginInit();
            this.SuspendLayout();
            // 
            // questionPanel
            // 
            this.questionPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.questionPanel.BackColor = System.Drawing.Color.Black;
            this.questionPanel.Controls.Add(this.btnOptionD);
            this.questionPanel.Controls.Add(this.btnOptionC);
            this.questionPanel.Controls.Add(this.btnOptionB);
            this.questionPanel.Controls.Add(this.btnOptionA);
            this.questionPanel.Controls.Add(this.lblQuestion);
            this.questionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.questionPanel.Location = new System.Drawing.Point(0, 407);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(1111, 242);
            this.questionPanel.TabIndex = 5;
            this.questionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.questionPanel_Paint);
            // 
            // prizePanel
            // 
            this.prizePanel.BackColor = System.Drawing.Color.Transparent;
            this.prizePanel.Controls.Add(this.prize15);
            this.prizePanel.Controls.Add(this.prize12);
            this.prizePanel.Controls.Add(this.prize14);
            this.prizePanel.Controls.Add(this.prize1);
            this.prizePanel.Controls.Add(this.prize13);
            this.prizePanel.Controls.Add(this.prize10);
            this.prizePanel.Controls.Add(this.prize11);
            this.prizePanel.Controls.Add(this.prize5);
            this.prizePanel.Controls.Add(this.prize3);
            this.prizePanel.Controls.Add(this.prize4);
            this.prizePanel.Controls.Add(this.prize9);
            this.prizePanel.Controls.Add(this.prize2);
            this.prizePanel.Controls.Add(this.prize8);
            this.prizePanel.Controls.Add(this.prize6);
            this.prizePanel.Controls.Add(this.prize7);
            this.prizePanel.Location = new System.Drawing.Point(885, -7);
            this.prizePanel.Name = "prizePanel";
            this.prizePanel.Size = new System.Drawing.Size(226, 675);
            this.prizePanel.TabIndex = 21;
            this.prizePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.prizePanel_Paint);
            // 
            // lifelinePanel
            // 
            this.lifelinePanel.Controls.Add(this.btnLifelineSwap);
            this.lifelinePanel.Controls.Add(this.btnLifelineAudience);
            this.lifelinePanel.Controls.Add(this.btnLifeline5050);
            this.lifelinePanel.Location = new System.Drawing.Point(0, 0);
            this.lifelinePanel.Name = "lifelinePanel";
            this.lifelinePanel.Size = new System.Drawing.Size(128, 231);
            this.lifelinePanel.TabIndex = 24;
            // 
            // chartPollResults
            // 
            this.chartPollResults.BackColor = System.Drawing.Color.Black;
            chartArea3.AxisX.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            chartArea3.AxisY.LineWidth = 0;
            chartArea3.BackColor = System.Drawing.Color.Black;
            chartArea3.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.chartPollResults.ChartAreas.Add(chartArea3);
            this.chartPollResults.Location = new System.Drawing.Point(289, 141);
            this.chartPollResults.Name = "chartPollResults";
            this.chartPollResults.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartPollResults.Size = new System.Drawing.Size(269, 174);
            this.chartPollResults.TabIndex = 25;
            this.chartPollResults.Text = "chart1";
            this.chartPollResults.Visible = false;
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // nextQuestionbtn
            // 
            this.nextQuestionbtn.BackColor = System.Drawing.Color.Transparent;
            this.nextQuestionbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextQuestionbtn.BackgroundImage")));
            this.nextQuestionbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextQuestionbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextQuestionbtn.FlatAppearance.BorderSize = 0;
            this.nextQuestionbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.nextQuestionbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nextQuestionbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextQuestionbtn.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQuestionbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.nextQuestionbtn.Location = new System.Drawing.Point(255, 343);
            this.nextQuestionbtn.Name = "nextQuestionbtn";
            this.nextQuestionbtn.Size = new System.Drawing.Size(359, 50);
            this.nextQuestionbtn.TabIndex = 6;
            this.nextQuestionbtn.Text = "START";
            this.nextQuestionbtn.UseVisualStyleBackColor = false;
            this.nextQuestionbtn.Click += new System.EventHandler(this.nextQuestionbtn_Click);
            // 
            // timer
            // 
            this.timer.BackColor = System.Drawing.Color.Transparent;
            this.timer.BackgroundImage = global::Who_Wants_To_Be_A_Millionaire.Properties.Resources.general;
            this.timer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.timer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timer.FlatAppearance.BorderSize = 0;
            this.timer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.timer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.timer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timer.Font = new System.Drawing.Font("Maiandra GD", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.timer.Location = new System.Drawing.Point(377, 24);
            this.timer.Name = "timer";
            this.timer.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.timer.Size = new System.Drawing.Size(115, 69);
            this.timer.TabIndex = 24;
            this.timer.Text = "00";
            this.timer.UseVisualStyleBackColor = false;
            // 
            // btnLifelineSwap
            // 
            this.btnLifelineSwap.BackColor = System.Drawing.Color.Transparent;
            this.btnLifelineSwap.BackgroundImage = global::Who_Wants_To_Be_A_Millionaire.Properties.Resources.swap;
            this.btnLifelineSwap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLifelineSwap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLifelineSwap.FlatAppearance.BorderSize = 0;
            this.btnLifelineSwap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLifelineSwap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLifelineSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLifelineSwap.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLifelineSwap.Location = new System.Drawing.Point(-6, 136);
            this.btnLifelineSwap.Name = "btnLifelineSwap";
            this.btnLifelineSwap.Size = new System.Drawing.Size(115, 69);
            this.btnLifelineSwap.TabIndex = 23;
            this.btnLifelineSwap.UseVisualStyleBackColor = false;
            this.btnLifelineSwap.Click += new System.EventHandler(this.btnLifelineSwap_Click);
            // 
            // btnLifelineAudience
            // 
            this.btnLifelineAudience.BackColor = System.Drawing.Color.Transparent;
            this.btnLifelineAudience.BackgroundImage = global::Who_Wants_To_Be_A_Millionaire.Properties.Resources.audience;
            this.btnLifelineAudience.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLifelineAudience.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLifelineAudience.FlatAppearance.BorderSize = 0;
            this.btnLifelineAudience.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLifelineAudience.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLifelineAudience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLifelineAudience.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLifelineAudience.Location = new System.Drawing.Point(-6, 69);
            this.btnLifelineAudience.Name = "btnLifelineAudience";
            this.btnLifelineAudience.Size = new System.Drawing.Size(115, 69);
            this.btnLifelineAudience.TabIndex = 22;
            this.btnLifelineAudience.UseVisualStyleBackColor = false;
            this.btnLifelineAudience.Click += new System.EventHandler(this.btnLifelineAudience_Click);
            // 
            // btnLifeline5050
            // 
            this.btnLifeline5050.BackColor = System.Drawing.Color.Transparent;
            this.btnLifeline5050.BackgroundImage = global::Who_Wants_To_Be_A_Millionaire.Properties.Resources._5050;
            this.btnLifeline5050.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLifeline5050.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLifeline5050.FlatAppearance.BorderSize = 0;
            this.btnLifeline5050.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLifeline5050.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLifeline5050.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLifeline5050.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLifeline5050.Location = new System.Drawing.Point(-6, 2);
            this.btnLifeline5050.Name = "btnLifeline5050";
            this.btnLifeline5050.Size = new System.Drawing.Size(115, 69);
            this.btnLifeline5050.TabIndex = 6;
            this.btnLifeline5050.UseVisualStyleBackColor = false;
            this.btnLifeline5050.Click += new System.EventHandler(this.btnLifeline5050_Click);
            // 
            // prize15
            // 
            this.prize15.BackColor = System.Drawing.Color.Transparent;
            this.prize15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prize15.BackgroundImage")));
            this.prize15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prize15.FlatAppearance.BorderSize = 0;
            this.prize15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.prize15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.prize15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prize15.Font = new System.Drawing.Font("Maiandra GD", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prize15.ForeColor = System.Drawing.Color.Black;
            this.prize15.Location = new System.Drawing.Point(11, 22);
            this.prize15.Name = "prize15";
            this.prize15.Size = new System.Drawing.Size(205, 36);
            this.prize15.TabIndex = 25;
            this.prize15.Text = "15. £1,000,000";
            this.prize15.UseVisualStyleBackColor = false;
            // 
            // prize12
            // 
            this.prize12.BackColor = System.Drawing.Color.Transparent;
            this.prize12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prize12.BackgroundImage")));
            this.prize12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prize12.FlatAppearance.BorderSize = 0;
            this.prize12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.prize12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.prize12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prize12.Font = new System.Drawing.Font("Maiandra GD", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prize12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.prize12.Location = new System.Drawing.Point(11, 148);
            this.prize12.Name = "prize12";
            this.prize12.Size = new System.Drawing.Size(205, 36);
            this.prize12.TabIndex = 20;
            this.prize12.Text = "12. £125,000";
            this.prize12.UseVisualStyleBackColor = false;
            // 
            // prize14
            // 
            this.prize14.BackColor = System.Drawing.Color.Transparent;
            this.prize14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prize14.BackgroundImage")));
            this.prize14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prize14.FlatAppearance.BorderSize = 0;
            this.prize14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.prize14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.prize14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prize14.Font = new System.Drawing.Font("Maiandra GD", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prize14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.prize14.Location = new System.Drawing.Point(11, 64);
            this.prize14.Name = "prize14";
            this.prize14.Size = new System.Drawing.Size(205, 36);
            this.prize14.TabIndex = 12;
            this.prize14.Text = "14. £500,000";
            this.prize14.UseVisualStyleBackColor = false;
            // 
            // prize1
            // 
            this.prize1.BackColor = System.Drawing.Color.Transparent;
            this.prize1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prize1.BackgroundImage")));
            this.prize1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prize1.FlatAppearance.BorderSize = 0;
            this.prize1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.prize1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.prize1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prize1.Font = new System.Drawing.Font("Maiandra GD", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prize1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.prize1.Location = new System.Drawing.Point(11, 610);
            this.prize1.Name = "prize1";
            this.prize1.Size = new System.Drawing.Size(205, 36);
            this.prize1.TabIndex = 27;
            this.prize1.Text = "1. £100";
            this.prize1.UseVisualStyleBackColor = false;
            // 
            // prize13
            // 
            this.prize13.BackColor = System.Drawing.Color.Transparent;
            this.prize13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prize13.BackgroundImage")));
            this.prize13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prize13.FlatAppearance.BorderSize = 0;
            this.prize13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.prize13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.prize13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prize13.Font = new System.Drawing.Font("Maiandra GD", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prize13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.prize13.Location = new System.Drawing.Point(11, 106);
            this.prize13.Name = "prize13";
            this.prize13.Size = new System.Drawing.Size(205, 36);
            this.prize13.TabIndex = 24;
            this.prize13.Text = "13. £250,000";
            this.prize13.UseVisualStyleBackColor = false;
            // 
            // prize10
            // 
            this.prize10.BackColor = System.Drawing.Color.Transparent;
            this.prize10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prize10.BackgroundImage")));
            this.prize10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prize10.FlatAppearance.BorderSize = 0;
            this.prize10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.prize10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.prize10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prize10.Font = new System.Drawing.Font("Maiandra GD", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prize10.ForeColor = System.Drawing.Color.Black;
            this.prize10.Location = new System.Drawing.Point(11, 232);
            this.prize10.Name = "prize10";
            this.prize10.Size = new System.Drawing.Size(205, 36);
            this.prize10.TabIndex = 16;
            this.prize10.Text = "10. £32,000";
            this.prize10.UseVisualStyleBackColor = false;
            // 
            // prize11
            // 
            this.prize11.BackColor = System.Drawing.Color.Transparent;
            this.prize11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prize11.BackgroundImage")));
            this.prize11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prize11.FlatAppearance.BorderSize = 0;
            this.prize11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.prize11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.prize11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prize11.Font = new System.Drawing.Font("Maiandra GD", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prize11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.prize11.Location = new System.Drawing.Point(11, 190);
            this.prize11.Name = "prize11";
            this.prize11.Size = new System.Drawing.Size(205, 36);
            this.prize11.TabIndex = 17;
            this.prize11.Text = "11. £64,000";
            this.prize11.UseVisualStyleBackColor = false;
            // 
            // prize5
            // 
            this.prize5.BackColor = System.Drawing.Color.Transparent;
            this.prize5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prize5.BackgroundImage")));
            this.prize5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prize5.FlatAppearance.BorderSize = 0;
            this.prize5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.prize5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.prize5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prize5.Font = new System.Drawing.Font("Maiandra GD", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prize5.ForeColor = System.Drawing.Color.Black;
            this.prize5.Location = new System.Drawing.Point(11, 442);
            this.prize5.Name = "prize5";
            this.prize5.Size = new System.Drawing.Size(205, 36);
            this.prize5.TabIndex = 26;
            this.prize5.Text = "5. £1,000";
            this.prize5.UseVisualStyleBackColor = false;
            // 
            // prize3
            // 
            this.prize3.BackColor = System.Drawing.Color.Transparent;
            this.prize3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prize3.BackgroundImage")));
            this.prize3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prize3.FlatAppearance.BorderSize = 0;
            this.prize3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.prize3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.prize3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prize3.Font = new System.Drawing.Font("Maiandra GD", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prize3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.prize3.Location = new System.Drawing.Point(11, 526);
            this.prize3.Name = "prize3";
            this.prize3.Size = new System.Drawing.Size(205, 36);
            this.prize3.TabIndex = 22;
            this.prize3.Text = "3. £300";
            this.prize3.UseVisualStyleBackColor = false;
            // 
            // prize4
            // 
            this.prize4.BackColor = System.Drawing.Color.Transparent;
            this.prize4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prize4.BackgroundImage")));
            this.prize4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prize4.FlatAppearance.BorderSize = 0;
            this.prize4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.prize4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.prize4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prize4.Font = new System.Drawing.Font("Maiandra GD", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prize4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.prize4.Location = new System.Drawing.Point(11, 484);
            this.prize4.Name = "prize4";
            this.prize4.Size = new System.Drawing.Size(205, 36);
            this.prize4.TabIndex = 23;
            this.prize4.Text = "4. £500";
            this.prize4.UseVisualStyleBackColor = false;
            // 
            // prize9
            // 
            this.prize9.BackColor = System.Drawing.Color.Transparent;
            this.prize9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prize9.BackgroundImage")));
            this.prize9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prize9.FlatAppearance.BorderSize = 0;
            this.prize9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.prize9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.prize9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prize9.Font = new System.Drawing.Font("Maiandra GD", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prize9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.prize9.Location = new System.Drawing.Point(11, 274);
            this.prize9.Name = "prize9";
            this.prize9.Size = new System.Drawing.Size(205, 36);
            this.prize9.TabIndex = 15;
            this.prize9.Text = "9. £16,000";
            this.prize9.UseVisualStyleBackColor = false;
            // 
            // prize2
            // 
            this.prize2.BackColor = System.Drawing.Color.Transparent;
            this.prize2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prize2.BackgroundImage")));
            this.prize2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prize2.FlatAppearance.BorderSize = 0;
            this.prize2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.prize2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.prize2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prize2.Font = new System.Drawing.Font("Maiandra GD", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prize2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.prize2.Location = new System.Drawing.Point(11, 568);
            this.prize2.Name = "prize2";
            this.prize2.Size = new System.Drawing.Size(205, 36);
            this.prize2.TabIndex = 18;
            this.prize2.Text = "2. £200";
            this.prize2.UseVisualStyleBackColor = false;
            // 
            // prize8
            // 
            this.prize8.BackColor = System.Drawing.Color.Transparent;
            this.prize8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prize8.BackgroundImage")));
            this.prize8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prize8.FlatAppearance.BorderSize = 0;
            this.prize8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.prize8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.prize8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prize8.Font = new System.Drawing.Font("Maiandra GD", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prize8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.prize8.Location = new System.Drawing.Point(11, 316);
            this.prize8.Name = "prize8";
            this.prize8.Size = new System.Drawing.Size(205, 36);
            this.prize8.TabIndex = 14;
            this.prize8.Text = "8. £8,000";
            this.prize8.UseVisualStyleBackColor = false;
            // 
            // prize6
            // 
            this.prize6.BackColor = System.Drawing.Color.Transparent;
            this.prize6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prize6.BackgroundImage")));
            this.prize6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prize6.FlatAppearance.BorderSize = 0;
            this.prize6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.prize6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.prize6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prize6.Font = new System.Drawing.Font("Maiandra GD", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prize6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.prize6.Location = new System.Drawing.Point(11, 400);
            this.prize6.Name = "prize6";
            this.prize6.Size = new System.Drawing.Size(205, 36);
            this.prize6.TabIndex = 19;
            this.prize6.Text = "6. £2,000";
            this.prize6.UseVisualStyleBackColor = false;
            // 
            // prize7
            // 
            this.prize7.BackColor = System.Drawing.Color.Transparent;
            this.prize7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prize7.BackgroundImage")));
            this.prize7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prize7.FlatAppearance.BorderSize = 0;
            this.prize7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.prize7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.prize7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prize7.Font = new System.Drawing.Font("Maiandra GD", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prize7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.prize7.Location = new System.Drawing.Point(11, 358);
            this.prize7.Name = "prize7";
            this.prize7.Size = new System.Drawing.Size(205, 36);
            this.prize7.TabIndex = 13;
            this.prize7.Text = "7. £4,000";
            this.prize7.UseVisualStyleBackColor = false;
            // 
            // btnOptionD
            // 
            this.btnOptionD.BackColor = System.Drawing.Color.Transparent;
            this.btnOptionD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOptionD.BackgroundImage")));
            this.btnOptionD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOptionD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptionD.FlatAppearance.BorderSize = 0;
            this.btnOptionD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnOptionD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOptionD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionD.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnOptionD.Location = new System.Drawing.Point(437, 177);
            this.btnOptionD.Name = "btnOptionD";
            this.btnOptionD.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOptionD.Size = new System.Drawing.Size(359, 50);
            this.btnOptionD.TabIndex = 5;
            this.btnOptionD.Text = "D. ";
            this.btnOptionD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptionD.UseVisualStyleBackColor = false;
            this.btnOptionD.Click += new System.EventHandler(this.btnOptionD_Click);
            // 
            // btnOptionC
            // 
            this.btnOptionC.BackColor = System.Drawing.Color.Transparent;
            this.btnOptionC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOptionC.BackgroundImage")));
            this.btnOptionC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOptionC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptionC.FlatAppearance.BorderSize = 0;
            this.btnOptionC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnOptionC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOptionC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionC.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnOptionC.Location = new System.Drawing.Point(72, 177);
            this.btnOptionC.Name = "btnOptionC";
            this.btnOptionC.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOptionC.Size = new System.Drawing.Size(359, 50);
            this.btnOptionC.TabIndex = 4;
            this.btnOptionC.Text = "C. ";
            this.btnOptionC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptionC.UseVisualStyleBackColor = false;
            this.btnOptionC.Click += new System.EventHandler(this.btnOptionC_Click);
            // 
            // btnOptionB
            // 
            this.btnOptionB.BackColor = System.Drawing.Color.Transparent;
            this.btnOptionB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOptionB.BackgroundImage")));
            this.btnOptionB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOptionB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptionB.FlatAppearance.BorderSize = 0;
            this.btnOptionB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnOptionB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOptionB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionB.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnOptionB.Location = new System.Drawing.Point(437, 121);
            this.btnOptionB.Name = "btnOptionB";
            this.btnOptionB.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOptionB.Size = new System.Drawing.Size(359, 50);
            this.btnOptionB.TabIndex = 3;
            this.btnOptionB.Text = "B. ";
            this.btnOptionB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptionB.UseVisualStyleBackColor = false;
            this.btnOptionB.Click += new System.EventHandler(this.btnOptionB_Click);
            // 
            // btnOptionA
            // 
            this.btnOptionA.BackColor = System.Drawing.Color.Transparent;
            this.btnOptionA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOptionA.BackgroundImage")));
            this.btnOptionA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOptionA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptionA.FlatAppearance.BorderSize = 0;
            this.btnOptionA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnOptionA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOptionA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionA.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnOptionA.Location = new System.Drawing.Point(72, 121);
            this.btnOptionA.Name = "btnOptionA";
            this.btnOptionA.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOptionA.Size = new System.Drawing.Size(359, 50);
            this.btnOptionA.TabIndex = 2;
            this.btnOptionA.Text = "A. ";
            this.btnOptionA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptionA.UseVisualStyleBackColor = false;
            this.btnOptionA.Click += new System.EventHandler(this.btnOptionA_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblQuestion.BackgroundImage")));
            this.lblQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblQuestion.FlatAppearance.BorderSize = 0;
            this.lblQuestion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuestion.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblQuestion.Location = new System.Drawing.Point(45, 15);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.lblQuestion.Size = new System.Drawing.Size(778, 100);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.lblQuestion.UseVisualStyleBackColor = true;
            this.lblQuestion.TextChanged += new System.EventHandler(this.lblQuestion_TextChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1111, 649);
            this.Controls.Add(this.chartPollResults);
            this.Controls.Add(this.nextQuestionbtn);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.lifelinePanel);
            this.Controls.Add(this.prizePanel);
            this.Controls.Add(this.questionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Who Wants To Be A Millionaire";
            this.questionPanel.ResumeLayout(false);
            this.prizePanel.ResumeLayout(false);
            this.lifelinePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPollResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button lblQuestion;
        private System.Windows.Forms.Panel questionPanel;
        private System.Windows.Forms.Button prize7;
        private System.Windows.Forms.Button prize6;
        private System.Windows.Forms.Button prize8;
        private System.Windows.Forms.Button prize2;
        private System.Windows.Forms.Button prize9;
        private System.Windows.Forms.Button prize4;
        private System.Windows.Forms.Button prize3;
        private System.Windows.Forms.Button prize5;
        private System.Windows.Forms.Button prize11;
        private System.Windows.Forms.Button prize10;
        private System.Windows.Forms.Button prize13;
        private System.Windows.Forms.Button prize1;
        private System.Windows.Forms.Button prize14;
        private System.Windows.Forms.Button prize12;
        private System.Windows.Forms.Button prize15;
        private System.Windows.Forms.Panel prizePanel;
        private System.Windows.Forms.Button btnLifeline5050;
        private System.Windows.Forms.Button btnLifelineAudience;
        private System.Windows.Forms.Button btnLifelineSwap;
        private System.Windows.Forms.Panel lifelinePanel;
        private System.Windows.Forms.Button btnOptionD;
        private System.Windows.Forms.Button btnOptionC;
        private System.Windows.Forms.Button btnOptionB;
        private System.Windows.Forms.Button btnOptionA;
        private System.Windows.Forms.Button timer;
        private System.Windows.Forms.Button nextQuestionbtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPollResults;
        private System.Windows.Forms.Timer countdownTimer;
    }
}

