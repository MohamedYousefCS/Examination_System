namespace Examination_System.ReportsForms
{
    partial class ExamCorrectionFrm
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
            Exam = new Microsoft.Reporting.WinForms.ReportViewer();
            btn_getData = new Button();
            cb_Exam = new ComboBox();
            cb_stud = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            btn_back = new Button();
            SuspendLayout();
            // 
            // Exam
            // 
            Exam.Location = new Point(205, 0);
            Exam.Name = "ReportViewer";
            Exam.ServerReport.BearerToken = null;
            Exam.Size = new Size(820, 570);
            Exam.TabIndex = 0;
            // 
            // btn_getData
            // 
            btn_getData.Location = new Point(36, 212);
            btn_getData.Name = "btn_getData";
            btn_getData.Size = new Size(140, 29);
            btn_getData.TabIndex = 9;
            btn_getData.Text = "Get Data";
            btn_getData.UseVisualStyleBackColor = true;
            btn_getData.Click += btn_getData_Click;
            // 
            // cb_Exam
            // 
            cb_Exam.FormattingEnabled = true;
            cb_Exam.Location = new Point(12, 152);
            cb_Exam.Name = "cb_Exam";
            cb_Exam.Size = new Size(189, 28);
            cb_Exam.TabIndex = 8;
            // 
            // cb_stud
            // 
            cb_stud.FormattingEnabled = true;
            cb_stud.Location = new Point(12, 83);
            cb_stud.Name = "cb_stud";
            cb_stud.Size = new Size(189, 28);
            cb_stud.TabIndex = 7;
            cb_stud.SelectedIndexChanged += cb_stud_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 129);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 6;
            label2.Text = "Exam";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 5;
            label1.Text = "Student";
            // 
            // btn_back
            // 
            btn_back.Location = new Point(36, 261);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(140, 29);
            btn_back.TabIndex = 10;
            btn_back.Text = "Back To Reports";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // ExamCorrectionFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 575);
            Controls.Add(btn_back);
            Controls.Add(btn_getData);
            Controls.Add(cb_Exam);
            Controls.Add(cb_stud);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Exam);
            MaximumSize = new Size(1047, 622);
            MinimumSize = new Size(1047, 622);
            Name = "ExamCorrectionFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExamCorrectionFrm";
            Load += ExamCorrectionFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Exam;
        private Button btn_getData;
        private ComboBox cb_Exam;
        private ComboBox cb_stud;
        private Label label2;
        private Label label1;
        private Button btn_back;
    }
}