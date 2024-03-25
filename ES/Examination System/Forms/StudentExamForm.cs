using Examination_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Examination_System
{
    public partial class StudentExamForm : Form
    {
        private readonly ExaminationSystemContext db;
        private readonly TimeSpan examDuration = TimeSpan.FromMinutes(15);
        private readonly int CID;
        private readonly int StuID;
        private int EID = -1;
        private int Q_id = -1;
        private string StudAns = "";
        private int currentQuestionIndex = 0;
        private List<ExamStQ> QuestionsList;
        private DateTime startTime;
        private TimeSpan remainingTime;


        private ProgressBar progressBar;
        public StudentExamForm(int CourceID, int studID)
        {
            InitializeComponent();
            db = new ExaminationSystemContext();
            CID = CourceID;
            StuID = studID;
            remainingTime = examDuration;


            // Initialize the ProgressBar
            progressBar = new ProgressBar();
            progressBar.Location = new Point(10, 10); // Set the location
            progressBar.Size = new Size(200, 20); // Set the size
            progressBar.Minimum = 0; // Set the minimum value
            progressBar.Maximum = 100; // Set the maximum value
            progressBar.Value = 0; // Set the initial value
            progressBar.Style = ProgressBarStyle.Continuous; // Set the style
            Controls.Add(progressBar);
        }

        private void UpdateProgressBar(int value)
        {
            // Ensure the value is within the minimum and maximum range
            value = Math.Max(progressBar.Minimum, Math.Min(progressBar.Maximum, value));
            progressBar.Value = value;
        }

        private void StudExam_Load(object sender, EventArgs e)
        {
            try
            {
                GenerateExam();
                startTime = DateTime.Now;
                Timer.Start();

                // Update progress bar to indicate exam loading progress
                UpdateProgressBar(25);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void GenerateExam()
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
                if (examData?.Msg == "you have already done an exam on the same course")
                {
                    var id = db.ExamStQs.FirstOrDefault(d => d.StudentId == StuID);
                    MessageBox.Show(examData.Msg);
                    FinalResultForm result = new FinalResultForm(id.ExamId, CID, StuID);
                    Hide();
                    result.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show(examData?.Msg ?? "No exam found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    StudentCoursesForm stud = new StudentCoursesForm(StuID);
                    Hide();
                    stud.ShowDialog();
                    Close();
                }
            }
        }

        private void GetExamQuestion()
        {
            QuestionsList = db.ExamStQs.FromSql($"EXECUTE Select_Exam_st_Q_For_Exam {EID},{StuID}").ToList();
            lbl_Etitle.Text = db.Exams.FromSql($"EXECUTE Select_exam {EID}").AsEnumerable().SingleOrDefault()?.Title;
        }

        private void ResetAnswers()
        {
            rb_ans1.Checked = false;
            rb_ans2.Checked = false;
            rb_ans3.Checked = false;
            rb_ans4.Checked = false;
        }

        private string GetCourseName(int? courseId)
        {
            var cname = db.Courses.FromSql($"EXECUTE dbo.Select_Course {courseId}").AsEnumerable().SingleOrDefault();
            return cname?.Name ?? "Not Found";
        }

        private void DisplayCurrentQuestion()
        {
            if (currentQuestionIndex >= 0 && currentQuestionIndex < QuestionsList.Count)
            {
                ExamStQ currentQuestion = QuestionsList[currentQuestionIndex];
                Q_id = currentQuestion.QId;
                var Current = db.Questions.FromSql($"EXECUTE dbo.Select_Question_ById {Q_id}").AsEnumerable().SingleOrDefault();
                lbl_index.Text = $"{currentQuestionIndex + 1} - ";
                lbl_question.Text = Current?.Title ?? "Question not found";
                lbl_grade.Text = $"{Current?.Grade.ToString() ?? "0"} marks";
                lbl_Cname.Text = GetCourseName(Current?.CourseId);
                var chocies = db.QuestionChoices.FromSql($"EXECUTE dbo.Select_Question_choices_ById {Q_id}").ToList();
                if (chocies != null)
                {
                    rb_ans1.Text = chocies.ElementAtOrDefault(0)?.Choice ?? "";
                    rb_ans2.Text = chocies.ElementAtOrDefault(1)?.Choice ?? "";

                    if (Current?.Type == 0)
                    {
                        lbl_Type.Text = "T/F Question: ";
                        rb_ans3.Visible = false;
                        rb_ans4.Visible = false;
                    }
                    else
                    {
                        lbl_Type.Text = "Mcq Question: ";
                        rb_ans3.Text = chocies.ElementAtOrDefault(2)?.Choice ?? "";
                        rb_ans4.Text = chocies.ElementAtOrDefault(3)?.Choice ?? "";
                        rb_ans3.Visible = true;
                        rb_ans4.Visible = true;
                    }

                    ResetAnswers();

                    if (!string.IsNullOrEmpty(currentQuestion.Answer))
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
               
                db.Database.ExecuteSqlRaw("EXECUTE dbo.update_Exam_St_Q {0}, {1}, {2}, {3}", EID, StuID, Q_id, radioButton.Text);
                var questionToUpdate = QuestionsList.FirstOrDefault(q => q.QId == Q_id);
                if (questionToUpdate != null)
                {
                    questionToUpdate.Answer = radioButton.Text;
                }
                db.SaveChanges();
            }
        }

        private void Next_Back_btn()
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
            if (ValidateAnswerSelected())
            {
                if (currentQuestionIndex < QuestionsList.Count - 1)
                {
                    currentQuestionIndex++;
                    DisplayCurrentQuestion();

                    int progress = (currentQuestionIndex + 1) * 100 / QuestionsList.Count;
                    UpdateProgressBar(progress);
                }
                Next_Back_btn();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (ValidateAnswerSelected())
            {
                if (currentQuestionIndex > 0)
                {
                    currentQuestionIndex--;
                    DisplayCurrentQuestion();
                }
                Next_Back_btn();
            }
        }

        private bool ValidateAnswerSelected()
        {
            if (!rb_ans1.Checked && !rb_ans2.Checked && !rb_ans3.Checked && !rb_ans4.Checked)
            {
                MessageBox.Show("Please select an answer before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (ValidateAnswerSelected())
            {
                Timer.Stop();
                FinalResultForm result = new FinalResultForm(EID, CID, StuID);
                Hide();
                result.ShowDialog();
                Close();

                UpdateProgressBar(100);
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

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && int.TryParse(btn.Text, out int buttonNumber))
            {
                if (ValidateAnswerSelected())
                {
                    DisplayQuestionByButtonIndex(buttonNumber - 1);
                }
            }
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
    }

    internal class ExamViewModel
    {
        public int Id { get; set; }
        public string Msg { get; set; }
    }
}
