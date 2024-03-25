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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Examination_System
{
    public partial class StudentExamForm : Form
    {
        ExaminationSystemContext db;
        private TimeSpan examDuration = TimeSpan.FromMinutes(15);
        private TimeSpan remainingTime;
        private DateTime startTime;
        int CID = -1;
        int EID = -1;
        int StuID = -1;
        int Q_id = -1;
        string StudAns = "";
        int currentQuestionIndex = 0;
        List<ExamStQ> QuestionsList;
        public StudentExamForm(int CourceID, int studID)
        {
            InitializeComponent();
            db = new ExaminationSystemContext();
            CID = CourceID;
            StuID = studID;
            remainingTime = examDuration;
        }
        class ExamViewModel
        {
            public int Id { get; set; }
            public string Msg { get; set; }
        }

        private void StudExam_Load(object sender, EventArgs e)
        {
            GenerateExam();
            startTime = DateTime.Now;
            Timer.Start();
        }
        void GenerateExam()
        {
            var examData = db.Database.SqlQuery<ExamViewModel>($"EXECUTE Generate_Exam 'test', {CID}, {StuID}").AsEnumerable().SingleOrDefault();
            if (examData != null && examData.Id != -1)
            {
                EID = examData.Id;
                Next_Back_btn();
                GetExamQuestion();
                ResetAnswers();
                DisplayCurrentQuestion();
            }
            else
            {
                if (examData.Msg == "you have already done an exam on the same course")
                {
                    var id = db.ExamStQs.FirstOrDefault(d => d.StudentId == StuID);
                    MessageBox.Show(examData.Msg);
                    FinalResultForm result = new FinalResultForm(id.ExamId, CID, StuID);
                    this.Hide();
                    result.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(examData.Msg);
                    StudentCoursesForm stud = new StudentCoursesForm(StuID);
                    this.Hide();
                    stud.ShowDialog();
                    this.Close();
                }
            }
        }
        void GetExamQuestion()
        {
            QuestionsList = db.ExamStQs.FromSql($"EXECUTE Select_Exam_st_Q_For_Exam {EID},{StuID}").AsEnumerable().ToList();
            lbl_Etitle.Text = db.Exams.FromSql($"EXECUTE Select_exam {EID}").AsEnumerable().SingleOrDefault().Title;
        }
        void ResetAnswers()
        {
            rb_ans1.Checked = false;
            rb_ans2.Checked = false;
            rb_ans3.Checked = false;
            rb_ans4.Checked = false;
        }
        string GetCourseName(int? courseId)
        {
            if (courseId == null) return "Not Found";
            var cname = db.Courses.FromSql($"EXECUTE dbo.Select_Course {courseId}").AsEnumerable().SingleOrDefault();
            return cname.Name;
        }

        private void DisplayCurrentQuestion()
        {
            if (currentQuestionIndex >= 0 && currentQuestionIndex < QuestionsList.Count)
            {
                ExamStQ currentQuestion = QuestionsList[currentQuestionIndex];
                Q_id = currentQuestion.QId;
                var Current = db.Questions.FromSql($"EXECUTE dbo.Select_Question_ById {Q_id}").AsEnumerable().SingleOrDefault();
                lbl_index.Text = $"{currentQuestionIndex+1} - ";
                lbl_question.Text = Current.Title;
                lbl_grade.Text = $"{Current.Grade.ToString()} marks";
                lbl_Cname.Text = GetCourseName(Current.CourseId);
                var chocies = db.QuestionChoices.FromSql($"EXECUTE dbo.Select_Question_choices_ById {Q_id}").AsEnumerable().ToList();
                if (chocies != null)
                {
                    rb_ans1.Text = chocies[0].Choice ?? "";
                    rb_ans2.Text = chocies[1].Choice ?? "";

                    if (Current.Type == 0)
                    {
                        lbl_Type.Text = "T/F Question: ";
                        rb_ans3.Visible = false;
                        rb_ans4.Visible = false;
                    }
                    else
                    {
                        lbl_Type.Text = "Mcq Question: ";
                        rb_ans3.Text = chocies[2].Choice ?? "";
                        rb_ans4.Text = chocies[3].Choice ?? "";
                        rb_ans3.Visible = true;
                        rb_ans4.Visible = true;
                    }

                    ResetAnswers();

                    if (currentQuestion.Answer != null)
                    {
                        foreach (var choice in chocies)
                        {
                            if (choice.Choice == currentQuestion.Answer)
                            {
                                if (choice.Choice == rb_ans1.Text)
                                    rb_ans1.Checked = true;
                                else if (choice.Choice == rb_ans2.Text)
                                    rb_ans2.Checked = true;
                                else if (choice.Choice == rb_ans3.Text)
                                    rb_ans3.Checked = true;
                                else if (choice.Choice == rb_ans4.Text)
                                    rb_ans4.Checked = true;
                                StudAns = currentQuestion.Answer;
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void UpdateAnswer(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                //db.Database.ExecuteSqlRaw($"EXECUTE dbo.update_Exam_St_Q {EID}, {StuID}, {Q_id}, '{radioButton.Text}'");
                db.Database.ExecuteSqlRaw("EXECUTE dbo.update_Exam_St_Q {0}, {1}, {2}, {3}",EID, StuID, Q_id, radioButton.Text);
                var questionToUpdate = QuestionsList.FirstOrDefault(q => q.QId == Q_id);
                if (questionToUpdate != null)
                {
                    questionToUpdate.Answer = radioButton.Text;
                }
                db.SaveChanges();
            }
        }
        void Next_Back_btn()
        {
            if (currentQuestionIndex == 0)
            {
                btn_back.Visible = false;
                btn_next.Visible = true;
                btn_submit.Visible = false;
            }
            else if (currentQuestionIndex == QuestionsList.Count - 1)
            {
                btn_next.Visible = false;
                btn_back.Visible = true;
                btn_submit.Visible = true;
            }
            else
            {
                btn_next.Visible = true;
                btn_back.Visible = true;
                btn_submit.Visible = false;

            }
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex < QuestionsList.Count - 1)
            {
                if (QuestionsList[currentQuestionIndex].Answer != null)
                {
                    Button btn = Controls.Find($"btn{currentQuestionIndex + 1}", true).FirstOrDefault() as Button;

                    // Change the background color of the button
                    if (btn != null)
                    {
                        btn.BackColor = Color.LightGray; 
                    }
                }
                currentQuestionIndex++;
                DisplayCurrentQuestion();

            }
            Next_Back_btn();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex > 0)
            {
                if (QuestionsList[currentQuestionIndex].Answer != null)
                {
                    Button btn = Controls.Find($"btn{currentQuestionIndex + 1}", true).FirstOrDefault() as Button;
                    if (btn != null)
                    {
                        btn.BackColor = Color.LightGray;
                    }
                }
                currentQuestionIndex--;
                DisplayCurrentQuestion();
            }
            Next_Back_btn();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            FinalResultForm result = new FinalResultForm(EID, CID, StuID);
            this.Hide();
            result.ShowDialog();
            this.Close();
        }

        private void DisplayQuestionByButtonIndex(int questionIndex)
        {
            if (questionIndex < QuestionsList.Count)
            {
                currentQuestionIndex = questionIndex;
                DisplayCurrentQuestion();
            }
            Next_Back_btn();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //DisplayQuestionByButtonIndex(int.Parse(btn.Text) - 1);
            if (btn != null && int.TryParse(btn.Text, out int buttonNumber))
            {
                if (QuestionsList[currentQuestionIndex].Answer != null)
                {
                    Button btn2 = Controls.Find($"btn{currentQuestionIndex + 1}", true).FirstOrDefault() as Button;

                    // Change the background color of the button
                    if (btn2 != null)
                    {
                        btn.BackColor = Color.LightGray;
                    }
                }
                DisplayQuestionByButtonIndex(buttonNumber - 1);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            remainingTime = examDuration - elapsedTime;

            if (remainingTime <= TimeSpan.Zero)
            {
                Timer.Stop();
                remainingTime = TimeSpan.Zero;
                UpdateTimerDisplay();
                btn_submit_Click(sender, e);
            }
            else
            {
                UpdateTimerDisplay();
            }
        }

        private void UpdateTimerDisplay()
        {
            lbl_timer.Text = remainingTime.ToString(@"hh\:mm\:ss");
        }
    }
}
