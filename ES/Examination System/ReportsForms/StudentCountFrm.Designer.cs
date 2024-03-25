namespace Examination_System.ReportsForms
{
    partial class StudentCountFrm
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
            StuCount = new Microsoft.Reporting.WinForms.ReportViewer();
            label1 = new Label();
            cb_ins = new ComboBox();
            btn_GetData = new Button();
            btn_back = new Button();
            SuspendLayout();
            // 
            // StuCount
            // 
            StuCount.Location = new Point(205, 0);
            StuCount.Name = "ReportViewer";
            StuCount.ServerReport.BearerToken = null;
            StuCount.Size = new Size(820, 570);
            StuCount.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Instructor";
            // 
            // cb_ins
            // 
            cb_ins.FormattingEnabled = true;
            cb_ins.Location = new Point(12, 87);
            cb_ins.Name = "cb_ins";
            cb_ins.Size = new Size(189, 28);
            cb_ins.TabIndex = 1;
            // 
            // btn_GetData
            // 
            btn_GetData.Location = new Point(30, 145);
            btn_GetData.Name = "btn_GetData";
            btn_GetData.Size = new Size(144, 29);
            btn_GetData.TabIndex = 2;
            btn_GetData.Text = "Get Data";
            btn_GetData.UseVisualStyleBackColor = true;
            btn_GetData.Click += btn_GetData_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(30, 195);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(144, 29);
            btn_back.TabIndex = 4;
            btn_back.Text = "Back To Reports";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // StudentCountFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 575);
            Controls.Add(btn_back);
            Controls.Add(btn_GetData);
            Controls.Add(cb_ins);
            Controls.Add(label1);
            Controls.Add(StuCount);
            MaximumSize = new Size(1047, 622);
            MinimumSize = new Size(1047, 622);
            Name = "StudentCountFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentCountFrm";
            Load += StudentCountFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer StuCount;
        private Label label1;
        private ComboBox cb_ins;
        private Button btn_GetData;
        private Button btn_back;
    }
}