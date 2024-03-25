namespace Examination_System
{
    partial class InsExamForm
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
            title = new TextBox();
            grade = new TextBox();
            choice1 = new TextBox();
            choice4 = new TextBox();
            choice3 = new TextBox();
            choice2 = new TextBox();
            TF_radio = new RadioButton();
            mcq_radio = new RadioButton();
            DataGridView = new DataGridView();
            add_btn = new Button();
            update_btn = new Button();
            delete_btn = new Button();
            isCorrect1 = new RadioButton();
            isCorrect2 = new RadioButton();
            isCorrect3 = new RadioButton();
            isCorrect4 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btn_back = new Button();
            course_name = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.BackColor = SystemColors.InactiveBorder;
            title.Location = new Point(14, 147);
            title.Margin = new Padding(3, 4, 3, 4);
            title.Name = "title";
            title.PlaceholderText = "Title";
            title.Size = new Size(296, 28);
            title.TabIndex = 0;
            // 
            // grade
            // 
            grade.BackColor = SystemColors.InactiveBorder;
            grade.Location = new Point(14, 192);
            grade.Margin = new Padding(3, 4, 3, 4);
            grade.Name = "grade";
            grade.PlaceholderText = "Grade";
            grade.Size = new Size(296, 28);
            grade.TabIndex = 1;
            // 
            // choice1
            // 
            choice1.BackColor = SystemColors.InactiveBorder;
            choice1.Location = new Point(31, 24);
            choice1.Margin = new Padding(3, 4, 3, 4);
            choice1.Name = "choice1";
            choice1.PlaceholderText = "Choice 1";
            choice1.Size = new Size(258, 28);
            choice1.TabIndex = 3;
            // 
            // choice4
            // 
            choice4.BackColor = SystemColors.InactiveBorder;
            choice4.Location = new Point(31, 136);
            choice4.Margin = new Padding(3, 4, 3, 4);
            choice4.Name = "choice4";
            choice4.PlaceholderText = "Choice 4";
            choice4.Size = new Size(258, 28);
            choice4.TabIndex = 4;
            // 
            // choice3
            // 
            choice3.BackColor = SystemColors.InactiveBorder;
            choice3.Location = new Point(31, 100);
            choice3.Margin = new Padding(3, 4, 3, 4);
            choice3.Name = "choice3";
            choice3.PlaceholderText = "Choice 3";
            choice3.Size = new Size(258, 28);
            choice3.TabIndex = 5;
            // 
            // choice2
            // 
            choice2.BackColor = SystemColors.InactiveBorder;
            choice2.Location = new Point(31, 59);
            choice2.Margin = new Padding(3, 4, 3, 4);
            choice2.Name = "choice2";
            choice2.PlaceholderText = "Choice 2";
            choice2.Size = new Size(258, 28);
            choice2.TabIndex = 6;
            // 
            // TF_radio
            // 
            TF_radio.AutoSize = true;
            TF_radio.Location = new Point(101, 32);
            TF_radio.Margin = new Padding(3, 4, 3, 4);
            TF_radio.Name = "TF_radio";
            TF_radio.Size = new Size(132, 24);
            TF_radio.TabIndex = 7;
            TF_radio.TabStop = true;
            TF_radio.Text = "True and False";
            TF_radio.UseVisualStyleBackColor = true;
            TF_radio.CheckedChanged += TF_radio_CheckedChanged;
            // 
            // mcq_radio
            // 
            mcq_radio.AutoSize = true;
            mcq_radio.Location = new Point(8, 33);
            mcq_radio.Margin = new Padding(3, 4, 3, 4);
            mcq_radio.Name = "mcq_radio";
            mcq_radio.Size = new Size(65, 24);
            mcq_radio.TabIndex = 8;
            mcq_radio.TabStop = true;
            mcq_radio.Text = "MCQ";
            mcq_radio.UseVisualStyleBackColor = true;
            mcq_radio.CheckedChanged += mcq_radio_CheckedChanged;
            // 
            // DataGridView
            // 
            DataGridView.BackgroundColor = SystemColors.ButtonFace;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(357, 13);
            DataGridView.Margin = new Padding(3, 4, 3, 4);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(659, 546);
            DataGridView.TabIndex = 9;
            DataGridView.RowHeaderMouseDoubleClick += DataGridView_RowHeaderMouseDoubleClick;
            // 
            // add_btn
            // 
            add_btn.BackColor = SystemColors.GradientInactiveCaption;
            add_btn.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_btn.ForeColor = Color.FromArgb(0, 0, 192);
            add_btn.Location = new Point(15, 428);
            add_btn.Margin = new Padding(3, 4, 3, 4);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(296, 31);
            add_btn.TabIndex = 11;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // update_btn
            // 
            update_btn.BackColor = SystemColors.GradientInactiveCaption;
            update_btn.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            update_btn.ForeColor = Color.FromArgb(0, 0, 192);
            update_btn.Location = new Point(16, 467);
            update_btn.Margin = new Padding(3, 4, 3, 4);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(134, 31);
            update_btn.TabIndex = 12;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.Red;
            delete_btn.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete_btn.ForeColor = Color.White;
            delete_btn.Location = new Point(170, 467);
            delete_btn.Margin = new Padding(3, 4, 3, 4);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(141, 31);
            delete_btn.TabIndex = 13;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // isCorrect1
            // 
            isCorrect1.AutoSize = true;
            isCorrect1.Location = new Point(8, 29);
            isCorrect1.Margin = new Padding(3, 4, 3, 4);
            isCorrect1.Name = "isCorrect1";
            isCorrect1.Size = new Size(17, 16);
            isCorrect1.TabIndex = 15;
            isCorrect1.TabStop = true;
            isCorrect1.UseVisualStyleBackColor = true;
            // 
            // isCorrect2
            // 
            isCorrect2.AutoSize = true;
            isCorrect2.Location = new Point(8, 64);
            isCorrect2.Margin = new Padding(3, 4, 3, 4);
            isCorrect2.Name = "isCorrect2";
            isCorrect2.Size = new Size(17, 16);
            isCorrect2.TabIndex = 16;
            isCorrect2.TabStop = true;
            isCorrect2.UseVisualStyleBackColor = true;
            // 
            // isCorrect3
            // 
            isCorrect3.AutoSize = true;
            isCorrect3.Location = new Point(8, 105);
            isCorrect3.Margin = new Padding(3, 4, 3, 4);
            isCorrect3.Name = "isCorrect3";
            isCorrect3.Size = new Size(17, 16);
            isCorrect3.TabIndex = 17;
            isCorrect3.TabStop = true;
            isCorrect3.UseVisualStyleBackColor = true;
            // 
            // isCorrect4
            // 
            isCorrect4.AutoSize = true;
            isCorrect4.Location = new Point(8, 141);
            isCorrect4.Margin = new Padding(3, 4, 3, 4);
            isCorrect4.Name = "isCorrect4";
            isCorrect4.Size = new Size(17, 16);
            isCorrect4.TabIndex = 18;
            isCorrect4.TabStop = true;
            isCorrect4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TF_radio);
            groupBox1.Controls.Add(mcq_radio);
            groupBox1.Location = new Point(16, 64);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(295, 75);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Type";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(choice4);
            groupBox2.Controls.Add(isCorrect4);
            groupBox2.Controls.Add(choice3);
            groupBox2.Controls.Add(isCorrect3);
            groupBox2.Controls.Add(choice2);
            groupBox2.Controls.Add(isCorrect2);
            groupBox2.Controls.Add(choice1);
            groupBox2.Controls.Add(isCorrect1);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(16, 227);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(295, 185);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            // 
            // btn_back
            // 
            btn_back.BackColor = SystemColors.ActiveCaption;
            btn_back.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.ForeColor = Color.Sienna;
            btn_back.Location = new Point(15, 506);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(296, 33);
            btn_back.TabIndex = 22;
            btn_back.Text = "Previous";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // course_name
            // 
            course_name.BackColor = Color.White;
            course_name.ForeColor = Color.Black;
            course_name.Location = new Point(14, 29);
            course_name.Margin = new Padding(3, 4, 3, 4);
            course_name.Name = "course_name";
            course_name.PlaceholderText = "Course Name";
            course_name.ReadOnly = true;
            course_name.Size = new Size(296, 28);
            course_name.TabIndex = 10;
            // 
            // InsExam
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1029, 575);
            Controls.Add(btn_back);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(delete_btn);
            Controls.Add(update_btn);
            Controls.Add(add_btn);
            Controls.Add(course_name);
            Controls.Add(DataGridView);
            Controls.Add(grade);
            Controls.Add(title);
            Font = new Font("Comic Sans MS", 9F);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1047, 622);
            MinimumSize = new Size(1047, 622);
            Name = "InsExam";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exam";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox title;
        private TextBox grade;
        private TextBox choice1;
        private TextBox choice4;
        private TextBox choice3;
        private TextBox choice2;
        private RadioButton TF_radio;
        private RadioButton mcq_radio;
        private DataGridView DataGridView;
        private Button add_btn;
        private Button update_btn;
        private Button delete_btn;
        private RadioButton isCorrect1;
        private RadioButton isCorrect2;
        private RadioButton isCorrect3;
        private RadioButton isCorrect4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_back;
        private TextBox course_name;
    }
}
