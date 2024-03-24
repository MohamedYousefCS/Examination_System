using Examination_System.Models;
using System.Windows.Forms;
namespace Examination_System
{
    public partial class StudentCoursesForm : Form
    {
        ExaminationSystemContext db;
        int StdId = -1;
        public StudentCoursesForm(int studentId)
        {
            StdId = studentId;
            InitializeComponent();
            db = new ExaminationSystemContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_Courses.DataSource = db.Courses.Select(c => new { c.Id, c.Name, c.Duration, c.Grade }).ToList();
            lb_topics.Visible = false;
            btn_takeExam.Visible = false;
            lbl_topic.Visible = false;
        }
        int id;
        private void dgv_Courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_Courses.SelectedRows[0].Cells[0].Value;
            Course course = db.Courses.Where(c => c.Id == id).FirstOrDefault();

            tb_courseName.Text = course.Name;
            nu_Duration.Value = course.Duration;
            nu_grade.Value = course.Grade;

            var theTopics = db.CourseTopics.Where(ct => ct.CourseId == id).Select(t => new { t.CourseId, t.Topic }).ToList();
           
            var topics =theTopics.Select(t => t.Topic).ToArray();
            lb_topics.Items.Clear();
            foreach (var topic in topics)
            {
                lb_topics.Items.Add(topic);
            }
            btn_takeExam.Visible = true;
            lbl_topic.Visible = true;
            lb_topics.Visible=true;
        }

        private void btn_takeExam_Click(object sender, EventArgs e)
        {
            StudentExamForm exam = new StudentExamForm(id, StdId);
            this.Hide();
            exam.ShowDialog();
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Profile p = new Profile(StdId, "Student");
            this.Hide();
            p.ShowDialog();
            this.Close();
        }
    }
}
