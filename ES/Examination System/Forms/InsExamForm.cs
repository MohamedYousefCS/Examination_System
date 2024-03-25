using Examination_System.Models;
using System.Diagnostics;

namespace Examination_System
{
    public partial class InsExamForm : Form
    {
        int InsID = -1;
        int CourseID = -1;

        ExaminationSystemContext db;
        public InsExamForm(int Insid,int Courseid)
        {
            InsID = Insid;
            CourseID = Courseid;
            InitializeComponent();
            db = new ExaminationSystemContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /////
            DataGridView.DataSource = db.Questions.Where(q=>q.CourseId== CourseID).Select(s => new { s.Id, s.Title, s.Type, s.Grade }).ToList();
            update_btn.Visible = false;
            delete_btn.Visible = false;
            add_btn.Visible = true;

        }

        public void clear()
        {
            TF_radio.Checked = false;
            mcq_radio.Checked = false;
            TF_radio.Visible = true;
            mcq_radio.Visible = true;

            isCorrect1.Checked = false;
            isCorrect2.Checked = false;
            isCorrect3.Checked = false;
            isCorrect4.Checked = false;

            choice3.Visible = true;
            choice4.Visible = true;

            course_name.Text = title.Text = grade.Text = choice1.Text = choice2.Text = choice3.Text = choice4.Text = "";

        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            string questionText = title.Text;

            //string courseName = course_name.Text;

            int questionType = mcq_radio.Checked ? 1 : 0;

            //Course existingCourse = db.Courses.FirstOrDefault(c => c.Name == courseName);
            //if (existingCourse == null)
            //{
            //    MessageBox.Show("There is no course with this name.");
            //    return;
            //}

            List<string> choices = new List<string>();
            choices.Add(choice1.Text);
            choices.Add(choice2.Text);

            if (questionType == 1)
            {
                choices.Add(choice3.Text);
                choices.Add(choice4.Text);
            }

            Question newQuestion = new Question
            {
                Title = questionText,
                Type = (byte)questionType,
                Grade = int.Parse(grade.Text),
                CourseId =CourseID
                //CourseId = existingCourse.Id
            };
            db.Questions.Add(newQuestion);

            db.SaveChanges();

            int questionId = newQuestion.Id;


            int choiceIndex = 0;
            foreach (string choiceText in choices)
            {
                QuestionChoice newChoice = new QuestionChoice
                {
                    QId = questionId,
                    Choice = choiceText
                };


                switch (choiceIndex)
                {
                    case 0:
                        newChoice.IsCorrect = isCorrect1.Checked;
                        break;
                    case 1:
                        newChoice.IsCorrect = isCorrect2.Checked;
                        break;
                    case 2:
                        newChoice.IsCorrect = isCorrect3.Checked;
                        break;
                    case 3:
                        newChoice.IsCorrect = isCorrect4.Checked;
                        break;
                    default:
                        MessageBox.Show("There is an Error");
                        break;
                }



                db.QuestionChoices.Add(newChoice);
                choiceIndex++;
            }


            db.SaveChanges();

            //DataGridView.DataSource = db.Questions.Select(s => new { s.Id, s.Title, s.Type, s.Grade }).ToList();
            DataGridView.DataSource = db.Questions.Where(q => q.CourseId == CourseID).Select(s => new { s.Id, s.Title, s.Type, s.Grade }).ToList();

            MessageBox.Show("Question added successfully.");

            clear();


        }


        private void DataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            add_btn.Visible = false;
            update_btn.Visible = true;
            delete_btn.Visible = true;

