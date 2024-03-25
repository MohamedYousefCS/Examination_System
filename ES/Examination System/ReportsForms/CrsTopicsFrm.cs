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
    public partial class CrsTopicsFrm : Form
    {
        private readonly ExaminationSystemContext _context;
        private readonly GetCrsTopicsDataSet _dataSet;
        int InsId = -1;
        public CrsTopicsFrm(int id)
        {
            InitializeComponent();
            InsId = id;
            _context = new ExaminationSystemContext();
            _dataSet = new GetCrsTopicsDataSet();
        }

        private void btn_getData_Click(object sender, EventArgs e)
        {
            try
            {
                var list = _context.Database.SqlQuery<CrsTopicsViewModel>($"EXEC dbo.GetCourseTopics {(int)cb_crs.SelectedValue}")
                              .AsNoTracking()
                              .ToList();

                _dataSet.GetCourseTopics.Clear();

                foreach (var item in list)
                {
                    var row = _dataSet.GetCourseTopics.NewGetCourseTopicsRow();
                    row.CourseTopic = item.CourseTopic;

                    _dataSet.GetCourseTopics.AddGetCourseTopicsRow(row);
                }

                CrsTopics.LocalReport.DataSources.Clear();

                CrsTopics.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", _dataSet.Tables["GetCourseTopics"]));

                CrsTopics.LocalReport.ReportPath = "C:\\Users\\lap0\\OneDrive\\Desktop\\ExaminionSystem\\Examination_System\\ES\\Examination System\\Reports\\GetTopics.rdlc";
                CrsTopics.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrsTopicsFrm_Load(object sender, EventArgs e)
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
