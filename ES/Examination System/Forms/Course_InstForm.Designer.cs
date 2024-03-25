namespace Examination_System
{
    partial class Course_InstForm
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
            DVG_InsCourses = new DataGridView();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_questions = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_courseName = new TextBox();
            txt_grade = new TextBox();
            txt_duration = new TextBox();
            btn_topics = new Button();
            btn_back = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)DVG_InsCourses).BeginInit();
            SuspendLayout();
            // 
            // DVG_InsCourses
            // 
            DVG_InsCourses.BackgroundColor = SystemColors.ButtonFace;
            DVG_InsCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVG_InsCourses.Location = new Point(523, 11);
            DVG_InsCourses.Margin = new Padding(2);
            DVG_InsCourses.Name = "DVG_InsCourses";
            DVG_InsCourses.RowHeadersWidth = 62;
            DVG_InsCourses.Size = new Size(495, 553);
            DVG_InsCourses.TabIndex = 0;
            DVG_InsCourses.RowHeaderMouseDoubleClick += DVG_InsCourses_RowHeaderMouseDoubleClick;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(73, 338);
            btn_add.Margin = new Padding(2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(356, 27);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(254, 369);
            btn_update.Margin = new Padding(2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(175, 27);
            btn_update.TabIndex = 2;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(73, 369);
            btn_delete.Margin = new Padding(2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(177, 27);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_questions
            // 
            btn_questions.Location = new Point(73, 400);
            btn_questions.Margin = new Padding(2);
            btn_questions.Name = "btn_questions";
            btn_questions.Size = new Size(177, 27);
            btn_questions.TabIndex = 4;
            btn_questions.Text = "Questions";
            btn_questions.UseVisualStyleBackColor = true;
            btn_questions.Click += btn_questions_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 164);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 6;
            label1.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 216);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 7;
            label2.Text = "Duration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 269);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 8;
            label3.Text = "Grade";
            // 
            // txt_courseName
            // 
            txt_courseName.Location = new Point(73, 186);
            txt_courseName.Margin = new Padding(2);
            txt_courseName.Name = "txt_courseName";
            txt_courseName.Size = new Size(356, 28);
            txt_courseName.TabIndex = 10;
            // 
            // txt_grade
            // 
            txt_grade.Location = new Point(73, 291);
            txt_grade.Margin = new Padding(2);
            txt_grade.Name = "txt_grade";
            txt_grade.Size = new Size(356, 28);
            txt_grade.TabIndex = 11;
            // 
            // txt_duration
            // 
            txt_duration.Location = new Point(73, 239);
            txt_duration.Margin = new Padding(2);
            txt_duration.Name = "txt_duration";
            txt_duration.Size = new Size(356, 28);
            txt_duration.TabIndex = 12;
            // 
            // btn_topics
            // 
            btn_topics.Location = new Point(254, 400);
            btn_topics.Margin = new Padding(2);
            btn_topics.Name = "btn_topics";
            btn_topics.Size = new Size(175, 27);
            btn_topics.TabIndex = 13;
            btn_topics.Text = "Topics";
            btn_topics.UseVisualStyleBackColor = true;
            btn_topics.Click += btn_topics_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(73, 431);
            btn_back.Margin = new Padding(2);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(356, 27);
            btn_back.TabIndex = 4;
            btn_back.Text = "Back To Profile";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(152, 61);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(169, 56);
            label4.TabIndex = 14;
            label4.Text = "Courses";
            // 
            // Course_Inst
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 575);
            Controls.Add(label4);
            Controls.Add(btn_topics);
            Controls.Add(txt_duration);
            Controls.Add(txt_grade);
            Controls.Add(txt_courseName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_back);
            Controls.Add(btn_questions);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(DVG_InsCourses);
            Font = new Font("Comic Sans MS", 9F);
            Margin = new Padding(2);
            MaximumSize = new Size(1047, 622);
            MinimumSize = new Size(1047, 622);
            Name = "Course_Inst";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course_Inst";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DVG_InsCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DVG_InsCourses;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_questions;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_courseName;
        private TextBox txt_grade;
        private TextBox txt_duration;
        private Button btn_topics;
        private Button btn_back;
        private Label label4;
    }
}
