using Examination_System.Models;
using Microsoft.EntityFrameworkCore;
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

namespace Examination_System
{
    public partial class Update_password : Form
    {
        int Id = -1;
        string Role = "";
        ExaminationSystemContext db;
        public Update_password(int id,string role)
        {
            Id = id;
            InitializeComponent();
            Role = role;
            db= new ExaminationSystemContext();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!txt_old.Text.IsNullOrEmpty() && !txt_new.Text.IsNullOrEmpty() && !txt_confirm.Text.IsNullOrEmpty())
            {
                if (Role == "Student")
                {
                    Student stu = db.Students.FromSql($"EXECUTE dbo.SelectStudentByID {Id}").AsEnumerable().SingleOrDefault();
                    if (stu.Password == txt_old.Text && txt_new.Text == txt_confirm.Text)
                    {
                        stu.Password = txt_new.Text;
                        db.SaveChanges();
                        msg("Updated");
                    }
                    else
                    {
                        MessageBox.Show($"Invalid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Role == "Instructor")
                {
                    Instructor ins = db.Instructors.FromSql($"EXECUTE dbo.Select_Instructor_Id {Id}").AsEnumerable().SingleOrDefault();
                    if (ins.Password == txt_old.Text && txt_new.Text == txt_confirm.Text)
                    {
                        ins.Password = txt_new.Text;
                        db.SaveChanges();
                        msg("Updated");
                    }
                    else
                    {
                        MessageBox.Show($"Invalid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show($"Invalid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void msg(string msg)
        {
            MessageBox.Show(msg);
            txt_old.Text = txt_new.Text = txt_confirm.Text = "";
            //Profile profile = new Profile(Id, Role);
            //this.Hide();
            //profile.ShowDialog();
            //this.Close();
        }
        private void btn_profile_Click(object sender, EventArgs e)
        {
            Profile profile=new Profile(Id,Role);
            this.Hide();
            profile.ShowDialog();
            this.Close();
        }
    }
}