            if (e.RowIndex >= 0)
            {
                var questionId = (int)DataGridView.Rows[e.RowIndex].Cells["Id"].Value;
                Question q = db.Questions.FirstOrDefault(q => q.Id == questionId);
                Course c = db.Courses.FirstOrDefault(c => c.Id == q.CourseId);

                title.Text = q.Title;
                grade.Text = q.Grade.ToString();

                if (q.Type == 0)
                {
                    isCorrect3.Visible = false;
                    isCorrect4.Visible = false;
                    TF_radio.Checked = true;
                    TF_radio.Visible = true;
                    mcq_radio.Checked = false;
                    mcq_radio.Visible = false;
                }
                else if (q.Type == 1)
                {
                    choice1.ReadOnly = false;
                    choice2.ReadOnly = false;
                    isCorrect3.Visible = true;
                    isCorrect4.Visible = true;
                    mcq_radio.Checked = true;
                    mcq_radio.Visible = true;
                    TF_radio.Visible = false;
                    TF_radio.Checked = false;
                }

                course_name.Text = c.Name;

                var selectedQuestionWithChoices = db.Questions
                    .Where(q => q.Id == questionId)
                    .Select(q => new
                    {
                        Question = q,
                        Choices = db.QuestionChoices.Where(c => c.QId == q.Id).ToList(),
                        CorrectAnswer = db.QuestionChoices.FirstOrDefault(c => c.QId == q.Id && c.IsCorrect == true)
                    })
                    .FirstOrDefault();

                if (selectedQuestionWithChoices != null)
                {
                    choice1.Text = "";
                    choice2.Text = "";
                    choice3.Text = "";
                    choice4.Text = "";

                    if (selectedQuestionWithChoices.Question.Type == 0)
                    {
                        choice3.Visible = false;
                        choice4.Visible = false;
                    }
                    else if (selectedQuestionWithChoices.Question.Type == 1)
                    {
                        choice3.Visible = true;
                        choice4.Visible = true;
                    }

                    for (int i = 0; i < selectedQuestionWithChoices.Choices.Count && i < 4; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                choice1.Text = selectedQuestionWithChoices.Choices[i].Choice;
                                break;
                            case 1:
                                choice2.Text = selectedQuestionWithChoices.Choices[i].Choice;
                                break;
                            case 2:
                                choice3.Text = selectedQuestionWithChoices.Choices[i].Choice;
                                break;
                            case 3:
                                choice4.Text = selectedQuestionWithChoices.Choices[i].Choice;
                                break;
                        }
                    }

                    if (selectedQuestionWithChoices.CorrectAnswer != null)
                    {
                        if (q.Type == 0)
                        {
                            if (selectedQuestionWithChoices.CorrectAnswer.Choice == choice1.Text)
                                isCorrect1.Checked = true;
                            else
                                isCorrect2.Checked = true;

                        }

                        else if (q.Type == 1)
                        {
                            if (selectedQuestionWithChoices.CorrectAnswer.Choice == choice1.Text)
                                isCorrect1.Checked = true;

                            else if (selectedQuestionWithChoices.CorrectAnswer.Choice == choice2.Text)
                                isCorrect2.Checked = true;

                            else if (selectedQuestionWithChoices.CorrectAnswer.Choice == choice3.Text)
                                isCorrect3.Checked = true;

                            else if (selectedQuestionWithChoices.CorrectAnswer.Choice == choice4.Text)
                                isCorrect4.Checked = true;
                        }
                    }
                }
            }
        }


        private void mcq_radio_CheckedChanged(object sender, EventArgs e)
        {
            choice1.Text = "";
            choice2.Text = "";
            choice1.ReadOnly = false;
            choice2.ReadOnly = false;
            choice3.Visible = true;
            choice4.Visible = true;
            isCorrect3.Visible = true;
            isCorrect4.Visible = true;
        }

        private void TF_radio_CheckedChanged(object sender, EventArgs e)
        {
            choice1.Text = "True";
            choice1.ReadOnly = true;
            choice2.Text = "False";
            choice2.ReadOnly = true;

            choice3.Visible = false;
            choice4.Visible = false;
            isCorrect3.Visible = false;
            isCorrect4.Visible = false;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            var questionId = (int)DataGridView.SelectedRows[0].Cells[0].Value;
            if (
                MessageBox.Show("are you sure to delete this student", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Question q = db.Questions.Where(n => n.Id == questionId).FirstOrDefault();
                db.Questions.Remove(q);
                db.SaveChanges();

                title.Text = grade.Text = course_name.Text = choice1.Text = choice2.Text = choice3.Text = choice4.Text = "";
                //DataGridView.DataSource = db.Questions.Select(s => new { s.Id, s.Title, s.Type, s.Grade }).ToList();
                DataGridView.DataSource = db.Questions.Where(q => q.CourseId == CourseID).Select(s => new { s.Id, s.Title, s.Type, s.Grade }).ToList();

                update_btn.Visible = false;
                delete_btn.Visible = false;
                add_btn.Visible = true;

                clear();

                MessageBox.Show("Question Deleted successfully.");



            }
        }


        private void update_btn_Click(object sender, EventArgs e)
        {
            if (DataGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select a question to update.");
                return;
            }

            int questionId = Convert.ToInt32(DataGridView.CurrentRow.Cells["Id"].Value);

            Question existingQuestion = db.Questions.FirstOrDefault(q => q.Id == questionId);
            if (existingQuestion == null)
            {
                MessageBox.Show("The selected question does not exist.");
                return;
            }

            string questionText = title.Text;

            //string courseName = course_name.Text;

            //Course existingCourse = db.Courses.FirstOrDefault(c => c.Name == courseName);
            //if (existingCourse == null)
            //{
            //    MessageBox.Show("There is no course with this name.");
            //    return;
            //}

            existingQuestion.Title = questionText;
            existingQuestion.CourseId = CourseID;
            //existingQuestion.CourseId = existingCourse.Id;

            existingQuestion.Type = (byte)((TF_radio.Checked) ? 0 : 1);

            List<string> choices = new List<string>();
            choices.Add(choice1.Text);
            choices.Add(choice2.Text);
            if (existingQuestion.Type == 1)
            {
                choices.Add(choice3.Text);
                choices.Add(choice4.Text);
            }

            var existingChoices = db.QuestionChoices.Where(c => c.QId == questionId).ToList();
            db.QuestionChoices.RemoveRange(existingChoices);

            foreach (var choiceText in choices)
            {
                var newChoice = new QuestionChoice
                {
                    QId = questionId,
                    Choice = choiceText,
                    IsCorrect = (choiceText == choice1.Text) ? isCorrect1.Checked :
                                (choiceText == choice2.Text) ? isCorrect2.Checked :
                                (choiceText == choice3.Text) ? isCorrect3.Checked :
                                (choiceText == choice4.Text) ? isCorrect4.Checked : false
                };
                try
                {
                    db.QuestionChoices.Add(newChoice);
                }
                catch
                {
                    MessageBox.Show("An error occurred while Adding the question choices!!");

                }

            }

            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("An error occurred while updating the question choices!!");
                return;
            }


            add_btn.Visible = true;
            update_btn.Visible = false;
            delete_btn.Visible = false;

            clear();



            MessageBox.Show("Question updated successfully.");


            db.SaveChanges();
            //DataGridView.DataSource = db.Questions.Select(s => new { s.Id, s.Title, s.Type, s.Grade }).ToList();
            DataGridView.DataSource = db.Questions.Where(q => q.CourseId == CourseID).Select(s => new { s.Id, s.Title, s.Type, s.Grade }).ToList();

        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            Course_InstForm ins=new Course_InstForm(InsID);
            this.Hide();
            ins.ShowDialog();
            this.Close();
        }
    }
}
