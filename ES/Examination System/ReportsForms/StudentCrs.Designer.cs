namespace Examination_System
{
    partial class StudentCrs
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
            btnGetData = new Button();
            reportStudnetCourseById = new Microsoft.Reporting.WinForms.ReportViewer();
            cb_crs = new ComboBox();
            lbl_np1 = new Label();
            btn_back = new Button();
            SuspendLayout();
            // 
            // btnGetData
            // 
            btnGetData.Location = new Point(35, 139);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(140, 29);
            btnGetData.TabIndex = 0;
            btnGetData.Text = "Get Data";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // reportStudnetCourseById
            // 
            reportStudnetCourseById.Location = new Point(205, 0);
            reportStudnetCourseById.Name = "ReportViewer";
            reportStudnetCourseById.ServerReport.BearerToken = null;
            reportStudnetCourseById.Size = new Size(820, 570);
            reportStudnetCourseById.TabIndex = 0;
            // 
            // cb_crs
            // 
            cb_crs.FormattingEnabled = true;
            cb_crs.Location = new Point(12, 81);
            cb_crs.Name = "cb_crs";
            cb_crs.Size = new Size(188, 28);
            cb_crs.TabIndex = 3;
            // 
            // lbl_np1
            // 
            lbl_np1.AutoSize = true;
            lbl_np1.Location = new Point(12, 58);
            lbl_np1.Name = "lbl_np1";
            lbl_np1.Size = new Size(54, 20);
            lbl_np1.TabIndex = 6;
            lbl_np1.Text = "Course";
            // 
            // btn_back
            // 
            btn_back.Location = new Point(35, 185);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(140, 29);
            btn_back.TabIndex = 7;
            btn_back.Text = "Back To Reports";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // StudentCrs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 575);
            Controls.Add(btn_back);
            Controls.Add(lbl_np1);
            Controls.Add(cb_crs);
            Controls.Add(reportStudnetCourseById);
            Controls.Add(btnGetData);
            MaximumSize = new Size(1047, 622);
            MinimumSize = new Size(1047, 622);
            Name = "StudentCrs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report";
            Load += Report_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetData;
        private TextBox txtCourseId;
        private Microsoft.Reporting.WinForms.ReportViewer reportStudnetCourseById;
        private ComboBox cb_report;
        private ComboBox cb_crs;
        private ComboBox cb_sinp;
        private Label label1;
        private Label lbl_np1;
        private Label lbl_inp2;
        private Button btn_back;
    }
}