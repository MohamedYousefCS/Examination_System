using Examination_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Examination_System
{
    public partial class topicsForm : Form
    {
        ExaminationSystemContext db;
        int CourseId = -1;
        string oldTopicName = "";
        int Insid = -1;
        public topicsForm(int courseId, int insid)
        {
            db = new ExaminationSystemContext();
            InitializeComponent();
            CourseId = courseId;
            Insid = insid;

        }

        private void topics_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
            btn_update.Visible = false;
            btn_delete.Visible = false;
        }

        private void RefreshDataGridView()
        {
            DGV_topics.DataSource = db.CourseTopics.FromSqlRaw($"EXECUTE dbo.Select_Course_Topic {CourseId}").ToList();
            DGV_topics.Columns[0].Visible = false;
            DGV_topics.Columns[2].Visible = false;


            if (DGV_topics.Rows.Count > 0)
            {
                DGV_topics.Rows[0].Selected = true;
                int topicId = (int)DGV_topics.Rows[0].Cells[0].Value;
                string topicName = (string)DGV_topics.Rows[0].Cells[1].Value;
                oldTopicName = topicName;
                txt_topics.Text = topicName;
            }
        }

        private void DGV_topics_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int topicId = (int)DGV_topics.Rows[e.RowIndex].Cells[0].Value;
            string topicName = (string)DGV_topics.Rows[e.RowIndex].Cells[1].Value;
            oldTopicName = topicName;
            txt_topics.Text = topicName;
            btn_update.Visible = true;
            btn_delete.Visible = true;
            btn_add.Visible = false;
        }
        void Msg(string msg, bool add, bool update, bool delete)
        {
            btn_add.Visible = add;
            btn_update.Visible = update;
            btn_delete.Visible = delete;
            txt_topics.Text = "";
            MessageBox.Show(msg);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_topics.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            db.Database.ExecuteSqlRaw($"EXECUTE dbo.Insert_Course_Topic {CourseId},'{txt_topics.Text}'");
            RefreshDataGridView();
            Msg("Added Successfully", true, false, false);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (DGV_topics.SelectedRows.Count > 0)
            {
                if (txt_topics.Text == "")
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }
                int topicId = (int)DGV_topics.SelectedRows[0].Cells[0].Value;
                db.Database.ExecuteSqlRaw($"EXECUTE dbo.Update_Course_Topic {topicId},'{oldTopicName}','{txt_topics.Text}'");
                RefreshDataGridView();
                Msg("Updated Successfully", true, false, false);
            }
            else
            {
                MessageBox.Show("Please select a row to update");
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (DGV_topics.SelectedRows.Count > 0)
            {
                int topicId = (int)DGV_topics.SelectedRows[0].Cells[0].Value;
                db.Database.ExecuteSqlRaw($"EXECUTE dbo.Delete_Course_Topic {topicId},'{oldTopicName}'");
                RefreshDataGridView();
                Msg("Deleted Successfully", true, false, false);
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }
        }

        private void btn_instCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Course_InstForm course_Inst = new Course_InstForm(Insid);
            course_Inst.ShowDialog();
            this.Close();
        }
    }
}
