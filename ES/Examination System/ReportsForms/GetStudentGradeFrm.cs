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
    public partial class GetStudentGradeFrm : Form
    {
        private readonly ExaminationSystemContext _context;
        private readonly CalcStudentGradesDataSet _dataSet;
        int InsId = -1;
        public GetStudentGradeFrm(int id)
        {
            InitializeComponent();
            InsId=id;
            _context = new ExaminationSystemContext();
            _dataSet = new CalcStudentGradesDataSet();
        }

        private void GetStudentGrade_Load(object sender, EventArgs e)
        {
            cb_stud.DataSource = _context.Students.ToList();
            cb_stud.DisplayMember = "Name";
            cb_stud.ValueMember = "Id";

        }
        private void btn_getData_Click(object sender, EventArgs e)
        {
            try
            {
                var list = _context.Database.SqlQuery<StudentDegreeViewModel>($"EXEC dbo.CalculateStudentGrade {(int)cb_stud.SelectedValue}")
                              .AsNoTracking()
                              .ToList();

                _dataSet.CalculateStudentGrade.Clear();

                foreach (var item in list)
                {
                    var row = _dataSet.CalculateStudentGrade.NewCalculateStudentGradeRow();
                    row.CourseName=item.CourseName;
                    row.FinalMark=item.FinalMark;

                    _dataSet.CalculateStudentGrade.AddCalculateStudentGradeRow(row);
                }

                GetStudentGrades.LocalReport.DataSources.Clear();

                GetStudentGrades.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", _dataSet.Tables["CalculateStudentGrade"]));

                GetStudentGrades.LocalReport.ReportPath = "C:\\Users\\lap0\\OneDrive\\Desktop\\ExaminionSystem\\Examination_System\\ES\\Examination System\\Reports\\GetStudGrade.rdlc";

                GetStudentGrades.RefreshReport();
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
