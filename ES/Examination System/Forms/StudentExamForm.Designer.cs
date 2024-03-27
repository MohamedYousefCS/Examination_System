namespace Examination_System
{
    partial class StudentExamForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lbl_Cname = new Label();
            lbl_question = new Label();
            lbl_grade = new Label();
            rb_ans1 = new RadioButton();
            rb_ans2 = new RadioButton();
            rb_ans3 = new RadioButton();
            rb_ans4 = new RadioButton();
            btn_back = new Button();
            btn_next = new Button();
            btn_submit = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn10 = new Button();
            Timer = new System.Windows.Forms.Timer(components);
            lbl_timer = new Label();
            lbl_index = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label1.Location = new Point(435, 53);
            label1.Name = "label1";
            label1.Size = new Size(91, 16);
            label1.TabIndex = 0;
            label1.Text = "Course Name";
            // 
            // lbl_Cname
            // 
            lbl_Cname.AutoSize = true;
            lbl_Cname.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Cname.Location = new Point(554, 53);
            lbl_Cname.Name = "lbl_Cname";
            lbl_Cname.Size = new Size(19, 21);
            lbl_Cname.TabIndex = 1;
            lbl_Cname.Text = "-";
            // 
            // lbl_question
            // 
            lbl_question.AutoSize = true;
            lbl_question.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_question.Location = new Point(66, 200);
            lbl_question.Name = "lbl_question";
            lbl_question.Size = new Size(77, 23);
            lbl_question.TabIndex = 4;
            lbl_question.Text = "Question";
            // 
            // lbl_grade
            // 
            lbl_grade.AutoSize = true;
            lbl_grade.Location = new Point(19, 172);
            lbl_grade.Name = "lbl_grade";
            lbl_grade.Size = new Size(36, 17);
            lbl_grade.TabIndex = 5;
            lbl_grade.Text = "Mark";
            // 
            // rb_ans1
            // 
            rb_ans1.AutoSize = true;
            rb_ans1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            rb_ans1.Location = new Point(41, 253);
            rb_ans1.Name = "rb_ans1";
            rb_ans1.Size = new Size(83, 20);
            rb_ans1.TabIndex = 6;
            rb_ans1.TabStop = true;
            rb_ans1.Text = "Answer1";
            rb_ans1.UseVisualStyleBackColor = true;
            rb_ans1.CheckedChanged += UpdateAnswer;
            // 
            // rb_ans2
            // 
            rb_ans2.AutoSize = true;
            rb_ans2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            rb_ans2.Location = new Point(41, 299);
            rb_ans2.Name = "rb_ans2";
            rb_ans2.Size = new Size(83, 20);
            rb_ans2.TabIndex = 7;
            rb_ans2.TabStop = true;
            rb_ans2.Text = "Answer2";
            rb_ans2.UseVisualStyleBackColor = true;
            rb_ans2.CheckedChanged += UpdateAnswer;
            // 
            // rb_ans3
            // 
            rb_ans3.AutoSize = true;
            rb_ans3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            rb_ans3.Location = new Point(41, 347);
            rb_ans3.Name = "rb_ans3";
            rb_ans3.Size = new Size(83, 20);
            rb_ans3.TabIndex = 8;
            rb_ans3.TabStop = true;
            rb_ans3.Text = "Answer3";
            rb_ans3.UseVisualStyleBackColor = true;
            rb_ans3.CheckedChanged += UpdateAnswer;
            // 
            // rb_ans4
            // 
            rb_ans4.AutoSize = true;
            rb_ans4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            rb_ans4.Location = new Point(41, 396);
            rb_ans4.Name = "rb_ans4";
            rb_ans4.Size = new Size(83, 20);
            rb_ans4.TabIndex = 9;
            rb_ans4.TabStop = true;
            rb_ans4.Text = "Answer4";
            rb_ans4.UseVisualStyleBackColor = true;
            rb_ans4.CheckedChanged += UpdateAnswer;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(14, 519);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(106, 29);
            btn_back.TabIndex = 10;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_next
            // 
            btn_next.Location = new Point(435, 519);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(106, 29);
            btn_next.TabIndex = 11;
            btn_next.Text = "Next";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click;
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(800, 343);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(106, 29);
            btn_submit.TabIndex = 12;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(738, 253);
            btn1.Name = "btn1";
            btn1.Size = new Size(42, 29);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(786, 253);
            btn2.Name = "btn2";
            btn2.Size = new Size(42, 29);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(834, 253);
            btn3.Name = "btn3";
            btn3.Size = new Size(42, 29);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(883, 253);
            btn4.Name = "btn4";
            btn4.Size = new Size(42, 29);
            btn4.TabIndex = 16;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(931, 253);
            btn5.Name = "btn5";
            btn5.Size = new Size(42, 29);
            btn5.TabIndex = 17;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(738, 287);
            btn6.Name = "btn6";
            btn6.Size = new Size(42, 29);
            btn6.TabIndex = 18;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(786, 288);
            btn7.Name = "btn7";
            btn7.Size = new Size(42, 29);
            btn7.TabIndex = 19;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(834, 288);
            btn8.Name = "btn8";
            btn8.Size = new Size(42, 29);
            btn8.TabIndex = 20;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(883, 288);
            btn9.Name = "btn9";
            btn9.Size = new Size(42, 29);
            btn9.TabIndex = 21;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn_Click;
            // 
            // btn10
            // 
            btn10.Location = new Point(931, 287);
            btn10.Name = "btn10";
            btn10.Size = new Size(42, 29);
            btn10.TabIndex = 22;
            btn10.Text = "10";
            btn10.UseVisualStyleBackColor = true;
            btn10.Click += btn_Click;
            // 
            // Timer
            // 
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            // 
            // lbl_timer
            // 
            lbl_timer.AutoSize = true;
            lbl_timer.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            lbl_timer.Location = new Point(817, 77);
            lbl_timer.Name = "lbl_timer";
            lbl_timer.Size = new Size(65, 16);
            lbl_timer.TabIndex = 23;
            lbl_timer.Text = "00:00:00";
            // 
            // lbl_index
            // 
            lbl_index.AutoSize = true;
            lbl_index.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_index.Location = new Point(17, 202);
            lbl_index.Name = "lbl_index";
            lbl_index.Size = new Size(52, 21);
            lbl_index.TabIndex = 26;
            lbl_index.Text = "Index";
            // 
            // StudentExamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 583);
            Controls.Add(lbl_index);
            Controls.Add(lbl_timer);
            Controls.Add(btn10);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn_submit);
            Controls.Add(btn_next);
            Controls.Add(btn_back);
            Controls.Add(rb_ans4);
            Controls.Add(rb_ans3);
            Controls.Add(rb_ans2);
            Controls.Add(rb_ans1);
            Controls.Add(lbl_grade);
            Controls.Add(lbl_question);
            Controls.Add(lbl_Cname);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 9F);
            MaximumSize = new Size(1047, 622);
            MinimumSize = new Size(1047, 622);
            Name = "StudentExamForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exam";
            Load += StudExam_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_Cname;
        private Label lbl_question;
        private Label lbl_grade;
        private RadioButton rb_ans1;
        private RadioButton rb_ans2;
        private RadioButton rb_ans3;
        private RadioButton rb_ans4;
        private Button btn_back;
        private Button btn_next;
        private Button btn_submit;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn10;
        private System.Windows.Forms.Timer Timer;
        private Label lbl_timer;
        private Label lbl_index;
    }
}