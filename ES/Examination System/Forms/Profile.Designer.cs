namespace Examination_System
{
    partial class Profile
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
            txt_name = new TextBox();
            txt_email = new TextBox();
            txt_data = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbl_data = new Label();
            btn_update = new Button();
            btn_pass = new Button();
            btn_courses = new Button();
            btn_Reports = new Button();
            btn_logOut = new Button();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.Location = new Point(339, 161);
            txt_name.Name = "txt_name";
            txt_name.ReadOnly = true;
            txt_name.Size = new Size(345, 28);
            txt_name.TabIndex = 0;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(339, 214);
            txt_email.Name = "txt_email";
            txt_email.ReadOnly = true;
            txt_email.Size = new Size(345, 28);
            txt_email.TabIndex = 1;
            // 
            // txt_data
            // 
            txt_data.Location = new Point(339, 267);
            txt_data.Name = "txt_data";
            txt_data.ReadOnly = true;
            txt_data.Size = new Size(345, 28);
            txt_data.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F);
            label1.Location = new Point(433, 68);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 3;
            label1.Text = "Profile Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 138);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 4;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 191);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 5;
            label3.Text = "Email Address";
            // 
            // lbl_data
            // 
            lbl_data.AutoSize = true;
            lbl_data.Location = new Point(339, 244);
            lbl_data.Name = "lbl_data";
            lbl_data.Size = new Size(67, 20);
            lbl_data.TabIndex = 6;
            lbl_data.Text = "lbl_data";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(376, 345);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(279, 29);
            btn_update.TabIndex = 7;
            btn_update.Text = "Update Data";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_pass
            // 
            btn_pass.Location = new Point(376, 380);
            btn_pass.Name = "btn_pass";
            btn_pass.Size = new Size(279, 29);
            btn_pass.TabIndex = 8;
            btn_pass.Text = "Update Password";
            btn_pass.UseVisualStyleBackColor = true;
            btn_pass.Click += btn_pass_Click;
            // 
            // btn_courses
            // 
            btn_courses.Location = new Point(376, 415);
            btn_courses.Name = "btn_courses";
            btn_courses.Size = new Size(279, 29);
            btn_courses.TabIndex = 9;
            btn_courses.Text = "My Courses";
            btn_courses.UseVisualStyleBackColor = true;
            btn_courses.Click += btn_courses_Click;
            // 
            // btn_Reports
            // 
            btn_Reports.Location = new Point(376, 310);
            btn_Reports.Name = "btn_Reports";
            btn_Reports.Size = new Size(279, 29);
            btn_Reports.TabIndex = 10;
            btn_Reports.Text = "Reports";
            btn_Reports.UseVisualStyleBackColor = true;
            btn_Reports.Click += btn_Reports_Click;
            // 
            // btn_logOut
            // 
            btn_logOut.Location = new Point(376, 450);
            btn_logOut.Name = "btn_logOut";
            btn_logOut.Size = new Size(279, 29);
            btn_logOut.TabIndex = 11;
            btn_logOut.Text = "Log Out";
            btn_logOut.UseVisualStyleBackColor = true;
            btn_logOut.Click += btn_logOut_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 575);
            Controls.Add(btn_logOut);
            Controls.Add(btn_Reports);
            Controls.Add(btn_courses);
            Controls.Add(btn_pass);
            Controls.Add(btn_update);
            Controls.Add(lbl_data);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_data);
            Controls.Add(txt_email);
            Controls.Add(txt_name);
            Font = new Font("Comic Sans MS", 9F);
            MaximumSize = new Size(1047, 622);
            MinimumSize = new Size(1047, 622);
            Name = "Profile";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            Load += Profile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private TextBox txt_email;
        private TextBox txt_data;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbl_data;
        private Button btn_update;
        private Button btn_pass;
        private Button btn_courses;
        private Button btn_Reports;
        private Button btn_logOut;
    }
}