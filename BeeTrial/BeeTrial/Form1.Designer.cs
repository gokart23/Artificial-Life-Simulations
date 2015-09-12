namespace BeeTrial
{
    partial class Form1
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
            this.createBeehive = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.createBees = new System.Windows.Forms.Button();
            this.numberBees = new System.Windows.Forms.TextBox();
            this.createPanel = new System.Windows.Forms.Panel();
            this.hivePanel = new System.Windows.Forms.Panel();
            this.hiveTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.beesList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.isDay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hiveHoney = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.beePanel = new System.Windows.Forms.Panel();
            this.beePosition = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.beeState = new System.Windows.Forms.TextBox();
            this.beeAppetite = new System.Windows.Forms.TextBox();
            this.beeNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.clumpsList = new System.Windows.Forms.ListBox();
            this.createPanel.SuspendLayout();
            this.hivePanel.SuspendLayout();
            this.beePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // createBeehive
            // 
            this.createBeehive.Location = new System.Drawing.Point(12, 12);
            this.createBeehive.Name = "createBeehive";
            this.createBeehive.Size = new System.Drawing.Size(128, 23);
            this.createBeehive.TabIndex = 0;
            this.createBeehive.Text = "Create Beehive";
            this.createBeehive.UseVisualStyleBackColor = true;
            this.createBeehive.Click += new System.EventHandler(this.createBeehive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of bees";
            // 
            // createBees
            // 
            this.createBees.Location = new System.Drawing.Point(0, 35);
            this.createBees.Name = "createBees";
            this.createBees.Size = new System.Drawing.Size(120, 23);
            this.createBees.TabIndex = 2;
            this.createBees.Text = "Create Bees!";
            this.createBees.UseVisualStyleBackColor = true;
            this.createBees.Click += new System.EventHandler(this.createBees_Click);
            // 
            // numberBees
            // 
            this.numberBees.Location = new System.Drawing.Point(88, 9);
            this.numberBees.Name = "numberBees";
            this.numberBees.Size = new System.Drawing.Size(100, 20);
            this.numberBees.TabIndex = 3;
            // 
            // createPanel
            // 
            this.createPanel.Controls.Add(this.label1);
            this.createPanel.Controls.Add(this.numberBees);
            this.createPanel.Controls.Add(this.createBees);
            this.createPanel.Location = new System.Drawing.Point(12, 41);
            this.createPanel.Name = "createPanel";
            this.createPanel.Size = new System.Drawing.Size(199, 69);
            this.createPanel.TabIndex = 4;
            // 
            // hivePanel
            // 
            this.hivePanel.Controls.Add(this.panel1);
            this.hivePanel.Controls.Add(this.hiveTime);
            this.hivePanel.Controls.Add(this.label8);
            this.hivePanel.Controls.Add(this.beesList);
            this.hivePanel.Controls.Add(this.label5);
            this.hivePanel.Controls.Add(this.isDay);
            this.hivePanel.Controls.Add(this.label3);
            this.hivePanel.Controls.Add(this.hiveHoney);
            this.hivePanel.Controls.Add(this.label2);
            this.hivePanel.Controls.Add(this.beePanel);
            this.hivePanel.Location = new System.Drawing.Point(12, 116);
            this.hivePanel.Name = "hivePanel";
            this.hivePanel.Size = new System.Drawing.Size(385, 428);
            this.hivePanel.TabIndex = 5;
            this.hivePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.hivePanel_Paint);
            // 
            // hiveTime
            // 
            this.hiveTime.AutoSize = true;
            this.hiveTime.Location = new System.Drawing.Point(264, 10);
            this.hiveTime.Name = "hiveTime";
            this.hiveTime.Size = new System.Drawing.Size(0, 13);
            this.hiveTime.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Time: ";
            // 
            // beesList
            // 
            this.beesList.FormattingEnabled = true;
            this.beesList.Location = new System.Drawing.Point(55, 55);
            this.beesList.Name = "beesList";
            this.beesList.Size = new System.Drawing.Size(291, 147);
            this.beesList.TabIndex = 11;
            this.beesList.SelectedIndexChanged += new System.EventHandler(this.beesList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bees: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // isDay
            // 
            this.isDay.AutoSize = true;
            this.isDay.Location = new System.Drawing.Point(96, 29);
            this.isDay.Name = "isDay";
            this.isDay.Size = new System.Drawing.Size(0, 13);
            this.isDay.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time of Day: ";
            // 
            // hiveHoney
            // 
            this.hiveHoney.AutoSize = true;
            this.hiveHoney.Location = new System.Drawing.Point(96, 10);
            this.hiveHoney.Name = "hiveHoney";
            this.hiveHoney.Size = new System.Drawing.Size(0, 13);
            this.hiveHoney.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Honey in hive: ";
            // 
            // beePanel
            // 
            this.beePanel.Controls.Add(this.beePosition);
            this.beePanel.Controls.Add(this.label9);
            this.beePanel.Controls.Add(this.beeState);
            this.beePanel.Controls.Add(this.beeAppetite);
            this.beePanel.Controls.Add(this.beeNumber);
            this.beePanel.Controls.Add(this.label7);
            this.beePanel.Controls.Add(this.label6);
            this.beePanel.Controls.Add(this.label4);
            this.beePanel.Location = new System.Drawing.Point(15, 321);
            this.beePanel.Name = "beePanel";
            this.beePanel.Size = new System.Drawing.Size(352, 104);
            this.beePanel.TabIndex = 5;
            // 
            // beePosition
            // 
            this.beePosition.Enabled = false;
            this.beePosition.Location = new System.Drawing.Point(266, 10);
            this.beePosition.Name = "beePosition";
            this.beePosition.ReadOnly = true;
            this.beePosition.Size = new System.Drawing.Size(65, 20);
            this.beePosition.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Position: ";
            // 
            // beeState
            // 
            this.beeState.Enabled = false;
            this.beeState.Location = new System.Drawing.Point(91, 71);
            this.beeState.Name = "beeState";
            this.beeState.ReadOnly = true;
            this.beeState.Size = new System.Drawing.Size(100, 20);
            this.beeState.TabIndex = 5;
            // 
            // beeAppetite
            // 
            this.beeAppetite.Enabled = false;
            this.beeAppetite.Location = new System.Drawing.Point(91, 39);
            this.beeAppetite.Name = "beeAppetite";
            this.beeAppetite.ReadOnly = true;
            this.beeAppetite.Size = new System.Drawing.Size(100, 20);
            this.beeAppetite.TabIndex = 4;
            // 
            // beeNumber
            // 
            this.beeNumber.Enabled = false;
            this.beeNumber.Location = new System.Drawing.Point(91, 7);
            this.beeNumber.Name = "beeNumber";
            this.beeNumber.ReadOnly = true;
            this.beeNumber.Size = new System.Drawing.Size(100, 20);
            this.beeNumber.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "State: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Appetite: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bee number: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clumpsList);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(3, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 87);
            this.panel1.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Clumps: ";
            // 
            // clumpsList
            // 
            this.clumpsList.FormattingEnabled = true;
            this.clumpsList.Location = new System.Drawing.Point(52, 13);
            this.clumpsList.Name = "clumpsList";
            this.clumpsList.Size = new System.Drawing.Size(282, 69);
            this.clumpsList.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 556);
            this.Controls.Add(this.hivePanel);
            this.Controls.Add(this.createPanel);
            this.Controls.Add(this.createBeehive);
            this.Name = "Form1";
            this.Text = "Form1";
            this.createPanel.ResumeLayout(false);
            this.createPanel.PerformLayout();
            this.hivePanel.ResumeLayout(false);
            this.hivePanel.PerformLayout();
            this.beePanel.ResumeLayout(false);
            this.beePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createBeehive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createBees;
        private System.Windows.Forms.TextBox numberBees;
        private System.Windows.Forms.Panel createPanel;
        private System.Windows.Forms.Panel hivePanel;
        private System.Windows.Forms.ListBox beesList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label isDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hiveHoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel beePanel;
        private System.Windows.Forms.TextBox beeState;
        private System.Windows.Forms.TextBox beeAppetite;
        private System.Windows.Forms.TextBox beeNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label hiveTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox beePosition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox clumpsList;
        private System.Windows.Forms.Label label10;
    }
}

