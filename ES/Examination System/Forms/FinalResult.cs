using Examination_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Examination_System
{

    public partial class FinalResult : Form
    {
        int ExamId;
        int CourseID;
        int StudentId;
        ExaminationSystemContext db;
        public FinalResult(int examId, int courseId, int studentId)
        {
            InitializeComponent();
            db = new ExaminationSystemContext();
            this.ExamId = examId;
            this.CourseID = courseId;
            this.StudentId = studentId;
        }
        public class StudentFinalMarkResult
        {
            public decimal FinalMark { get; set; }
        }

        private void FinalResult_Load(object sender, EventArgs e)
        {
            lb_CourseName.Text = db.Courses.Where(c => c.Id == CourseID).Select(c => c.Name).FirstOrDefault();
            lb_ExamTitle.Text = db.Exams.Where(c => c.Id == ExamId).Select(c => c.Title).FirstOrDefault();
            lb_StudentName.Text = db.Students.Where(c => c.Id == StudentId).Select(c => c.Name).FirstOrDefault();


            var finalMarkResult = db.Database.SqlQuery<StudentFinalMarkResult>($"StudentFinalMark {StudentId}, {CourseID}").AsEnumerable().FirstOrDefault();
            lb_FinalGrade.Text = $"{Math.Round(finalMarkResult.FinalMark).ToString()} %";

        }

        private void btn_BackToCourses_Click(object sender, EventArgs e)
        {
            StudentCoursesForm studCourses = new StudentCoursesForm(StudentId);
            this.Hide();
            studCourses.ShowDialog();
            this.Close();
        }

        private void btn_CloseTheApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
