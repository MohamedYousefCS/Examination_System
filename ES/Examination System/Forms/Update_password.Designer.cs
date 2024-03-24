namespace Examination_System
{
    partial class Update_password
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
            txt_old = new TextBox();
            txt_new = new TextBox();
            txt_confirm = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_update = new Button();
            btn_profile = new Button();
            SuspendLayout();
            // 
            // txt_old
            // 
            txt_old.Location = new Point(338, 194);
            txt_old.Name = "txt_old";
            txt_old.Size = new Size(250, 28);
            txt_old.TabIndex = 0;
            txt_old.UseSystemPasswordChar = true;
            // 
            // txt_new
            // 
            txt_new.Location = new Point(338, 247);
            txt_new.Name = "txt_new";
            txt_new.Size = new Size(250, 28);
            txt_new.TabIndex = 0;
            txt_new.UseSystemPasswordChar = true;
            // 
            // txt_confirm
            // 
            txt_confirm.Location = new Point(338, 300);
            txt_confirm.Name = "txt_confirm";
            txt_confirm.Size = new Size(250, 28);
            txt_confirm.TabIndex = 0;
            txt_confirm.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 171);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 1;
            label1.Text = "Old Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 224);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 2;
            label2.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 277);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 3;
            label3.Text = "Confirm Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F);
            label4.Location = new Point(357, 90);
            label4.Name = "label4";
            label4.Size = new Size(172, 28);
            label4.TabIndex = 4;
            label4.Text = "Update Password";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(357, 352);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(206, 29);
            btn_update.TabIndex = 5;
            btn_update.Text = "Update Password";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_profile
            // 
            btn_profile.Location = new Point(357, 387);
            btn_profile.Name = "btn_profile";
            btn_profile.Size = new Size(206, 29);
            btn_profile.TabIndex = 6;
            btn_profile.Text = "Back To Profile";
            btn_profile.UseVisualStyleBackColor = true;
            btn_profile.Click += btn_profile_Click;
            // 
            // Update_password
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 575);
            Controls.Add(btn_profile);
            Controls.Add(btn_update);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_confirm);
            Controls.Add(txt_new);
            Controls.Add(txt_old);
            Font = new Font("Comic Sans MS", 9F);
            MaximumSize = new Size(1047, 622);
            MinimumSize = new Size(1047, 622);
            Name = "Update_password";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update_password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_old;
        private TextBox txt_new;
        private TextBox txt_confirm;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_update;
        private Button btn_profile;
    }
}