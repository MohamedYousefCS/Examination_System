namespace Examination_System
{
    partial class Reports
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
            button1 = new Button();
            btn_StudentsByCourseId = new Button();
            btn_GetStudentGradeFrm = new Button();
            btn_StudentCountFrm = new Button();
            btn_CrsTopicsFrm = new Button();
            btn_DisplayExamFrm = new Button();
            btn_ExamCorrectionFrm = new Button();
            label1 = new Label();
            btn_back = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1335, 804);
            button1.Name = "button1";
            button1.Size = new Size(106, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_StudentsByCourseId
            // 
            btn_StudentsByCourseId.Font = new Font("Comic Sans MS", 9F);
            btn_StudentsByCourseId.Location = new Point(300, 154);
            btn_StudentsByCourseId.Name = "btn_StudentsByCourseId";
            btn_StudentsByCourseId.Size = new Size(403, 29);
            btn_StudentsByCourseId.TabIndex = 1;
            btn_StudentsByCourseId.Text = "Students Information For Specific Course";
            btn_StudentsByCourseId.UseVisualStyleBackColor = true;
            btn_StudentsByCourseId.Click += btn_StudentsByCourseId_Click;
            // 
            // btn_GetStudentGradeFrm
            // 
            btn_GetStudentGradeFrm.Location = new Point(300, 200);
            btn_GetStudentGradeFrm.Name = "btn_GetStudentGradeFrm";
            btn_GetStudentGradeFrm.Size = new Size(403, 29);
            btn_GetStudentGradeFrm.TabIndex = 2;
            btn_GetStudentGradeFrm.Text = "Student Degrees In All Courses";
            btn_GetStudentGradeFrm.UseVisualStyleBackColor = true;
            btn_GetStudentGradeFrm.Click += btn_GetStudentGradeFrm_Click;
            // 
            // btn_StudentCountFrm
            // 
            btn_StudentCountFrm.Location = new Point(300, 244);
            btn_StudentCountFrm.Name = "btn_StudentCountFrm";
            btn_StudentCountFrm.Size = new Size(403, 29);
            btn_StudentCountFrm.TabIndex = 3;
            btn_StudentCountFrm.Text = "Courses That Teached By Instructor And Count Student On It ";
            btn_StudentCountFrm.UseVisualStyleBackColor = true;
            btn_StudentCountFrm.Click += btn_StudentCountFrm_Click;
            // 
            // btn_CrsTopicsFrm
            // 
            btn_CrsTopicsFrm.Location = new Point(300, 291);
            btn_CrsTopicsFrm.Name = "btn_CrsTopicsFrm";
            btn_CrsTopicsFrm.Size = new Size(403, 29);
            btn_CrsTopicsFrm.TabIndex = 4;
            btn_CrsTopicsFrm.Text = "Topics For Specific Course";
            btn_CrsTopicsFrm.UseVisualStyleBackColor = true;
            btn_CrsTopicsFrm.Click += btn_CrsTopicsFrm_Click;
            // 
            // btn_DisplayExamFrm
            // 
            btn_DisplayExamFrm.Location = new Point(300, 336);
            btn_DisplayExamFrm.Name = "btn_DisplayExamFrm";
            btn_DisplayExamFrm.Size = new Size(403, 33);
            btn_DisplayExamFrm.TabIndex = 5;
            btn_DisplayExamFrm.Text = "Display Specific Exam (Questions and Answers)";
            btn_DisplayExamFrm.UseVisualStyleBackColor = true;
            btn_DisplayExamFrm.Click += btn_DisplayExamFrm_Click;
            // 
            // btn_ExamCorrectionFrm
            // 
            btn_ExamCorrectionFrm.Location = new Point(300, 384);
            btn_ExamCorrectionFrm.Name = "btn_ExamCorrectionFrm";
            btn_ExamCorrectionFrm.Size = new Size(403, 32);
            btn_ExamCorrectionFrm.TabIndex = 6;
            btn_ExamCorrectionFrm.Text = "Display Exam For Student With Degree";
            btn_ExamCorrectionFrm.UseVisualStyleBackColor = true;
            btn_ExamCorrectionFrm.Click += btn_ExamCorrectionFrm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 61);
            label1.Name = "label1";
            label1.Size = new Size(588, 39);
            label1.TabIndex = 7;
            label1.Text = "Click On Report That You Need To Display ..";
            // 
            // btn_back
            // 
            btn_back.Location = new Point(300, 436);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(403, 29);
            btn_back.TabIndex = 8;
            btn_back.Text = " Back To Profile";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 575);
            Controls.Add(btn_back);
            Controls.Add(label1);
            Controls.Add(btn_ExamCorrectionFrm);
            Controls.Add(btn_DisplayExamFrm);
            Controls.Add(btn_CrsTopicsFrm);
            Controls.Add(btn_StudentCountFrm);
            Controls.Add(btn_GetStudentGradeFrm);
            Controls.Add(btn_StudentsByCourseId);
            Controls.Add(button1);
            Font = new Font("Comic Sans MS", 9F);
            MaximumSize = new Size(1047, 622);
            MinimumSize = new Size(1047, 622);
            Name = "Reports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btn_StudentsByCourseId;
        private Button btn_GetStudentGradeFrm;
        private Button btn_StudentCountFrm;
        private Button btn_CrsTopicsFrm;
        private Button btn_DisplayExamFrm;
        private Button btn_ExamCorrectionFrm;
        private Label label1;
        private Button btn_back;
    }
}