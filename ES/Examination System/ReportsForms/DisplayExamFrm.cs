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
    public partial class DisplayExamFrm : Form
    {
        private readonly ExaminationSystemContext _context;
        private readonly DisplayExamDataSet _dataSet;
        int InsId = -1;
        public DisplayExamFrm(int id)
        {
            InitializeComponent();
            InsId = id;
            _context = new ExaminationSystemContext();
            _dataSet = new DisplayExamDataSet();
        }

        private void btn_getData_Click(object sender, EventArgs e)
        {
            try
            {
                var list = _context.Database.SqlQuery<DisplayExamViewModel>($"EXEC dbo.DisplayExam {(int)cb_Exam.SelectedValue},{(int)cb_stud.SelectedValue}")
                              .AsNoTracking()
                              .ToList();

                _dataSet.DisplayExam.Clear();

                foreach (var item in list)
                {
                    var row = _dataSet.DisplayExam.NewDisplayExamRow();
                    row.Question_ID = item.Question_ID;
                    row.Title = item.Title;
                    row.choice = item.choice;

                    _dataSet.DisplayExam.AddDisplayExamRow(row);
                }

                Exam.LocalReport.DataSources.Clear();

                Exam.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", _dataSet.Tables["DisplayExam"]));

                Exam.LocalReport.ReportPath = @"../../../Reports\\DisplayExam.rdlc";

                Exam.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayExamFrm_Load(object sender, EventArgs e)
        {
            cb_stud.DataSource = _context.Students.ToList();
            cb_stud.DisplayMember = "Name";
            cb_stud.ValueMember = "Id";
            if (cb_stud.SelectedItem != null)
            {
                if (cb_stud.SelectedItem is Student selectedStudent)
                {
                    int studentId = selectedStudent.Id;
                    cb_Exam.DataSource = _context.ExamStQs.Where(s => s.StudentId == studentId).Select(e => new { ExamId = e.ExamId }).Distinct().ToList();
                    cb_Exam.DisplayMember = "ExamId";
                    cb_Exam.ValueMember = "ExamId";
                }
            }
        }

        private void cb_stud_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_stud.SelectedItem != null)
            {
                if (cb_stud.SelectedItem is Student selectedStudent)
                {
                    int studentId = selectedStudent.Id;
                    cb_Exam.DataSource = _context.ExamStQs.Where(s => s.StudentId == studentId).Select(e => new { ExamId = e.ExamId }).Distinct().ToList();
                    cb_Exam.DisplayMember = "ExamId";
                    cb_Exam.ValueMember = "ExamId";
                }
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
