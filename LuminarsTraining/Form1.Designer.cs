namespace LuminarsTraining
{
    partial class Form1
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
            Label label2;
            label1 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            PlayerName = new Label();
            KillsLabelCount = new Label();
            DeathsLabelCount = new Label();
            RetreatsLabelCount = new Label();
            button3 = new Button();
            KillButtonPlus = new Button();
            KillButtonMinus = new Button();
            DeathButtonPlus = new Button();
            DeathButtonMinus = new Button();
            RetreatButtonPlus = new Button();
            RetreatButtonMinus = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button4 = new Button();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            listBox5 = new ListBox();
            label13 = new Label();
            MadeRetreatMinus = new Button();
            MadeRetreatLabel = new Label();
            MadeRetreatPlus = new Button();
            listBox6 = new ListBox();
            textBox2 = new TextBox();
            button6 = new Button();
            button7 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 18F);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(12, 398);
            label2.Name = "label2";
            label2.Size = new Size(336, 37);
            label2.TabIndex = 5;
            label2.Text = "Current Luminar Selected";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(469, 51);
            label1.TabIndex = 0;
            label1.Text = "Luminars Training System";
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.WindowFrame;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.ForeColor = Color.Silver;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 18;
            listBox1.Location = new Point(12, 94);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(197, 198);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Corbel", 9F);
            button1.ForeColor = Color.Silver;
            button1.Location = new Point(12, 308);
            button1.Name = "button1";
            button1.Size = new Size(197, 29);
            button1.TabIndex = 2;
            button1.Text = "Remove Selected Player";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.WindowFrame;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(112, 345);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 27);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Corbel", 9F);
            button2.ForeColor = Color.Silver;
            button2.Location = new Point(12, 343);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Add Player";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 18F);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(12, 434);
            label3.Name = "label3";
            label3.Size = new Size(101, 37);
            label3.TabIndex = 6;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Corbel", 18F);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(13, 502);
            label4.Name = "label4";
            label4.Size = new Size(76, 37);
            label4.TabIndex = 7;
            label4.Text = "Kills:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Corbel", 18F);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(13, 643);
            label5.Name = "label5";
            label5.Size = new Size(113, 37);
            label5.TabIndex = 8;
            label5.Text = "Deaths:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Corbel", 18F);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(12, 575);
            label6.Name = "label6";
            label6.Size = new Size(129, 37);
            label6.TabIndex = 9;
            label6.Text = "Retreats:";
            // 
            // PlayerName
            // 
            PlayerName.AutoSize = true;
            PlayerName.Font = new Font("Corbel", 18F);
            PlayerName.ForeColor = Color.Silver;
            PlayerName.Location = new Point(13, 466);
            PlayerName.Name = "PlayerName";
            PlayerName.Size = new Size(65, 37);
            PlayerName.TabIndex = 10;
            PlayerName.Text = "N/A";
            // 
            // KillsLabelCount
            // 
            KillsLabelCount.AutoSize = true;
            KillsLabelCount.Font = new Font("Corbel", 18F);
            KillsLabelCount.ForeColor = Color.Silver;
            KillsLabelCount.Location = new Point(49, 536);
            KillsLabelCount.Name = "KillsLabelCount";
            KillsLabelCount.Size = new Size(32, 37);
            KillsLabelCount.TabIndex = 11;
            KillsLabelCount.Text = "0";
            KillsLabelCount.Click += KillsLabelCount_Click;
            // 
            // DeathsLabelCount
            // 
            DeathsLabelCount.AutoSize = true;
            DeathsLabelCount.Font = new Font("Corbel", 18F);
            DeathsLabelCount.ForeColor = Color.Silver;
            DeathsLabelCount.Location = new Point(51, 683);
            DeathsLabelCount.Name = "DeathsLabelCount";
            DeathsLabelCount.Size = new Size(32, 37);
            DeathsLabelCount.TabIndex = 12;
            DeathsLabelCount.Text = "0";
            // 
            // RetreatsLabelCount
            // 
            RetreatsLabelCount.AutoSize = true;
            RetreatsLabelCount.Font = new Font("Corbel", 18F);
            RetreatsLabelCount.ForeColor = Color.Silver;
            RetreatsLabelCount.Location = new Point(51, 612);
            RetreatsLabelCount.Name = "RetreatsLabelCount";
            RetreatsLabelCount.Size = new Size(32, 37);
            RetreatsLabelCount.TabIndex = 13;
            RetreatsLabelCount.Text = "0";
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Corbel", 9F);
            button3.ForeColor = Color.Silver;
            button3.Location = new Point(1078, 363);
            button3.Name = "button3";
            button3.Size = new Size(161, 29);
            button3.TabIndex = 14;
            button3.Text = "Reset Current Round";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // KillButtonPlus
            // 
            KillButtonPlus.BackColor = Color.FromArgb(224, 224, 224);
            KillButtonPlus.FlatStyle = FlatStyle.Flat;
            KillButtonPlus.ForeColor = Color.Black;
            KillButtonPlus.Location = new Point(15, 541);
            KillButtonPlus.Name = "KillButtonPlus";
            KillButtonPlus.Size = new Size(30, 29);
            KillButtonPlus.TabIndex = 15;
            KillButtonPlus.Text = "+";
            KillButtonPlus.UseVisualStyleBackColor = false;
            KillButtonPlus.Click += KillButtonPlus_Click;
            // 
            // KillButtonMinus
            // 
            KillButtonMinus.BackColor = Color.FromArgb(224, 224, 224);
            KillButtonMinus.FlatStyle = FlatStyle.Flat;
            KillButtonMinus.Location = new Point(89, 541);
            KillButtonMinus.Name = "KillButtonMinus";
            KillButtonMinus.Size = new Size(30, 29);
            KillButtonMinus.TabIndex = 16;
            KillButtonMinus.Text = "-";
            KillButtonMinus.UseVisualStyleBackColor = false;
            KillButtonMinus.Click += KillButtonMinus_Click;
            // 
            // DeathButtonPlus
            // 
            DeathButtonPlus.BackColor = Color.FromArgb(224, 224, 224);
            DeathButtonPlus.FlatStyle = FlatStyle.Flat;
            DeathButtonPlus.Location = new Point(15, 687);
            DeathButtonPlus.Name = "DeathButtonPlus";
            DeathButtonPlus.Size = new Size(30, 29);
            DeathButtonPlus.TabIndex = 17;
            DeathButtonPlus.Text = "+";
            DeathButtonPlus.UseVisualStyleBackColor = false;
            DeathButtonPlus.Click += DeathButtonPlus_Click;
            // 
            // DeathButtonMinus
            // 
            DeathButtonMinus.BackColor = Color.FromArgb(224, 224, 224);
            DeathButtonMinus.FlatStyle = FlatStyle.Flat;
            DeathButtonMinus.Location = new Point(89, 687);
            DeathButtonMinus.Name = "DeathButtonMinus";
            DeathButtonMinus.Size = new Size(30, 29);
            DeathButtonMinus.TabIndex = 18;
            DeathButtonMinus.Text = "-";
            DeathButtonMinus.UseVisualStyleBackColor = false;
            DeathButtonMinus.Click += DeathButtonMinus_Click;
            // 
            // RetreatButtonPlus
            // 
            RetreatButtonPlus.BackColor = Color.FromArgb(224, 224, 224);
            RetreatButtonPlus.FlatStyle = FlatStyle.Flat;
            RetreatButtonPlus.Location = new Point(15, 616);
            RetreatButtonPlus.Name = "RetreatButtonPlus";
            RetreatButtonPlus.Size = new Size(30, 29);
            RetreatButtonPlus.TabIndex = 19;
            RetreatButtonPlus.Text = "+";
            RetreatButtonPlus.UseVisualStyleBackColor = false;
            RetreatButtonPlus.Click += RetreatButtonPlus_Click;
            // 
            // RetreatButtonMinus
            // 
            RetreatButtonMinus.BackColor = Color.FromArgb(224, 224, 224);
            RetreatButtonMinus.FlatStyle = FlatStyle.Flat;
            RetreatButtonMinus.Location = new Point(89, 616);
            RetreatButtonMinus.Name = "RetreatButtonMinus";
            RetreatButtonMinus.Size = new Size(30, 29);
            RetreatButtonMinus.TabIndex = 20;
            RetreatButtonMinus.Text = "-";
            RetreatButtonMinus.UseVisualStyleBackColor = false;
            RetreatButtonMinus.Click += RetreatButtonMinus_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Corbel", 18F);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(921, 94);
            label7.Name = "label7";
            label7.Size = new Size(105, 37);
            label7.TabIndex = 23;
            label7.Text = "Names";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Corbel", 18F);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(1264, 94);
            label8.Name = "label8";
            label8.Size = new Size(122, 37);
            label8.TabIndex = 24;
            label8.Text = "K/D/R/M";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Corbel", 18F);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(1092, 94);
            label9.Name = "label9";
            label9.Size = new Size(122, 37);
            label9.TabIndex = 26;
            label9.Text = "K/D/R/M";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Corbel", 18F);
            label10.ForeColor = Color.Silver;
            label10.Location = new Point(1109, 58);
            label10.Name = "label10";
            label10.Size = new Size(112, 37);
            label10.TabIndex = 28;
            label10.Text = "Current";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Corbel", 18F);
            label11.ForeColor = Color.Silver;
            label11.Location = new Point(1295, 58);
            label11.Name = "label11";
            label11.Size = new Size(80, 37);
            label11.TabIndex = 29;
            label11.Text = "Total";
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Corbel", 9F);
            button4.ForeColor = Color.Silver;
            button4.Location = new Point(371, 179);
            button4.Name = "button4";
            button4.Size = new Size(195, 29);
            button4.TabIndex = 30;
            button4.Text = "Enter Warning for Selected";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // listBox2
            // 
            listBox2.BackColor = SystemColors.WindowFrame;
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.Font = new Font("Corbel", 9F);
            listBox2.ForeColor = Color.Silver;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 18;
            listBox2.Location = new Point(877, 133);
            listBox2.Name = "listBox2";
            listBox2.SelectionMode = SelectionMode.None;
            listBox2.Size = new Size(199, 216);
            listBox2.TabIndex = 31;
            // 
            // listBox3
            // 
            listBox3.BackColor = SystemColors.WindowFrame;
            listBox3.BorderStyle = BorderStyle.None;
            listBox3.Font = new Font("Corbel", 9F);
            listBox3.ForeColor = Color.Silver;
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 18;
            listBox3.Location = new Point(1092, 133);
            listBox3.Name = "listBox3";
            listBox3.SelectionMode = SelectionMode.None;
            listBox3.Size = new Size(157, 216);
            listBox3.TabIndex = 32;
            // 
            // listBox4
            // 
            listBox4.BackColor = SystemColors.WindowFrame;
            listBox4.BorderStyle = BorderStyle.None;
            listBox4.Font = new Font("Corbel", 9F);
            listBox4.ForeColor = Color.Silver;
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 18;
            listBox4.Location = new Point(1264, 133);
            listBox4.Name = "listBox4";
            listBox4.SelectionMode = SelectionMode.None;
            listBox4.Size = new Size(157, 216);
            listBox4.TabIndex = 33;
            // 
            // listBox5
            // 
            listBox5.BackColor = SystemColors.WindowFrame;
            listBox5.BorderStyle = BorderStyle.None;
            listBox5.Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox5.ForeColor = Color.Maroon;
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 18;
            listBox5.Location = new Point(215, 94);
            listBox5.Name = "listBox5";
            listBox5.SelectionMode = SelectionMode.None;
            listBox5.Size = new Size(68, 198);
            listBox5.TabIndex = 34;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Corbel", 18F);
            label13.ForeColor = Color.Silver;
            label13.Location = new Point(12, 715);
            label13.Name = "label13";
            label13.Size = new Size(206, 37);
            label13.TabIndex = 36;
            label13.Text = "Made Retreats:";
            // 
            // MadeRetreatMinus
            // 
            MadeRetreatMinus.BackColor = Color.FromArgb(224, 224, 224);
            MadeRetreatMinus.FlatStyle = FlatStyle.Flat;
            MadeRetreatMinus.Location = new Point(89, 754);
            MadeRetreatMinus.Name = "MadeRetreatMinus";
            MadeRetreatMinus.Size = new Size(30, 29);
            MadeRetreatMinus.TabIndex = 37;
            MadeRetreatMinus.Text = "-";
            MadeRetreatMinus.UseVisualStyleBackColor = false;
            MadeRetreatMinus.Click += MadeRetreatMinus_Click;
            // 
            // MadeRetreatLabel
            // 
            MadeRetreatLabel.AutoSize = true;
            MadeRetreatLabel.Font = new Font("Corbel", 18F);
            MadeRetreatLabel.ForeColor = Color.Silver;
            MadeRetreatLabel.Location = new Point(51, 747);
            MadeRetreatLabel.Name = "MadeRetreatLabel";
            MadeRetreatLabel.Size = new Size(32, 37);
            MadeRetreatLabel.TabIndex = 38;
            MadeRetreatLabel.Text = "0";
            // 
            // MadeRetreatPlus
            // 
            MadeRetreatPlus.BackColor = Color.FromArgb(224, 224, 224);
            MadeRetreatPlus.FlatStyle = FlatStyle.Flat;
            MadeRetreatPlus.Location = new Point(15, 754);
            MadeRetreatPlus.Name = "MadeRetreatPlus";
            MadeRetreatPlus.Size = new Size(30, 29);
            MadeRetreatPlus.TabIndex = 39;
            MadeRetreatPlus.Text = "+";
            MadeRetreatPlus.UseVisualStyleBackColor = false;
            MadeRetreatPlus.Click += MadeRetreatPlus_Click;
            // 
            // listBox6
            // 
            listBox6.BackColor = SystemColors.WindowFrame;
            listBox6.BorderStyle = BorderStyle.None;
            listBox6.Font = new Font("Corbel", 9F);
            listBox6.ForeColor = Color.Silver;
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 18;
            listBox6.Location = new Point(822, 499);
            listBox6.Name = "listBox6";
            listBox6.SelectionMode = SelectionMode.None;
            listBox6.Size = new Size(640, 270);
            listBox6.TabIndex = 40;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.WindowFrame;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Corbel", 9F);
            textBox2.ForeColor = Color.Silver;
            textBox2.Location = new Point(390, 94);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(392, 79);
            textBox2.TabIndex = 41;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button6
            // 
            button6.BackColor = Color.SteelBlue;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Corbel", 9F);
            button6.ForeColor = Color.Silver;
            button6.Location = new Point(572, 179);
            button6.Name = "button6";
            button6.Size = new Size(219, 29);
            button6.TabIndex = 42;
            button6.Text = "Remove Warning for Selected";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.SteelBlue;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Corbel", 9F);
            button7.ForeColor = Color.Silver;
            button7.Location = new Point(496, 214);
            button7.Name = "button7";
            button7.Size = new Size(148, 29);
            button7.TabIndex = 43;
            button7.Text = "Add Personal Note";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1551, 799);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(textBox2);
            Controls.Add(listBox6);
            Controls.Add(MadeRetreatPlus);
            Controls.Add(MadeRetreatLabel);
            Controls.Add(MadeRetreatMinus);
            Controls.Add(label13);
            Controls.Add(listBox5);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(button4);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(RetreatButtonMinus);
            Controls.Add(RetreatButtonPlus);
            Controls.Add(DeathButtonMinus);
            Controls.Add(DeathButtonPlus);
            Controls.Add(KillButtonMinus);
            Controls.Add(KillButtonPlus);
            Controls.Add(button3);
            Controls.Add(RetreatsLabelCount);
            Controls.Add(DeathsLabelCount);
            Controls.Add(KillsLabelCount);
            Controls.Add(PlayerName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label PlayerName;
        private Label KillsLabelCount;
        private Label DeathsLabelCount;
        private Label RetreatsLabelCount;
        private Button button3;
        private Button KillButtonPlus;
        private Button KillButtonMinus;
        private Button DeathButtonPlus;
        private Button DeathButtonMinus;
        private Button RetreatButtonPlus;
        private Button RetreatButtonMinus;
        private Label label7;
        private Label label8;
        private Label label9;
        private ListView listView4;
        private Label label10;
        private Label label11;
        private Button button4;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private ListBox listBox5;
        private Label label13;
        private Button MadeRetreatMinus;
        private Label MadeRetreatLabel;
        private Button MadeRetreatPlus;
        private Button button5;
        private ListBox listBox6;
        private TextBox textBox2;
        private Button button6;
        private Button button7;
    }
}
