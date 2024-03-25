using Examination_System.ReportsForms;
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
    public partial class Reports : Form
    {
        int InsId = -1;
        public Reports(int id)
        {
            InsId = id;
            InitializeComponent();
        }

        private void btn_StudentsByCourseId_Click(object sender, EventArgs e)
        {
            StudentCrs report = new StudentCrs(InsId);
            this.Hide();
            report.ShowDialog();
            this.Close();
        }

        private void btn_GetStudentGradeFrm_Click(object sender, EventArgs e)
        {
            GetStudentGradeFrm report = new GetStudentGradeFrm(InsId);
            this.Hide();
            report.ShowDialog();
            this.Close();
        }

        private void btn_StudentCountFrm_Click(object sender, EventArgs e)
        {
            StudentCountFrm report = new StudentCountFrm(InsId);
            this.Hide();
            report.ShowDialog();
            this.Close();
        }

        private void btn_CrsTopicsFrm_Click(object sender, EventArgs e)
        {
            CrsTopicsFrm report = new CrsTopicsFrm(InsId);
            this.Hide();
            report.ShowDialog();
            this.Close();
        }

        private void btn_DisplayExamFrm_Click(object sender, EventArgs e)
        {
            DisplayExamFrm report = new DisplayExamFrm(InsId);
            this.Hide();
            report.ShowDialog();
            this.Close();
        }

        private void btn_ExamCorrectionFrm_Click(object sender, EventArgs e)
        {
            ExamCorrectionFrm report = new ExamCorrectionFrm(InsId);
            this.Hide();
            report.ShowDialog();
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(InsId, "Instructor");
            this.Hide();
            profile.ShowDialog();
            this.Close();
        }
    }
}
