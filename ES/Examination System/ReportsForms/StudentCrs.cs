using Examination_System.Models;
using Examination_System.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using Stimulsoft.Report;
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
    public partial class StudentCrs : Form
    {
        private readonly ExaminationSystemContext _context;
        private readonly ExaminationSystemDataSet _dataSet;
        int InsId = -1;
        public StudentCrs(int insId)
        {
            InitializeComponent();
            _context = new ExaminationSystemContext();
            _dataSet = new ExaminationSystemDataSet();
            InsId = insId;
        }


        private void btnGetData_Click(object sender, EventArgs e)
        {

            try
            {
                var list = _context.Database.SqlQuery<StudentsCourseViewModel>($"EXEC dbo.GetStudentCoursesByCourseId {(int)cb_crs.SelectedValue}")
                              .AsNoTracking()
                              .ToList();

                _dataSet.GetStudentCoursesByCourseId.Clear();

                foreach (var item in list)
                {
                    var row = _dataSet.GetStudentCoursesByCourseId.NewGetStudentCoursesByCourseIdRow();

                    row.id = item.id;
                    row.Name = item.Name;
                    row.Email = item.Email;
                    row.Dept_id = item.Dept_id;
                    row.Course_id = item.Course_id;

                    _dataSet.GetStudentCoursesByCourseId.AddGetStudentCoursesByCourseIdRow(row);
                }

                reportStudnetCourseById.LocalReport.DataSources.Clear();

                reportStudnetCourseById.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", _dataSet.Tables["GetStudentCoursesByCourseId"]));

                reportStudnetCourseById.LocalReport.ReportPath = @"../../../Reports\\StudentsByCourseId.rdlc";
                reportStudnetCourseById.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Report_Load(object sender, EventArgs e)
        {
            cb_crs.DataSource = _context.Courses.ToList();
            cb_crs.DisplayMember = "Name";
            cb_crs.ValueMember = "Id";
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
