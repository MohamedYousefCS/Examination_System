using Examination_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Examination_System
{
    public partial class Course_InstForm : Form
    {
        ExaminationSystemContext db;
        int InsId = -1;
        int CourseId = -1;
        List<Course> courses;

        public Course_InstForm(int id)
        {
            db = new ExaminationSystemContext();
            InsId = id;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadCourses();
            RefreshDataGridView();
            btn_update.Visible = false;
            btn_delete.Visible = false;
            btn_questions.Visible = false;
            btn_topics.Visible = false;
        }

        private void LoadCourses()
        {

            courses = db.Courses.FromSqlRaw($"EXECUTE dbo.Select_Course_Inst {InsId}").AsEnumerable().ToList();
        }

        private void RefreshDataGridView()
        {

            DVG_InsCourses.DataSource = courses;

            DVG_InsCourses.Columns[0].Visible = false;
            DVG_InsCourses.Columns[4].Visible = false;
            DVG_InsCourses.Columns[5].Visible = false;
            DVG_InsCourses.Columns[6].Visible = false;
            DVG_InsCourses.Columns[7].Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_courseName.Text == "" || txt_duration.Text == "" || txt_grade.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }


            db.Database.ExecuteSqlRaw($"EXECUTE dbo.Insert_Course '{txt_courseName.Text}', {txt_duration.Text}, {txt_grade.Text}");
            CourseId = db.Courses.Max(c => c.Id);
            db.Database.ExecuteSqlRaw($"EXECUTE dbo.Insert_Course_Inst {CourseId}, {InsId}");


            LoadCourses();
            RefreshDataGridView();
            Msg("Added Successfully", true, false, false);
        }
        void Msg(string msg, bool add, bool update, bool delete)
        {
            btn_add.Visible = add;
            btn_update.Visible = update;
            btn_delete.Visible = delete;
            btn_questions.Visible = false;
            btn_topics.Visible = false;
            txt_courseName.Text = txt_duration.Text = txt_grade.Text = "";
            MessageBox.Show(msg);
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_courseName.Text == "" || txt_duration.Text == "" || txt_grade.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }


            db.Database.ExecuteSqlRaw($"EXECUTE dbo.Update_Course {CourseId}, '{txt_courseName.Text}', {txt_duration.Text}, {txt_grade.Text}");


            var updated = courses.SingleOrDefault(c => c.Id == CourseId);
            if (updated != null)
            {
                updated.Name = txt_courseName.Text;
                updated.Duration = int.Parse(txt_duration.Text);
                updated.Grade = int.Parse(txt_grade.Text);
                db.SaveChanges();

            }

            LoadCourses();
            RefreshDataGridView();
            Msg("Updated Successfully", true, false, false);
        }

        private void DVG_InsCourses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CourseId = (int)DVG_InsCourses.Rows[e.RowIndex].Cells[0].Value;
            txt_courseName.Text = DVG_InsCourses.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_duration.Text = DVG_InsCourses.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_grade.Text = DVG_InsCourses.Rows[e.RowIndex].Cells[3].Value.ToString();
            btn_add.Visible = false;
            btn_update.Visible = true;
            btn_delete.Visible = true;
            btn_questions.Visible = true;
            btn_topics.Visible = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            db.Database.ExecuteSqlRaw($"EXECUTE dbo.Delete_Course_Inst {CourseId}, {InsId}");
            db.Database.ExecuteSqlRaw($"EXECUTE dbo.Delete_Course {CourseId}");


            LoadCourses();
            RefreshDataGridView();

            Msg("Deleted Successfully", true, false, false);
        }
        private void btn_questions_Click(object sender, EventArgs e)
        {
            InsExamForm exam = new InsExamForm(InsId, CourseId);
            this.Hide();
            exam.ShowDialog();
            this.Close();

        }

        private void btn_topics_Click(object sender, EventArgs e)
        {

            this.Hide();
            topicsForm t = new topicsForm(CourseId, InsId);
            t.ShowDialog();
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Profile ins = new Profile(InsId, "Instructor");
            this.Hide();
            ins.ShowDialog();
            this.Close();
        }
    }
}
