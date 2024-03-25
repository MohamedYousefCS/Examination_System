using Examination_System.Forms;
using Examination_System.Models;
using Examination_System.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System.ReportsForms
{
    public partial class StudentCountFrm : Form
    {
        private readonly ExaminationSystemContext _context;
        private readonly GetStudentCountInCrs _dataSet;
        int InsId = -1;
        public StudentCountFrm(int id)
        {
            InitializeComponent();
            InsId = id;
            _context = new ExaminationSystemContext();
            _dataSet = new GetStudentCountInCrs();
        }

        private void StudentCountFrm_Load(object sender, EventArgs e)
        {
            cb_ins.DataSource = _context.Students.ToList();
            cb_ins.DisplayMember = "Name";
            cb_ins.ValueMember = "Id";
        }

        private void btn_GetData_Click(object sender, EventArgs e)
        {
            try
            {
                var list = _context.Database.SqlQuery<InstructorCoursesViewModel>($"EXEC dbo.GetInstructorCoursesAndStudents {(int)cb_ins.SelectedValue}")
                              .AsNoTracking()
                              .ToList();

                _dataSet.GetInstructorCoursesAndStudents.Clear();

                foreach (var item in list)
                {
                    var row = _dataSet.GetInstructorCoursesAndStudents.NewGetInstructorCoursesAndStudentsRow();
                    row.CourseName = item.CourseName;
                    row.NumberOfStudents = item.NumberOfStudents;

                    _dataSet.GetInstructorCoursesAndStudents.AddGetInstructorCoursesAndStudentsRow(row);
                }

                StuCount.LocalReport.DataSources.Clear();

                StuCount.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", _dataSet.Tables["GetInstructorCoursesAndStudents"]));

                StuCount.LocalReport.ReportPath = "C:\\Users\\lap0\\OneDrive\\Desktop\\ExaminionSystem\\Examination_System\\ES\\Examination System\\Reports\\GetStuCountInCrs.rdlc";
                StuCount.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Reports report = new Reports(InsId);
            this.Hide();
            report.ShowDialog();
            this.Close();
        }
    }
}
