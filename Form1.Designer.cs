namespace ResistorCalculatedApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            btnBandOne = new Button();
            btnBandTwo = new Button();
            btnBandThree = new Button();
            btnBandFour = new Button();
            label1 = new Label();
            btnAccept = new Button();
            groupBox1 = new GroupBox();
            rbBandFour = new RadioButton();
            rbBandThree = new RadioButton();
            rbBandTwo = new RadioButton();
            rbBandOne = new RadioButton();
            groupBox2 = new GroupBox();
            btnSilver = new Button();
            btnGold = new Button();
            btnWhite = new Button();
            btnBlue = new Button();
            btnViolet = new Button();
            btnGray = new Button();
            btnBrown = new Button();
            btnRed = new Button();
            btnGreen = new Button();
            btnOrange = new Button();
            btnYellow = new Button();
            btnBlack = new Button();
            lbValue = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(559, 329);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnBandOne
            // 
            btnBandOne.BackColor = Color.Gainsboro;
            btnBandOne.Enabled = false;
            btnBandOne.FlatStyle = FlatStyle.Flat;
            btnBandOne.Location = new Point(190, 72);
            btnBandOne.Name = "btnBandOne";
            btnBandOne.Size = new Size(29, 92);
            btnBandOne.TabIndex = 1;
            btnBandOne.UseVisualStyleBackColor = false;
            // 
            // btnBandTwo
            // 
            btnBandTwo.BackColor = Color.Gainsboro;
            btnBandTwo.Enabled = false;
            btnBandTwo.FlatStyle = FlatStyle.Flat;
            btnBandTwo.Location = new Point(242, 80);
            btnBandTwo.Name = "btnBandTwo";
            btnBandTwo.Size = new Size(29, 76);
            btnBandTwo.TabIndex = 2;
            btnBandTwo.UseVisualStyleBackColor = false;
            // 
            // btnBandThree
            // 
            btnBandThree.BackColor = Color.Gainsboro;
            btnBandThree.Enabled = false;
            btnBandThree.FlatStyle = FlatStyle.Flat;
            btnBandThree.Location = new Point(291, 80);
            btnBandThree.Name = "btnBandThree";
            btnBandThree.Size = new Size(29, 76);
            btnBandThree.TabIndex = 3;
            btnBandThree.UseVisualStyleBackColor = false;
            // 
            // btnBandFour
            // 
            btnBandFour.BackColor = Color.Gainsboro;
            btnBandFour.Enabled = false;
            btnBandFour.FlatStyle = FlatStyle.Flat;
            btnBandFour.Location = new Point(372, 72);
            btnBandFour.Name = "btnBandFour";
            btnBandFour.Size = new Size(12, 92);
            btnBandFour.TabIndex = 4;
            btnBandFour.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(190, 197);
            label1.Name = "label1";
            label1.Size = new Size(154, 24);
            label1.TabIndex = 6;
            label1.Text = "Resistor Value:";
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.Transparent;
            btnAccept.BackgroundImage = (Image)resources.GetObject("btnAccept.BackgroundImage");
            btnAccept.BackgroundImageLayout = ImageLayout.Stretch;
            btnAccept.FlatAppearance.BorderSize = 0;
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.Location = new Point(190, 227);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(64, 64);
            btnAccept.TabIndex = 7;
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbBandFour);
            groupBox1.Controls.Add(rbBandThree);
            groupBox1.Controls.Add(rbBandTwo);
            groupBox1.Controls.Add(rbBandOne);
            groupBox1.ForeColor = Color.Cyan;
            groupBox1.Location = new Point(12, 197);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(82, 121);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Band";
            // 
            // rbBandFour
            // 
            rbBandFour.AutoSize = true;
            rbBandFour.Location = new Point(6, 97);
            rbBandFour.Name = "rbBandFour";
            rbBandFour.Size = new Size(58, 19);
            rbBandFour.TabIndex = 3;
            rbBandFour.TabStop = true;
            rbBandFour.Text = "Band4";
            rbBandFour.UseVisualStyleBackColor = true;
            // 
            // rbBandThree
            // 
            rbBandThree.AutoSize = true;
            rbBandThree.Location = new Point(6, 72);
            rbBandThree.Name = "rbBandThree";
            rbBandThree.Size = new Size(58, 19);
            rbBandThree.TabIndex = 2;
            rbBandThree.TabStop = true;
            rbBandThree.Text = "Band3";
            rbBandThree.UseVisualStyleBackColor = true;
            // 
            // rbBandTwo
            // 
            rbBandTwo.AutoSize = true;
            rbBandTwo.Location = new Point(6, 47);
            rbBandTwo.Name = "rbBandTwo";
            rbBandTwo.Size = new Size(58, 19);
            rbBandTwo.TabIndex = 1;
            rbBandTwo.TabStop = true;
            rbBandTwo.Text = "Band2";
            rbBandTwo.UseVisualStyleBackColor = true;
            // 
            // rbBandOne
            // 
            rbBandOne.AutoSize = true;
            rbBandOne.Location = new Point(6, 22);
            rbBandOne.Name = "rbBandOne";
            rbBandOne.Size = new Size(58, 19);
            rbBandOne.TabIndex = 0;
            rbBandOne.TabStop = true;
            rbBandOne.Text = "Band1";
            rbBandOne.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSilver);
            groupBox2.Controls.Add(btnGold);
            groupBox2.Controls.Add(btnWhite);
            groupBox2.Controls.Add(btnBlue);
            groupBox2.Controls.Add(btnViolet);
            groupBox2.Controls.Add(btnGray);
            groupBox2.Controls.Add(btnBrown);
            groupBox2.Controls.Add(btnRed);
            groupBox2.Controls.Add(btnGreen);
            groupBox2.Controls.Add(btnOrange);
            groupBox2.Controls.Add(btnYellow);
            groupBox2.Controls.Add(btnBlack);
            groupBox2.ForeColor = Color.Cyan;
            groupBox2.Location = new Point(100, 197);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(84, 121);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Color";
            // 
            // btnSilver
            // 
            btnSilver.BackColor = Color.Silver;
            btnSilver.FlatStyle = FlatStyle.Flat;
            btnSilver.Location = new Point(58, 95);
            btnSilver.Name = "btnSilver";
            btnSilver.Size = new Size(20, 20);
            btnSilver.TabIndex = 11;
            btnSilver.UseVisualStyleBackColor = false;
            btnSilver.Click += btnSilver_Click;
            // 
            // btnGold
            // 
            btnGold.BackColor = Color.Gold;
            btnGold.FlatStyle = FlatStyle.Flat;
            btnGold.Location = new Point(32, 95);
            btnGold.Name = "btnGold";
            btnGold.Size = new Size(20, 20);
            btnGold.TabIndex = 10;
            btnGold.UseVisualStyleBackColor = false;
            btnGold.Click += btnGold_Click;
            // 
            // btnWhite
            // 
            btnWhite.BackColor = Color.White;
            btnWhite.FlatStyle = FlatStyle.Flat;
            btnWhite.Location = new Point(6, 95);
            btnWhite.Name = "btnWhite";
            btnWhite.Size = new Size(20, 20);
            btnWhite.TabIndex = 9;
            btnWhite.UseVisualStyleBackColor = false;
            btnWhite.Click += btnWhite_Click;
            // 
            // btnBlue
            // 
            btnBlue.BackColor = Color.Blue;
            btnBlue.FlatStyle = FlatStyle.Flat;
            btnBlue.Location = new Point(6, 71);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(20, 20);
            btnBlue.TabIndex = 8;
            btnBlue.UseVisualStyleBackColor = false;
            btnBlue.Click += btnBlue_Click;
            // 
            // btnViolet
            // 
            btnViolet.BackColor = Color.Violet;
            btnViolet.FlatStyle = FlatStyle.Flat;
            btnViolet.Location = new Point(32, 71);
            btnViolet.Name = "btnViolet";
            btnViolet.Size = new Size(20, 20);
            btnViolet.TabIndex = 7;
            btnViolet.UseVisualStyleBackColor = false;
            btnViolet.Click += btnViolet_Click;
            // 
            // btnGray
            // 
            btnGray.BackColor = Color.Gray;
            btnGray.FlatStyle = FlatStyle.Flat;
            btnGray.Location = new Point(58, 71);
            btnGray.Name = "btnGray";
            btnGray.Size = new Size(20, 20);
            btnGray.TabIndex = 6;
            btnGray.UseVisualStyleBackColor = false;
            btnGray.Click += btnGray_Click;
            // 
            // btnBrown
            // 
            btnBrown.BackColor = Color.Brown;
            btnBrown.FlatStyle = FlatStyle.Flat;
            btnBrown.Location = new Point(32, 21);
            btnBrown.Name = "btnBrown";
            btnBrown.Size = new Size(20, 20);
            btnBrown.TabIndex = 5;
            btnBrown.UseVisualStyleBackColor = false;
            btnBrown.Click += btnBrown_Click;
            // 
            // btnRed
            // 
            btnRed.BackColor = Color.Red;
            btnRed.FlatStyle = FlatStyle.Flat;
            btnRed.Location = new Point(58, 20);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(20, 20);
            btnRed.TabIndex = 4;
            btnRed.UseVisualStyleBackColor = false;
            btnRed.Click += btnRed_Click;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.Green;
            btnGreen.FlatStyle = FlatStyle.Flat;
            btnGreen.Location = new Point(58, 46);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(20, 20);
            btnGreen.TabIndex = 3;
            btnGreen.UseVisualStyleBackColor = false;
            btnGreen.Click += btnGreen_Click;
            // 
            // btnOrange
            // 
            btnOrange.BackColor = Color.Orange;
            btnOrange.FlatStyle = FlatStyle.Flat;
            btnOrange.Location = new Point(6, 46);
            btnOrange.Name = "btnOrange";
            btnOrange.Size = new Size(20, 20);
            btnOrange.TabIndex = 2;
            btnOrange.UseVisualStyleBackColor = false;
            btnOrange.Click += btnOrange_Click;
            // 
            // btnYellow
            // 
            btnYellow.BackColor = Color.Yellow;
            btnYellow.FlatStyle = FlatStyle.Flat;
            btnYellow.Location = new Point(32, 46);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(20, 20);
            btnYellow.TabIndex = 1;
            btnYellow.UseVisualStyleBackColor = false;
            btnYellow.Click += btnYellow_Click;
            // 
            // btnBlack
            // 
            btnBlack.BackColor = Color.Black;
            btnBlack.FlatStyle = FlatStyle.Flat;
            btnBlack.Location = new Point(6, 21);
            btnBlack.Name = "btnBlack";
            btnBlack.Size = new Size(20, 20);
            btnBlack.TabIndex = 0;
            btnBlack.UseVisualStyleBackColor = false;
            btnBlack.Click += btnBlack_Click;
            // 
            // lbValue
            // 
            lbValue.AutoSize = true;
            lbValue.Font = new Font("Arial", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lbValue.ForeColor = Color.Red;
            lbValue.Location = new Point(350, 197);
            lbValue.Name = "lbValue";
            lbValue.Size = new Size(0, 24);
            lbValue.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(515, 12);
            button1.Name = "button1";
            button1.Size = new Size(32, 32);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(559, 329);
            Controls.Add(button1);
            Controls.Add(lbValue);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnAccept);
            Controls.Add(label1);
            Controls.Add(btnBandFour);
            Controls.Add(btnBandThree);
            Controls.Add(btnBandTwo);
            Controls.Add(btnBandOne);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnBandOne;
        private Button btnBandTwo;
        private Button btnBandThree;
        private Button btnBandFour;
        private Label label1;
        private Button btnAccept;
        private GroupBox groupBox1;
        private RadioButton rbBandFour;
        private RadioButton rbBandThree;
        private RadioButton rbBandTwo;
        private RadioButton rbBandOne;
        private GroupBox groupBox2;
        private Button btnSilver;
        private Button btnGold;
        private Button btnWhite;
        private Button btnBlue;
        private Button btnViolet;
        private Button btnGray;
        private Button btnBrown;
        private Button btnRed;
        private Button btnGreen;
        private Button btnOrange;
        private Button btnYellow;
        private Button btnBlack;
        private Label lbValue;
        private Button button1;
    }
}