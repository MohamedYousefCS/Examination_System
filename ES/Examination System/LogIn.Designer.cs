namespace Examination_System
{
    partial class LogIn
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
            Btn_LogIn = new Button();
            label1 = new Label();
            label2 = new Label();
            Txt_Email = new TextBox();
            Txt_Password = new TextBox();
            label3 = new Label();
            Cb_type = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // Btn_LogIn
            // 
            Btn_LogIn.BackColor = Color.White;
            Btn_LogIn.FlatAppearance.BorderColor = Color.FromArgb(112, 119, 161);
            Btn_LogIn.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_LogIn.ForeColor = Color.Black;
            Btn_LogIn.Location = new Point(419, 393);
            Btn_LogIn.Name = "Btn_LogIn";
            Btn_LogIn.Size = new Size(129, 41);
            Btn_LogIn.TabIndex = 0;
            Btn_LogIn.Text = "Log In";
            Btn_LogIn.UseVisualStyleBackColor = false;
            Btn_LogIn.Click += Btn_LogIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(310, 172);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Email ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(310, 241);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // Txt_Email
            // 
            Txt_Email.BackColor = Color.White;
            Txt_Email.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Email.ForeColor = Color.Black;
            Txt_Email.Location = new Point(310, 195);
            Txt_Email.Name = "Txt_Email";
            Txt_Email.Size = new Size(341, 35);
            Txt_Email.TabIndex = 4;
            // 
            // Txt_Password
            // 
            Txt_Password.BackColor = Color.White;
            Txt_Password.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Password.ForeColor = Color.Black;
            Txt_Password.Location = new Point(310, 264);
            Txt_Password.Name = "Txt_Password";
            Txt_Password.Size = new Size(341, 35);
            Txt_Password.TabIndex = 5;
            Txt_Password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(419, 96);
            label3.Name = "label3";
            label3.Size = new Size(116, 33);
            label3.TabIndex = 6;
            label3.Text = "Welcome";
            // 
            // Cb_type
            // 
            Cb_type.BackColor = Color.White;
            Cb_type.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cb_type.ForeColor = Color.Black;
            Cb_type.FormattingEnabled = true;
            Cb_type.Location = new Point(310, 333);
            Cb_type.Name = "Cb_type";
            Cb_type.Size = new Size(340, 36);
            Cb_type.TabIndex = 7;
            Cb_type.SelectedIndexChanged += Cb_type_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(310, 310);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 3;
            label4.Text = "Role";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1029, 575);
            Controls.Add(Cb_type);
            Controls.Add(label3);
            Controls.Add(Txt_Password);
            Controls.Add(Txt_Email);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn_LogIn);
            Font = new Font("Comic Sans MS", 9F);
            MaximumSize = new Size(1047, 622);
            MinimumSize = new Size(1047, 622);
            Name = "LogIn";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            Load += LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_LogIn;
        private Label label1;
        private Label label2;
        private TextBox Txt_Email;
        private TextBox Txt_Password;
        private Label label3;
        private ComboBox Cb_type;
        private Label label4;
    }
}
