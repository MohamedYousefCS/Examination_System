using Examination_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Examination_System
{
    public partial class Profile : Form
    {
        ExaminationSystemContext db;
        int Id = -1;
        string Role = "";
        public Profile(int id, string role)
        {
            db = new ExaminationSystemContext();
            Id = id;
            Role = role;
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_name.ReadOnly == true)
            {
                txt_name.ReadOnly = false;
                txt_email.ReadOnly = false;
                //if(Role == "Student")
                //{
                //    txt_email.ReadOnly = false;
                //}
            }
            else
            {
                if (!txt_name.Text.IsNullOrEmpty() && !txt_email.Text.IsNullOrEmpty() && !txt_data.Text.IsNullOrEmpty())
                {
                    if (Role == "Student")
                    {
                        Student stu = db.Students.FromSql($"EXECUTE dbo.SelectStudentByID {Id}").AsEnumerable().SingleOrDefault();
                        stu.Name = txt_name.Text;
                        stu.Email = txt_email.Text;
                        db.SaveChanges();
                        msg("Updated");
                    }
                    else if(Role == "Instructor")
                    {
                        Instructor ins = db.Instructors.FromSql($"EXECUTE dbo.Select_Instructor_Id {Id}").AsEnumerable().SingleOrDefault();
                        ins.Name = txt_name.Text;
                        ins.Email = txt_email.Text;
                        db.SaveChanges();
                        msg("Updated");
                    }
                }
            }
        }
        void msg(string msg)
        {
            MessageBox.Show(msg);
            txt_name.ReadOnly = true;
            txt_email.ReadOnly = true;
            txt_data.ReadOnly = true;
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            if (Role == "Student")
            {
                var Stud = db.Students.FromSql($"EXECUTE dbo.SelectStudentByID {Id}").AsEnumerable().SingleOrDefault();
                txt_name.Text = Stud.Name;
                txt_email.Text = Stud.Email;
                var dept = db.Departments.FromSql($"EXECUTE dbo.Select_DepartmentByid {Stud.DeptId}").AsEnumerable().SingleOrDefault();
                txt_data.Text = dept.Name;
                lbl_data.Text = "Department Name";
                btn_Reports.Visible=false;

            }
            else if (Role == "Instructor")
            {
                var Ins = db.Instructors.FromSql($"EXECUTE dbo.Select_Instructor_Id {Id}").AsEnumerable().SingleOrDefault();
                txt_name.Text = Ins.Name;
                txt_email.Text = Ins.Email;
                txt_data.Text = Ins.Salary.ToString();
                lbl_data.Text = "Salary";
            }
        }

        private void btn_pass_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_courses_Click(object sender, EventArgs e)
        {
            if (Role == "Student")
            {
                StudentCoursesForm coursesStud = new StudentCoursesForm(Id);
                this.Hide();
                coursesStud.ShowDialog();
                this.Close();

            }
            else if (Role == "Instructor")
            {
               
                
            }
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            LogIn log=new LogIn();
            this.Hide();
            log.ShowDialog();
            this.Close();
        }
    }
}
