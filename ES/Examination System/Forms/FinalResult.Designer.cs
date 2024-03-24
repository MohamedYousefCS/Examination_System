namespace Examination_System
{
    partial class FinalResult
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
            lb_ExamTitle = new Label();
            lb_CourseName = new Label();
            lb_StudentName = new Label();
            lb_FinalGrade = new Label();
            btn_BackToCourses = new Button();
            btn_CloseTheApp = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // lb_ExamTitle
            // 
            lb_ExamTitle.AutoSize = true;
            lb_ExamTitle.Font = new Font("Comic Sans MS", 10F);
            lb_ExamTitle.Location = new Point(511, 280);
            lb_ExamTitle.Name = "lb_ExamTitle";
            lb_ExamTitle.Size = new Size(97, 24);
            lb_ExamTitle.TabIndex = 0;
            lb_ExamTitle.Text = "Exam Title";
            // 
            // lb_CourseName
            // 
            lb_CourseName.AutoSize = true;
            lb_CourseName.Font = new Font("Comic Sans MS", 10F);
            lb_CourseName.Location = new Point(511, 240);
            lb_CourseName.Name = "lb_CourseName";
            lb_CourseName.Size = new Size(116, 24);
            lb_CourseName.TabIndex = 1;
            lb_CourseName.Text = "Course Name";
            // 
            // lb_StudentName
            // 
            lb_StudentName.AutoSize = true;
            lb_StudentName.Font = new Font("Comic Sans MS", 10F);
            lb_StudentName.Location = new Point(511, 204);
            lb_StudentName.Name = "lb_StudentName";
            lb_StudentName.Size = new Size(122, 24);
            lb_StudentName.TabIndex = 2;
            lb_StudentName.Text = "StudentName";
            // 
            // lb_FinalGrade
            // 
            lb_FinalGrade.AutoSize = true;
            lb_FinalGrade.Font = new Font("Comic Sans MS", 10F);
            lb_FinalGrade.Location = new Point(511, 323);
            lb_FinalGrade.Name = "lb_FinalGrade";
            lb_FinalGrade.Size = new Size(96, 24);
            lb_FinalGrade.TabIndex = 3;
            lb_FinalGrade.Text = "FinalGrade";
            // 
            // btn_BackToCourses
            // 
            btn_BackToCourses.Location = new Point(357, 398);
            btn_BackToCourses.Margin = new Padding(3, 4, 3, 4);
            btn_BackToCourses.Name = "btn_BackToCourses";
            btn_BackToCourses.Size = new Size(143, 42);
            btn_BackToCourses.TabIndex = 4;
            btn_BackToCourses.Text = "Back to Courses";
            btn_BackToCourses.UseVisualStyleBackColor = true;
            btn_BackToCourses.Click += btn_BackToCourses_Click;
            // 
            // btn_CloseTheApp
            // 
            btn_CloseTheApp.Font = new Font("Comic Sans MS", 9F);
            btn_CloseTheApp.Location = new Point(506, 398);
            btn_CloseTheApp.Margin = new Padding(3, 4, 3, 4);
            btn_CloseTheApp.Name = "btn_CloseTheApp";
            btn_CloseTheApp.Size = new Size(143, 42);
            btn_CloseTheApp.TabIndex = 5;
            btn_CloseTheApp.Text = "Close the App";
            btn_CloseTheApp.UseVisualStyleBackColor = true;
            btn_CloseTheApp.Click += btn_CloseTheApp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10F);
            label1.Location = new Point(379, 323);
            label1.Name = "label1";
            label1.Size = new Size(111, 24);
            label1.TabIndex = 9;
            label1.Text = "Final Grade: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10F);
            label2.Location = new Point(379, 204);
            label2.Name = "label2";
            label2.Size = new Size(137, 24);
            label2.TabIndex = 8;
            label2.Text = "Student Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 10F);
            label3.Location = new Point(379, 240);
            label3.Name = "label3";
            label3.Size = new Size(121, 24);
            label3.TabIndex = 7;
            label3.Text = "Course Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 10F);
            label4.Location = new Point(379, 280);
            label4.Name = "label4";
            label4.Size = new Size(102, 24);
            label4.TabIndex = 6;
            label4.Text = "Exam Title:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(275, 83);
            label5.Name = "label5";
            label5.Size = new Size(470, 61);
            label5.TabIndex = 10;
            label5.Text = "Final Grade For Exam";
            // 
            // FinalResult
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 575);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btn_CloseTheApp);
            Controls.Add(btn_BackToCourses);
            Controls.Add(lb_FinalGrade);
            Controls.Add(lb_StudentName);
            Controls.Add(lb_CourseName);
            Controls.Add(lb_ExamTitle);
            Font = new Font("Comic Sans MS", 9F);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1047, 622);
            MinimumSize = new Size(1047, 622);
            Name = "FinalResult";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinalResult";
            Load += FinalResult_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_ExamTitle;
        private Label lb_CourseName;
        private Label lb_StudentName;
        private Label lb_FinalGrade;
        private Button btn_BackToCourses;
        private Button btn_CloseTheApp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}