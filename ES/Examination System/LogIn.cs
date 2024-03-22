using Examination_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Examination_System
{
    public partial class LogIn : Form
    {
        ExaminationSystemContext db;
        String Selected_Role = "Student";
        int id = -1;
        public LogIn()
        {
            db = new ExaminationSystemContext();
            InitializeComponent();
        }
        public void LogIn_Load(object sender, EventArgs e)
        {
            Cb_type.Items.Add("Student");
            Cb_type.Items.Add("Instructor");
            Cb_type.SelectedIndex = 0;
            Selected_Role = Cb_type.SelectedItem.ToString();
        }
        public void Cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected_Role = Cb_type.SelectedItem.ToString();
        }

        private void Btn_LogIn_Click(object sender, EventArgs e)
        {
            string Email = Txt_Email.Text;
            string Password = Txt_Password.Text;
            if (Selected_Role == "Student" && !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password))
            {
                var Stud = db.Students.FromSql($"EXECUTE dbo.Select_Student_Email {Email}").AsEnumerable().SingleOrDefault();
                if (Stud != null && Password == Stud.Password)
                {
                    id=Stud.Id;
                    this.Hide();
                    Profile profile=new Profile(id, Selected_Role);
                    profile.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Selected_Role == "Instructor" && !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password))
            {
                var Ins = db.Instructors.FromSql($"EXECUTE dbo.Select_Instructor_Email {Email}").AsEnumerable().SingleOrDefault();
                if (Ins != null && Password == Ins.Password)
                {
                    id=Ins.Id;
                    this.Hide();
                    Profile profile = new Profile(id, Selected_Role);
                    profile.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

       
    }
}
