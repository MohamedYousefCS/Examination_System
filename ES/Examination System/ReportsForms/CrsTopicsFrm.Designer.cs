namespace Examination_System.ReportsForms
{
    partial class CrsTopicsFrm
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
            CrsTopics = new Microsoft.Reporting.WinForms.ReportViewer();
            cb_crs = new ComboBox();
            label1 = new Label();
            btn_getData = new Button();
            btn_back = new Button();
            SuspendLayout();
            // 
            // CrsTopics
            // 
            CrsTopics.Location = new Point(205, 0);
            CrsTopics.Name = "ReportViewer";
            CrsTopics.ServerReport.BearerToken = null;
            CrsTopics.Size = new Size(820, 570);
            CrsTopics.TabIndex = 0;
            // 
            // cb_crs
            // 
            cb_crs.FormattingEnabled = true;
            cb_crs.Location = new Point(12, 85);
            cb_crs.Name = "cb_crs";
            cb_crs.Size = new Size(181, 28);
            cb_crs.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 1;
            label1.Text = "Course";
            // 
            // btn_getData
            // 
            btn_getData.Location = new Point(33, 161);
            btn_getData.Name = "btn_getData";
            btn_getData.Size = new Size(140, 29);
            btn_getData.TabIndex = 2;
            btn_getData.Text = "Get Data";
            btn_getData.UseVisualStyleBackColor = true;
            btn_getData.Click += btn_getData_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(33, 214);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(140, 29);
            btn_back.TabIndex = 3;
            btn_back.Text = "Back To Reports";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // CrsTopicsFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 575);
            Controls.Add(btn_back);
            Controls.Add(btn_getData);
            Controls.Add(label1);
            Controls.Add(cb_crs);
            Controls.Add(CrsTopics);
            MaximumSize = new Size(1047, 622);
            MinimumSize = new Size(1047, 622);
            Name = "CrsTopicsFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrsTopicsFrm";
            Load += CrsTopicsFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer CrsTopics;
        private ComboBox cb_crs;
        private Label label1;
        private Button btn_getData;
        private Button btn_back;
    }
}