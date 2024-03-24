namespace Examination_System
{
    partial class StudentCoursesForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbl_topic = new Label();
            tb_courseName = new TextBox();
            nu_Duration = new NumericUpDown();
            nu_grade = new NumericUpDown();
            btn_takeExam = new Button();
            dgv_Courses = new DataGridView();
            btn_Back = new Button();
            lb_topics = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nu_Duration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nu_grade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Courses).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 33);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Course Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 87);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Duration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 147);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 2;
            label3.Text = "Grade";
            // 
            // lbl_topic
            // 
            lbl_topic.AutoSize = true;
            lbl_topic.Location = new Point(22, 211);
            lbl_topic.Name = "lbl_topic";
            lbl_topic.Size = new Size(54, 20);
            lbl_topic.TabIndex = 4;
            lbl_topic.Text = "Topics";
            // 
            // tb_courseName
            // 
            tb_courseName.Location = new Point(22, 57);
            tb_courseName.Margin = new Padding(3, 4, 3, 4);
            tb_courseName.Name = "tb_courseName";
            tb_courseName.ReadOnly = true;
            tb_courseName.Size = new Size(313, 28);
            tb_courseName.TabIndex = 5;
            // 
            // nu_Duration
            // 
            nu_Duration.Location = new Point(22, 111);
            nu_Duration.Margin = new Padding(3, 4, 3, 4);
            nu_Duration.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nu_Duration.Name = "nu_Duration";
            nu_Duration.ReadOnly = true;
            nu_Duration.Size = new Size(314, 28);
            nu_Duration.TabIndex = 6;
            // 
            // nu_grade
            // 
            nu_grade.Location = new Point(22, 171);
            nu_grade.Margin = new Padding(3, 4, 3, 4);
            nu_grade.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nu_grade.Name = "nu_grade";
            nu_grade.ReadOnly = true;
            nu_grade.Size = new Size(314, 28);
            nu_grade.TabIndex = 7;
            // 
            // btn_takeExam
            // 
            btn_takeExam.Location = new Point(173, 482);
            btn_takeExam.Margin = new Padding(3, 4, 3, 4);
            btn_takeExam.Name = "btn_takeExam";
            btn_takeExam.Size = new Size(163, 45);
            btn_takeExam.TabIndex = 8;
            btn_takeExam.Text = "take Exam";
            btn_takeExam.UseVisualStyleBackColor = true;
            btn_takeExam.Click += btn_takeExam_Click;
            // 
            // dgv_Courses
            // 
            dgv_Courses.BackgroundColor = SystemColors.ButtonFace;
            dgv_Courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Courses.Location = new Point(384, 4);
            dgv_Courses.Margin = new Padding(3, 4, 3, 4);
            dgv_Courses.Name = "dgv_Courses";
            dgv_Courses.RowHeadersWidth = 51;
            dgv_Courses.Size = new Size(642, 559);
            dgv_Courses.TabIndex = 9;
            dgv_Courses.RowHeaderMouseDoubleClick += dgv_Courses_RowHeaderMouseDoubleClick;
            // 
            // btn_Back
            // 
            btn_Back.Location = new Point(22, 482);
            btn_Back.Margin = new Padding(3, 4, 3, 4);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(144, 45);
            btn_Back.TabIndex = 12;
            btn_Back.Text = "Back to profile";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // lb_topics
            // 
            lb_topics.BackColor = SystemColors.ButtonFace;
            lb_topics.FormattingEnabled = true;
            lb_topics.Location = new Point(22, 234);
            lb_topics.Name = "lb_topics";
            lb_topics.Size = new Size(313, 224);
            lb_topics.TabIndex = 15;
            // 
            // StudCourses
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 575);
            Controls.Add(lb_topics);
            Controls.Add(btn_Back);
            Controls.Add(dgv_Courses);
            Controls.Add(btn_takeExam);
            Controls.Add(nu_grade);
            Controls.Add(nu_Duration);
            Controls.Add(tb_courseName);
            Controls.Add(lbl_topic);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 9F);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1047, 622);
            MinimumSize = new Size(1047, 622);
            Name = "StudCourses";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course Details";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nu_Duration).EndInit();
            ((System.ComponentModel.ISupportInitialize)nu_grade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Courses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbl_topic;
        private TextBox tb_courseName;
        private NumericUpDown nu_Duration;
        private NumericUpDown nu_grade;
        private Button btn_takeExam;
        private DataGridView dgv_Courses;
        private Button btn_Back;
        private ListBox lb_topics;
    }
}
