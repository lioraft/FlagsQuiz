namespace flagsQuiz
{
    partial class main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            spiralGlobePic = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            flag = new PictureBox();
            option1 = new RadioButton();
            option2 = new RadioButton();
            option3 = new RadioButton();
            option4 = new RadioButton();
            question = new Label();
            answersLbl = new Label();
            points = new NumericUpDown();
            bestscoreLbl = new Label();
            bestscoreTB = new TextBox();
            recordLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)spiralGlobePic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)points).BeginInit();
            SuspendLayout();
            // 
            // spiralGlobePic
            // 
            spiralGlobePic.BackColor = Color.Transparent;
            spiralGlobePic.BackgroundImageLayout = ImageLayout.Stretch;
            spiralGlobePic.Image = (Image)resources.GetObject("spiralGlobePic.Image");
            spiralGlobePic.Location = new Point(224, 41);
            spiralGlobePic.Name = "spiralGlobePic";
            spiralGlobePic.Size = new Size(222, 207);
            spiralGlobePic.SizeMode = PictureBoxSizeMode.StretchImage;
            spiralGlobePic.TabIndex = 0;
            spiralGlobePic.TabStop = false;
            spiralGlobePic.Click += pictureBox1_Click_1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(248, 286);
            button1.Name = "button1";
            button1.Size = new Size(173, 32);
            button1.TabIndex = 1;
            button1.Text = "Start New Game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flag
            // 
            flag.Location = new Point(214, 12);
            flag.Name = "flag";
            flag.Size = new Size(241, 140);
            flag.SizeMode = PictureBoxSizeMode.StretchImage;
            flag.TabIndex = 2;
            flag.TabStop = false;
            flag.Click += pictureBox1_Click_2;
            // 
            // option1
            // 
            option1.AutoSize = true;
            option1.BackColor = Color.Transparent;
            option1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            option1.Location = new Point(214, 201);
            option1.Name = "option1";
            option1.Size = new Size(107, 20);
            option1.TabIndex = 3;
            option1.TabStop = true;
            option1.Text = "radioButton1";
            option1.UseVisualStyleBackColor = false;
            // 
            // option2
            // 
            option2.AutoSize = true;
            option2.BackColor = Color.Transparent;
            option2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            option2.Location = new Point(214, 239);
            option2.Name = "option2";
            option2.Size = new Size(107, 20);
            option2.TabIndex = 4;
            option2.TabStop = true;
            option2.Text = "radioButton1";
            option2.UseVisualStyleBackColor = false;
            // 
            // option3
            // 
            option3.AutoSize = true;
            option3.BackColor = Color.Transparent;
            option3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            option3.Location = new Point(214, 276);
            option3.Name = "option3";
            option3.Size = new Size(107, 20);
            option3.TabIndex = 5;
            option3.TabStop = true;
            option3.Text = "radioButton1";
            option3.UseVisualStyleBackColor = false;
            // 
            // option4
            // 
            option4.AutoSize = true;
            option4.BackColor = Color.Transparent;
            option4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            option4.Location = new Point(214, 314);
            option4.Name = "option4";
            option4.Size = new Size(107, 20);
            option4.TabIndex = 6;
            option4.TabStop = true;
            option4.Text = "radioButton1";
            option4.UseVisualStyleBackColor = false;
            // 
            // question
            // 
            question.AutoSize = true;
            question.BackColor = Color.Transparent;
            question.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            question.Location = new Point(214, 166);
            question.Name = "question";
            question.Size = new Size(162, 21);
            question.TabIndex = 7;
            question.Text = "This flag belongs to:";
            // 
            // answersLbl
            // 
            answersLbl.AutoSize = true;
            answersLbl.BackColor = Color.Transparent;
            answersLbl.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            answersLbl.Location = new Point(38, 30);
            answersLbl.Name = "answersLbl";
            answersLbl.Size = new Size(107, 18);
            answersLbl.TabIndex = 8;
            answersLbl.Text = "Current score";
            // 
            // points
            // 
            points.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            points.Location = new Point(62, 60);
            points.Name = "points";
            points.Size = new Size(56, 22);
            points.TabIndex = 9;
            points.TextAlign = HorizontalAlignment.Center;
            // 
            // bestscoreLbl
            // 
            bestscoreLbl.AutoSize = true;
            bestscoreLbl.BackColor = Color.Transparent;
            bestscoreLbl.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bestscoreLbl.Location = new Point(530, 30);
            bestscoreLbl.Name = "bestscoreLbl";
            bestscoreLbl.Size = new Size(82, 18);
            bestscoreLbl.TabIndex = 10;
            bestscoreLbl.Text = "Best score";
            // 
            // bestscoreTB
            // 
            bestscoreTB.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bestscoreTB.Location = new Point(530, 60);
            bestscoreTB.Name = "bestscoreTB";
            bestscoreTB.Size = new Size(82, 22);
            bestscoreTB.TabIndex = 11;
            bestscoreTB.TextAlign = HorizontalAlignment.Center;
            // 
            // recordLbl
            // 
            recordLbl.AutoSize = true;
            recordLbl.BackColor = Color.Transparent;
            recordLbl.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            recordLbl.Location = new Point(496, 95);
            recordLbl.Name = "recordLbl";
            recordLbl.Size = new Size(157, 16);
            recordLbl.TabIndex = 12;
            recordLbl.Text = "You broke your record!";
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(665, 366);
            Controls.Add(recordLbl);
            Controls.Add(bestscoreTB);
            Controls.Add(bestscoreLbl);
            Controls.Add(points);
            Controls.Add(answersLbl);
            Controls.Add(question);
            Controls.Add(option4);
            Controls.Add(option3);
            Controls.Add(option2);
            Controls.Add(option1);
            Controls.Add(flag);
            Controls.Add(button1);
            Controls.Add(spiralGlobePic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "main";
            Text = "Flags Quiz";
            Load += main_Load;
            ((System.ComponentModel.ISupportInitialize)spiralGlobePic).EndInit();
            ((System.ComponentModel.ISupportInitialize)flag).EndInit();
            ((System.ComponentModel.ISupportInitialize)points).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox spiralGlobePic;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private PictureBox flag;
        private RadioButton option1;
        private RadioButton option2;
        private RadioButton option3;
        private RadioButton option4;
        private Label question;
        private Label answersLbl;
        private NumericUpDown points;
        private Label bestscoreLbl;
        private TextBox bestscoreTB;
        private Label recordLbl;
    }
}