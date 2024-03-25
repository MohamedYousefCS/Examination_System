namespace Examination_System.ReportsForms
{
    partial class GetStudentGradeFrm
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
            GetStudentGrades = new Microsoft.Reporting.WinForms.ReportViewer();
            cb_stud = new ComboBox();
            btn_getData = new Button();
            label1 = new Label();
            btn_back = new Button();
            SuspendLayout();
            // 
            // GetStudentGrades
            // 
            GetStudentGrades.Location = new Point(205, 0);
            GetStudentGrades.Name = "ReportViewer";
            GetStudentGrades.ServerReport.BearerToken = null;
            GetStudentGrades.Size = new Size(820, 570);
            GetStudentGrades.TabIndex = 0;
            // 
            // cb_stud
            // 
            cb_stud.FormattingEnabled = true;
            cb_stud.Location = new Point(12, 93);
            cb_stud.Name = "cb_stud";
            cb_stud.Size = new Size(187, 28);
            cb_stud.TabIndex = 0;
            // 
            // btn_getData
            // 
            btn_getData.Location = new Point(31, 146);
            btn_getData.Name = "btn_getData";
            btn_getData.Size = new Size(140, 29);
            btn_getData.TabIndex = 1;
            btn_getData.Text = "Get Data";
            btn_getData.UseVisualStyleBackColor = true;
            btn_getData.Click += btn_getData_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 2;
            label1.Text = "Select Student";
            // 
            // btn_back
            // 
            btn_back.Location = new Point(31, 192);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(140, 29);
            btn_back.TabIndex = 4;
            btn_back.Text = "Back To Reports";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // GetStudentGradeFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 575);
            Controls.Add(btn_back);
            Controls.Add(label1);
            Controls.Add(btn_getData);
            Controls.Add(cb_stud);
            Controls.Add(GetStudentGrades);
            MaximumSize = new Size(1047, 622);
            MinimumSize = new Size(1047, 622);
            Name = "GetStudentGradeFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GetStudentGrade";
            Load += GetStudentGrade_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer GetStudentGrades;
        private ComboBox cb_stud;
        private Button btn_getData;
        private Label label1;
        private Button btn_back;
    }
}