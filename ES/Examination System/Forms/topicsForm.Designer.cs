namespace Examination_System
{
    partial class topicsForm
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
            DGV_topics = new DataGridView();
            txt_topics = new TextBox();
            label4 = new Label();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            btn_instCourse = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV_topics).BeginInit();
            SuspendLayout();
            // 
            // DGV_topics
            // 
            DGV_topics.BackgroundColor = SystemColors.ButtonFace;
            DGV_topics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_topics.Location = new Point(759, 8);
            DGV_topics.Margin = new Padding(2);
            DGV_topics.Name = "DGV_topics";
            DGV_topics.RowHeadersWidth = 62;
            DGV_topics.Size = new Size(240, 556);
            DGV_topics.TabIndex = 17;
            DGV_topics.RowHeaderMouseDoubleClick += DGV_topics_RowHeaderMouseDoubleClick;
            // 
            // txt_topics
            // 
            txt_topics.Location = new Point(194, 231);
            txt_topics.Margin = new Padding(2);
            txt_topics.Name = "txt_topics";
            txt_topics.Size = new Size(373, 27);
            txt_topics.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9F);
            label4.Location = new Point(194, 209);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 15;
            label4.Text = "Topic";
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(385, 303);
            btn_delete.Margin = new Padding(2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(182, 27);
            btn_delete.TabIndex = 20;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(194, 303);
            btn_update.Margin = new Padding(2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(187, 27);
            btn_update.TabIndex = 19;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(194, 272);
            btn_add.Margin = new Padding(2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(373, 27);
            btn_add.TabIndex = 18;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_instCourse
            // 
            btn_instCourse.Location = new Point(194, 344);
            btn_instCourse.Margin = new Padding(2);
            btn_instCourse.Name = "btn_instCourse";
            btn_instCourse.Size = new Size(373, 27);
            btn_instCourse.TabIndex = 21;
            btn_instCourse.Text = "Back To Courses";
            btn_instCourse.UseVisualStyleBackColor = true;
            btn_instCourse.Click += btn_instCourse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(312, 78);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 56);
            label1.TabIndex = 22;
            label1.Text = "Topics";
            // 
            // topics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 575);
            Controls.Add(label1);
            Controls.Add(btn_instCourse);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(DGV_topics);
            Controls.Add(txt_topics);
            Controls.Add(label4);
            Margin = new Padding(2);
            MaximumSize = new Size(1047, 622);
            MinimumSize = new Size(1047, 622);
            Name = "topics";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "topics";
            Load += topics_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_topics).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_topics;
        private TextBox txt_topics;
        private Label label4;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private Button btn_instCourse;
        private Label label1;
    }
}